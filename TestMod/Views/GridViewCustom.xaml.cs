using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using TestMod.Models;

namespace TestMod.Views
{
    /// <summary>
    /// Interaction logic for GridViewCustom
    /// </summary>
    public partial class GridViewCustom : UserControl
    {
        public GridViewCustom()
        {
            InitializeComponent();
        }
        private void InnerPressureView_OnCellEditEnded(object? sender, GridViewCellEditEndedEventArgs e)
        {
            if (e.Cell.Column.UniqueName== "TbEntity6s.Amount1")
            {
                var bfs = 0.0;
                double.TryParse(e.Cell.Value.ToString(), out bfs);
                e.Cell.ParentRow.Cells[6].Content = bfs * 1000/100.00;

                var dc = e.Cell.ParentRow.DataContext as CustomData;
                if (dc != null)
                {
                    dc.TbEntity6s.Amount2 = bfs * 1000 / 100.0;
                }
            }
        }

        //private void InnerPressureView_OnCellValidating(object? sender, GridViewCellValidatingEventArgs e)
        //{
        //    if (e.Cell.Column.UniqueName == "TbEntity6s.Amount1")
        //    {
        //        var bfs = 0.0;
        //        double.TryParse(e.Cell.Value.ToString(), out bfs);
        //        e.Cell.ParentRow.Cells[6].Content = bfs * 1000 / 100.00;
        //    }
        //}

        //private void InnerPressureView_OnCurrentCellChanged(object? sender, GridViewCurrentCellChangedEventArgs e)
        //{
        //    if (e.OldCell == null) 
        //    {
        //        return;
        //    }
        //    if (e.OldCell.Column.UniqueName == "TbEntity6s.Amount1")
        //    {
        //        var bfs = 0.0;
        //        double.TryParse(e.OldCell.Value.ToString(), out bfs);
        //        e.OldCell.ParentRow.Cells[6].Content = bfs * 1000 / 100.00;
        //    }
        //}
    }
}
