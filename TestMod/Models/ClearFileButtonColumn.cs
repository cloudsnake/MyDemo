using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace TestMod.Models
{
    public class ClearFileButtonColumn : Telerik.Windows.Controls.GridViewColumn
    {
        public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
        {
            RadButton button = cell.Content as RadButton;
            if (button == null)
            {
                button = new RadButton();
                button.Content = "删除所有文件";
                button.Command = new ClearFileCommand();
            }

            button.CommandParameter = dataItem;

            return button;
        }
    }
}