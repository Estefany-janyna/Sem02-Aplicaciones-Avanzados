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
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }
        private void Ingreso_Click(object sender, RoutedEventArgs e)
        {
            Ingreso ventana1 = new Ingreso();
            ventana1.Show();
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            Salida salida = new Salida();
            salida.Show();
        }
    }
}
