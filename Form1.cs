using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formularios_Login__Menú;

namespace TRAMADE
{
    public partial class Form1 : Form
    {
        // El campo debe estar aquí, no dentro del Load
        private clsVistaGeneral _popup;

        public Form1()
        {
            InitializeComponent();
            // Moví la carga de los paneles aquí, ya que el constructor debe llamarse Form1
            new clsClientesPanel(lblTotalClientes, pnlBarraFondo, pnlBarraActivos).Cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            _popup = new clsVistaGeneral(this);

            new clsGraficoInventario(chrInventario).Cargar();
            new clsGraficoTendencia(chrTendencia).Cargar();
            new clsUltimasCompras(dgvCompras).Cargar();
            new clsUltimasVentas(dgvVentas).Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Espacio para lógica de cambio de tamaño si es necesario
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            _popup.MostrarProductos(btnProductos);
        }

        private void btnVentasRealizadas_Click(object sender, EventArgs e)
        {
            _popup.MostrarVentas(btnVentasRealizadas);
        }

        private void btnComprasRealizadas_Click(object sender, EventArgs e)
        {
            _popup.MostrarCompras(btnComprasRealizadas);
        }

        private void btnProductosAgotados_Click(object sender, EventArgs e)
        {
            _popup.MostrarAgotados(btnProductosAgotados);
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}