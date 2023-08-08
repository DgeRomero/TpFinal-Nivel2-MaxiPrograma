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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listadoArticulos;
        private Articulo seleccionado;
        private Accion tarea = new Accion();
        private ListadoNegocio negocio = new ListadoNegocio();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditar agregar = new frmEditar();
            agregar.ShowDialog();
            tarea.cargar(listadoArticulos, dvgListado, pbxImagenListado);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dvgListado.CurrentRow.DataBoundItem;
            frmEditar modificar = new frmEditar(seleccionado);
            modificar.ShowDialog();
            tarea.cargar(listadoArticulos, dvgListado, pbxImagenListado);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dvgListado.CurrentRow.DataBoundItem;
            frmDetalles detalle = new frmDetalles(seleccionado);
            detalle.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            tarea.cargar(listadoArticulos, dvgListado, pbxImagenListado);
            cboAtributos.Items.Add("Nombre");
            cboAtributos.Items.Add("Precio");
            cboAtributos.Items.Add("Marca");
            cboAtributos.Items.Add("Categoría");
            cboAtributos.Items.Add("Código");
            dvgListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgListado.EditMode = DataGridViewEditMode.EditProgrammatically;
            dvgListado.MultiSelect = false;
        }

        private void dvgListado_SelectionChanged(object sender, EventArgs e)
        {
            if(dvgListado.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dvgListado.CurrentRow.DataBoundItem;
                tarea.cargarImagen(pbxImagenListado, seleccionado.UrlImagen);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tarea.eliminar(dvgListado, true);
            tarea.cargar(listadoArticulos, dvgListado, pbxImagenListado);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {   
            try
            {

                if (txtFiltrar.Text != "")
                {
                    if (tarea.validarFiltro(cboAtributos, cboCriterio, txtFiltrar))
                    {
                        return;
                    }
                }


                string campo = cboAtributos.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltrar.Text;

                if (filtro != "")
                {
                    dvgListado.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
                else
                {
                    tarea.cargar(listadoArticulos, dvgListado, pbxImagenListado);
                }
                //listadoArticulos = negocio.listar();
                //dvgListado.DataSource = listadoArticulos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }

        private void cboAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboAtributos.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
