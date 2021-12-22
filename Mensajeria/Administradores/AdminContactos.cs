using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mensajeria.Modelos;

namespace Mensajeria.Administradores
{
    class AdminContactos
    {

        private List<Contacto> contactos;
        private AdminIdentificaciones adminIDs;
        public AdminContactos()
        {
            contactos = new List<Contacto>();
            adminIDs = new AdminIdentificaciones();
            Cargar();

        }
        //Crea un nuevo producto y lo agrega a productos.
        public bool Crear(string nombre, string apellido, int telefono, string correo, string ubicacionImagen)
        {
            int id = adminIDs.ObtenerIDDisponible();
            Contacto nuevo = new Contacto(id, nombre, apellido, telefono, correo, ubicacionImagen);
            nuevo.Insertar();
            contactos.Add(nuevo);
            return true;
        }

        public bool Borrar(int id)
        {
            Contacto contacto = Buscar(id);
            if (contacto != null)
            {
                contacto.Borrar();
                contactos.Remove(contacto);
                adminIDs.DevolverIDParaReutilizar(id);
                return true;

            }
            return false;
        }

        public bool Modificar(int id, string nombre, string apellido, int telefono, string correo, string ubicacionImagen)
        {
            Contacto contacto = Buscar(id);
            if (contacto != null)
            {
                return contacto.Modificar(nombre, apellido, telefono, correo, ubicacionImagen);
            }
            return false;
        }

        public Contacto Buscar(int id)
        {
            foreach (Contacto contacto in contactos)
            {
                if (contacto.ID == id)
                {
                    return contacto;
                }
            }
            return null;
        }

        public List<Contacto> BuscarPorNombre(string texto)
        {
            //Cantidad de caracteres del texto
            int cantidadChars = texto.Length;
            //Productos que cumplan con el criterio seran devueltos en una lista.
            List<Contacto> busquedas = new List<Contacto>();

            foreach (Contacto contacto in contactos)
            {
                if (contacto.Nombre.Length >= cantidadChars)
                {
                    string nombre = contacto.Nombre.Substring(0, cantidadChars).ToLower();

                    //Compara una porción del nombre si es necesario con el texto.
                    if (nombre.Equals(texto))
                    {
                        busquedas.Add(contacto);
                    }
                }
            }
            return busquedas;
        }

        private bool CargarContacto(int id, string nombre, string apellido, int telefono, string correo, string ubicacionImagen)
        {
            Contacto contacto = Buscar(id);

            if (contacto == null)
            {
                contactos.Add(new Contacto(id, nombre, apellido, telefono, correo, ubicacionImagen));
                return true;

            }
            return false;
        }

        public bool Cargar()
        {
            StreamReader leer = null;
            try
            {
                leer = File.OpenText(Contacto.Archivo);

                string linea = leer.ReadLine();
                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    CargarContacto(int.Parse(partes[0]), partes[1], partes[2], int.Parse(partes[3]), partes[4], partes[5]);

                    linea = leer.ReadLine();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                {
                    leer.Close();
                }
            }
        }

        public List<Contacto> ObtenerContactos()
        {
            return contactos;
        }

        public string ObtenerImagenPorDefecto()
        {
            return Contacto.ImagenPorDefecto;
        }
    }
}
