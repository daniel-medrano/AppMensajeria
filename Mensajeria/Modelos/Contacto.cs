using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mensajeria.Modelos
{
    class Contacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string NombreCompleto { get { return Nombre + " " + Apellido; } }
        public static string Archivo { get { return "Contactos.txt"; } } 

        //public Clase Imagen {get; set;} OPCIONAL

        public Contacto(int id, string nombre, string apellido, int telefono, string correo)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }

        public Contacto() { }

        public bool Modificar(string nombre, string apellido, int telefono, string correo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            return Remplazar();
        }

        public bool Borrar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText(Archivo);
                escribir = File.AppendText("Temp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) != ID)
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Temp.txt", Archivo, true);
                File.Delete("Temp.txt");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                    leer.Close();
                if (escribir != null)
                    escribir.Close();
            }
        }

        public bool Insertar()
        {
            StreamWriter escribir = null;

            try
            {
                escribir = File.AppendText(Archivo);
                escribir.WriteLine(ObtenerContacto());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (escribir != null)
                {
                    escribir.Close();
                }
            }
        }

        public bool Remplazar()
        {
            StreamReader leer = null;
            StreamWriter escribir = null;

            try
            {
                leer = File.OpenText(Archivo);
                escribir = File.AppendText("Temp.txt");

                string linea = leer.ReadLine();

                while (linea != null)
                {
                    string[] partes = linea.Split('#');

                    if (int.Parse(partes[0]) == ID)
                    {
                        escribir.WriteLine(ObtenerContacto());
                    }
                    else
                    {
                        escribir.WriteLine(linea);
                    }
                    linea = leer.ReadLine();
                }
                leer.Close();
                escribir.Close();
                File.Copy("Temp.txt", Archivo, true);
                File.Delete("Temp.txt");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (leer != null)
                    leer.Close();
                if (escribir != null)
                    escribir.Close();
            }
        }
        public string ObtenerContacto()
        {
            return ID + "#" + Nombre + "#" + Apellido + "#" + Telefono + "#" + Correo;
        }

    }
}
