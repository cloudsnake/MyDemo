using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FtpClient.ViewModels
{
    /*
        FTP的匿名登录一般有三种：
        1、 用户名：anonymous 密码：Email或者为空
        2、 用户名：FTP 密码：FTP或者为空
        3、 用户名：USER 密码：pass 
     */
    public class ClientUiViewModel : BindableBase
    {
        private FluentFTP.FtpClient ftpClient = null;
        private string ftpName;
        public string FtpName
        {
            get { return ftpName; }
            set { SetProperty(ref ftpName, value); }
        }
        private string ftpPassword;
        public string FtpPassword
        {
            get { return ftpPassword; }
            set { SetProperty(ref ftpPassword, value); }
        }

        private string ftpStatus;
        public string FtpStatus
        {
            get { return ftpStatus; }
            set { SetProperty(ref ftpStatus, value); }
        }

        public DelegateCommand LoginFtpServerCommand { get; set; }
        public DelegateCommand UploadFileCommand { get; set; }
        public ClientUiViewModel()
        {
            FtpName = "anonymous";
            FtpPassword = "";
            LoginFtpServerCommand = new DelegateCommand(OnLoginFtpServer);
            UploadFileCommand = new DelegateCommand(OnUploadFile);
        }

        private void OnLoginFtpServer()
        {
            ftpClient = new FluentFTP.FtpClient("127.0.0.1", FtpName, FtpPassword);
            ftpClient.Connect();
            if (ftpClient.IsConnected)
            {
                FtpStatus = "登录成功！";
            }
            else
            {
                FtpStatus = "登录失败！";
            }
        }
        private void OnUploadFile()
        {
            if (ftpClient != null && ftpClient.IsConnected)
            {
                // Configure open file dialog box
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.FileName = "Document"; // Default file name
                dlg.DefaultExt = ".*"; // Default file extension
                dlg.Filter = "All File(.*)|*.*"; // Filter files by extension

                // Show open file dialog box
                Nullable<bool> result = dlg.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    string filename = dlg.FileName;
                    FileInfo fileInfo = new FileInfo(filename);
                    string rotom = $"/{fileInfo.Name}";
                    ftpClient.UploadFile(filename, rotom);
                }
            }
        }
    }
}
