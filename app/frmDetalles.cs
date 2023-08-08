using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace app
{
    public partial class frmDetalles : Form
    {
        private Articulo articulo;
        private List<Articulo> listado;
        public frmDetalles()
        {
            InitializeComponent();
        }
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Accion cargar = new Accion();
            cargar.cargarArticulo(listado, articulo, dvgDetalles, pbxDetalles);
            tbxDescripcion.Text = articulo.Descripcion;
           
        }

    }
}
