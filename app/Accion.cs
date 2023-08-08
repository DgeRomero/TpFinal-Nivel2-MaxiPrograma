using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using negocio;
using dominio;
using System.Windows.Forms;

namespace app
{
    class Accion
    {
        public void cargar(List<Articulo> listado, DataGridView lista, PictureBox img)
        {

            ListadoNegocio negocio = new ListadoNegocio();

            try
            {
                listado = negocio.listar();
                lista.DataSource = listado;
                ocultarColumna(lista);
                cargarImagen(img, listado[0].UrlImagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarArticulo(List<Articulo> listado, Articulo art, DataGridView detalle, PictureBox img)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listado = negocio.mostrar(art);
                detalle.DataSource = listado;
                cargarImagen(img, art.UrlImagen);
                ocultarColumna(detalle);
                detalle.Columns["Descripcion"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(PictureBox img, string imagen)
        {
            try
            {
                img.Load(imagen);
            }
            catch (Exception)
            {
                img.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        public void ocultarColumna(DataGridView listado)
        {
            listado.Columns["UrlImagen"].Visible = false;
            listado.Columns["Id"].Visible = false;
            
        }

       public void eliminar(DataGridView listado, bool logico = false)
        {
            ListadoNegocio negocio = new ListadoNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea Eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    seleccionado = (Articulo)listado.CurrentRow.DataBoundItem;
                    
                    if (logico)
                     negocio.eliminar(seleccionado.Id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool validarFiltro(ComboBox campo, ComboBox criterio, TextBox filtro)
        {
            if (campo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione campo");
                return true;
            }
            if (criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione criterio");
                return true;
            }
            if (campo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(filtro.Text))
                {
                    MessageBox.Show("Debe cargar filtro para numericos");
                    return true;
                }
                if (!(soloNumeros(filtro.Text)))
                {
                    MessageBox.Show("Sólo numero para filtrar por campo numérico");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
    }

        
}
