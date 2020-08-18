using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace TestMod.Models
{
    public class AddFileButtonColumn : Telerik.Windows.Controls.GridViewColumn
    {
        public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
        {
            RadButton button = cell.Content as RadButton;
            if (button == null)
            {
                button = new RadButton();
                button.Content = "添加文件";
                button.Command = new AddFileCommand();
            }

            button.CommandParameter = dataItem;

            return button;
        }
    }
}