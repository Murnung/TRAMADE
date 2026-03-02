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
using TRAMADE.FormulariosMenú;

namespace TRAMADE.FormulariosMenú
{
    public partial class frmVistaMenu : Form
    {

        private readonly ResponsiveFormManager _responsive;
        private clsVistaGeneral _popup;
        public frmVistaMenu()
        {
            InitializeComponent();
            _responsive = new ResponsiveFormManager(this);
            new clsClientesPanel(lblTotalClientes, pnlBarraFondo, pnlBarraActivos).Cargar();
        }

        private void frmVistaMenu_Load(object sender, EventArgs e)
        {
            _responsive.Initialize();
            _popup = new clsVistaGeneral(this);

            new clsGraficoInventario(chrInventario).Cargar();
            new clsGraficoTendencia(chrTendencia).Cargar();
            new clsUltimasCompras(dgvCompras).Cargar();
            new clsUltimasVentas(dgvVentas).Cargar();
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

        private void frmVistaMenu_SizeChanged(object sender, EventArgs e)
        {
            _responsive.AdjustLayout();
        }
    }
}
