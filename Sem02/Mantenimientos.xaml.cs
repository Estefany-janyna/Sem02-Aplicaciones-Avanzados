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
    /// <summary>
    /// Lógica de interacción para Mantenimientos.xaml
    /// </summary>
    public partial class Mantenimientos : Window
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }
        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Conductores ventana1 = new Conductores();
            ventana1.Show();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            Camiones ventana2 = new Camiones();
            ventana2.Show();
        }
    }
}
