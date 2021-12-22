using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajeria.Administradores;
using Mensajeria.Modelos;

namespace Mensajeria
{
    public partial class Form1 : Form
    {
        AdminContactos adminContactos;
        int idContacto;
        public Form1()
        {
            InitializeComponent();
            //Agregue un método o un eventHandler que se encarga del doble click, pude llegar a esta solución gracias a este link: https://stackoverflow.com/questions/13486245/winforms-how-to-call-a-double-click-event-on-a-button
            lsViewContactos.DoubleClick += new EventHandler(lsViewContactos_DoubleClick);
            adminContactos = new AdminContactos();
            idContacto = 0;
            ActualizarLsView(lsViewContactos);
        }
        private void lsViewContactos_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem contacto = lsViewContactos.SelectedItems[0];

            GuardarIdContacto(int.Parse(contacto.Tag.ToString()));
            PonerModoVisualizarContacto(ObtenerIdContacto());
        }
        //Panel para visualizar y mantener los contactos.
        private void bttnNuevoContacto_Click(object sender, EventArgs e)
        {
            PonerModoCrearContacto();
        }

        private void bttnBorrarContacto_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> contactos = lsViewContactos.SelectedItems.Cast<ListViewItem>().ToList();

            if (contactos.Count == 0)
            {
                MessageBox.Show("No selecciono contactos.");
                return;
            }

            foreach (ListViewItem contacto in contactos)
            {
                lsViewContactos.Items.Remove(contacto);
                adminContactos.Borrar(int.Parse(contacto.Tag.ToString()));
            }
        }

        private void bttnModificarContacto_Click(object sender, EventArgs e)
        {
            //Utilice el método Cast<>() para poder manipular los elementos del listView.
            List<ListViewItem> contactos = lsViewContactos.SelectedItems.Cast<ListViewItem>().ToList();

            if (contactos.Count == 1)
            {
                GuardarIdContacto(int.Parse(contactos[0].Tag.ToString()));
                PonerModoModContacto(ObtenerIdContacto());
            }
            else if (contactos.Count > 1)
            {
                MessageBox.Show("Solo puede modificar un contacto a la vez.");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un contacto.");
            }
        }

        private void txtBuscarContacto_TextChanged(object sender, EventArgs e)
        {

            //Criterio de búsqueda. Buscará aquellos contactos que empiezen por la string introducida.
            string busqueda = txtBuscarContacto.Text.Trim().ToLower();

            if (busqueda.Equals(""))
            {
                //Si no se introduce nada entonces se mantiene el listView igual.
                ActualizarLsView(lsViewContactos);
                return;
            }

            List<Contacto> contactos = adminContactos.BuscarPorNombre(busqueda);
            if (contactos.Count >= 1)
            {
                //Se carga el listView con una lista de contactos que cumplen el criterio de búsqueda.
                ActualizarLsView(lsViewContactos, contactos);
            }
            else
            {
                //Si no cumple con el criterio de búsqueda entonces el listView se mantendra en blanco.
                lsViewContactos.Items.Clear();
            }
        }

        //Panel para crear y modificar los contactos.

        private void bttnModContacto_Click(object sender, EventArgs e)
        {
            if (EstaSiendoCreado())
            {
                CrearConctacto();
            }
            else if (EstaSiendoModificado())
            {
                ModificarContacto();
            }
        }

        private void bttnCnlModContacto_Click(object sender, EventArgs e)
        {
            pnlContactos.BringToFront();
            CancelarOperacionContacto();
        }


        //Métodos Importantes.
        private void PonerModoCrearContacto()
        {
            lblModContacto.Text = "Crear Contacto";
            bttnModContacto.Text = "Crear";
            bttnModContacto.Tag = 1;
            picBoxFoto.ImageLocation = adminContactos.ObtenerImagenPorDefecto();
            bttnSubirFoto.Text = "Subir Foto";
            bttnSubirFoto.Tag = 1;
            pnlModContacto.BringToFront();
        }

        private void PonerModoModContacto(int id)
        {
            lblModContacto.Text = "Modificar Contacto";
            bttnModContacto.Text = "Modificar";
            bttnModContacto.Tag = 2;
            Contacto contacto = adminContactos.Buscar(id);
            txtNombreContacto.Text = contacto.Nombre;
            txtApellidoContacto.Text = contacto.Apellido;
            txtTelefonoContacto.Text = contacto.Telefono.ToString();
            txtCorreoContacto.Text = contacto.Correo;
            picBoxFoto.ImageLocation = contacto.UbicacionImagen;
            if (adminContactos.EsImagenPorDefecto(contacto.UbicacionImagen))
            {
                bttnSubirFoto.Text = "Subir Foto";
                bttnSubirFoto.Tag = 1;
            }
            else
            {

                bttnSubirFoto.Text = "Quitar Foto";
                bttnSubirFoto.Tag = 2;
            }
            pnlModContacto.BringToFront();
        }

        private void PonerModoVisualizarContacto(int id)
        {
            lblModContacto.Text = "Visualizar Contacto";
            bttnRegresarVisualizar.Visible = true;
            bttnRegresarVisualizar.Location = new Point(243, 285);
            bttnModContacto.Visible = false;
            bttnCnlModContacto.Visible = false;
            bttnModContacto.Tag = 2;
            Contacto contacto = adminContactos.Buscar(id);
            txtNombreContacto.Text = contacto.Nombre;
            txtNombreContacto.Enabled = false;
            txtApellidoContacto.Text = contacto.Apellido;
            txtApellidoContacto.Enabled = false;
            txtTelefonoContacto.Text = contacto.Telefono.ToString();
            txtTelefonoContacto.Enabled = false;
            txtCorreoContacto.Text = contacto.Correo;
            txtCorreoContacto.Enabled = false;
            picBoxFoto.ImageLocation = contacto.UbicacionImagen;
            bttnSubirFoto.Enabled = false;
            pnlModContacto.BringToFront();
        }
        private void LimpiarPanelModContacto()
        {
            txtNombreContacto.Text = "";
            txtApellidoContacto.Text = "";
            txtTelefonoContacto.Text = "";
            txtCorreoContacto.Text = "";
            picBoxFoto.ImageLocation = "";
        }
        private void CancelarOperacionContacto()
        {
            LimpiarPanelModContacto();
        }

        private void CrearConctacto()
        {
            try
            {
                string nombre = txtNombreContacto.Text;
                string apellido = txtApellidoContacto.Text;
                int telefono = int.Parse(txtTelefonoContacto.Text);
                string correo = txtCorreoContacto.Text;
                string ubicacionImagen = picBoxFoto.ImageLocation;

                adminContactos.Crear(nombre, apellido, telefono, correo, ubicacionImagen);
                ActualizarLsView(lsViewContactos);
                LimpiarPanelModContacto();
                pnlContactos.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarContacto()
        {
            int id = ObtenerIdContacto();
            string nombre = txtNombreContacto.Text;
            string apellido = txtApellidoContacto.Text;
            int telefono = int.Parse(txtTelefonoContacto.Text);
            string correo = txtCorreoContacto.Text;
            string ubicacionImagen = picBoxFoto.ImageLocation;

            adminContactos.Modificar(id, nombre, apellido, telefono, correo, ubicacionImagen);
            LimpiarPanelModContacto();
            pnlContactos.BringToFront();
            ActualizarLsView(lsViewContactos);
        }

        private void ActualizarLsView(ListView listView, List<Contacto> contactos = null)
        {

            ListView lsViewTemp = listView;
            //Se borran los items para volver ser cargados de la estrutura de datos.
            lsViewTemp.Items.Clear();

            if (contactos == null)
            {
                contactos = adminContactos.ObtenerContactos();
            }
            //Se añade cada producto en productos al listView.
            foreach (Contacto contacto in contactos)
            {
                ListViewItem item = new ListViewItem(contacto.NombreCompleto);
                item.Tag = contacto.ID;
                item.ImageIndex = 2;
                item.SubItems.Add(contacto.Telefono.ToString());
                item.SubItems.Add(contacto.Correo);
                lsViewTemp.Items.Add(item);
            }
        }

        //Métodos Utilitarios.
        private bool EstaSiendoCreado()
        {
            return int.Parse(bttnModContacto.Tag.ToString()) == 1;
        }

        private bool EstaSiendoModificado()
        {
            return int.Parse(bttnModContacto.Tag.ToString()) == 2;
        }

        private void GuardarIdContacto(int id)
        {
            idContacto = id;
        }
        private int ObtenerIdContacto()
        {
            return idContacto;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void lsViewContactos_Click(object sender, EventArgs e)
        {
 
            ListViewItem listViewItem = lsViewContactos.SelectedItems[0];


        }
        private void SubirFoto()
        {
            string pathImagen = "";
            try
            {
                OpenFileDialog archivoDialogo = new OpenFileDialog();
                archivoDialogo.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                DialogResult resultado = archivoDialogo.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pathImagen = archivoDialogo.FileName;

                    picBoxFoto.ImageLocation = pathImagen;

                    bttnSubirFoto.Text = "Quitar Foto";
                    bttnSubirFoto.Tag = 2;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha salido mal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitarFoto()
        {
            picBoxFoto.ImageLocation = adminContactos.ObtenerImagenPorDefecto();
            bttnSubirFoto.Text = "Subir Foto";
            bttnSubirFoto.Tag = 1;
        }
        private void bttnSubirFoto_Click(object sender, EventArgs e)
        {
            if (int.Parse(bttnSubirFoto.Tag.ToString()) == 1)
            {
                SubirFoto();
            }
            else
            {
                QuitarFoto();
            }
        }

        private void bttnRegresarVisualizar_Click(object sender, EventArgs e)
        {
            bttnRegresarVisualizar.Visible = false;
            bttnModContacto.Visible = true;
            bttnCnlModContacto.Visible = true;
            txtNombreContacto.Enabled = true;
            txtApellidoContacto.Enabled = true;
            txtTelefonoContacto.Enabled = true;
            txtCorreoContacto.Enabled = true;
            bttnSubirFoto.Enabled = true;
            LimpiarPanelModContacto();
            pnlContactos.BringToFront();
        }
    }
}
