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
    public partial class Conductores : Window
    {
        public Conductores()
        {
            InitializeComponent();
            CargarDatos(); // Llama al método para cargar los datos de ejemplo
        }

        private void CargarDatos()
        {
            // Carga de datos de ejemplo (puedes reemplazar esto con tu lógica para cargar datos reales)
            List<Conductor> conductores = new List<Conductor>()
            {
                new Conductor() { PesoMaximo = 1500, Placa = "ABC123", PesoVacio = 500 },
                new Conductor() { PesoMaximo = 1800, Placa = "XYZ789", PesoVacio = 600 }
            };

            conductoresDataGrid.ItemsSource = conductores; // Asigna la lista de conductores al DataGrid
        }
    }

    public class Conductor
    {
        public int PesoMaximo { get; set; }
        public string Placa { get; set; }
        public int PesoVacio { get; set; }
    }
}