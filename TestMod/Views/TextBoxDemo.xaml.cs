using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TestMod.ViewModels;

namespace TestMod.Views
{
    /// <summary>
    /// Interaction logic for TextBoxDemo
    /// </summary>
    public partial class TextBoxDemo : UserControl
    {
        private TextBoxDemoViewModel model;
        public TextBoxDemo()
        {
            InitializeComponent();
            model = this.DataContext as TextBoxDemoViewModel;
            
        }

        private void Text1_OnTextInput(object sender, TextCompositionEventArgs e)
        {
            var s = text1.Text;
        }

        private void Text1_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var ds = e.Source as TextBox;
            var doubleDs = ds.Text;
            double fenx = 0.0;
            if (double.TryParse(doubleDs,out fenx) && model != null)
            {
                model.Fenshu10 = fenx * 10;
            }
            else if(model != null)
            {
                model.Fenshu10 = 0.0;
            }
            if (ds.Text == "1111")
            {
                this.text1.Background=Brushes.Red;
                
            }
            else if (ds.Text == "2222")
            {
                this.text1.Background = Brushes.GreenYellow;

            }
            else
            {
                this.text1.Background = Brushes.Transparent;

            }
        }
    }
}
