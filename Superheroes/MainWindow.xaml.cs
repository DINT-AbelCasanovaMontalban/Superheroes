using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Superheroe superheroe;

        public MainWindow()
        {
            InitializeComponent();
            superheroe = Superheroe.GetSample();
            GridBot.DataContext = superheroe;
            fotoImage.DataContext = superheroe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridRight.DataContext = superheroe;
            Binding b = new Binding(superheroe.Nombre);
            b.Mode = BindingMode.TwoWay;
            NombreTextBox.SetBinding(TextBox.TextProperty,b);
            
        }
    }
}
