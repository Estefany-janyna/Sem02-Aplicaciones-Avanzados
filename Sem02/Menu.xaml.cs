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
using System.Windows.Shapes;

namespace Sem02
{
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirVentana1_Click(object sender, RoutedEventArgs e)
        {
            Operaciones ventana1 = new Operaciones();
            ventana1.Show();
        }

        private void AbrirVentana2_Click(object sender, RoutedEventArgs e)
        {
            Mantenimientos ventana2 = new Mantenimientos();
            ventana2.Show();
        }

        private void AbrirVentana3_Click(object sender, RoutedEventArgs e)
        {
            Reportes ventana3 = new Reportes();
            ventana3.Show();
        }
    }
}