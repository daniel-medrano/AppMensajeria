using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

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
        public static string ImagenPorDefecto { get { return "Imagenes\\default.jpg"; } }

        public string UbicacionImagen { get; set; }

        //public Clase Imagen {get; set;} OPCIONAL

        public Contacto(int id, string nombre, string apellido, int telefono, string correo, string ubicacionImagen)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            UbicacionImagen = GuardarImagen(ubicacionImagen);
        }

        public Contacto() { }

        public bool Modificar(string nombre, string apellido, int telefono, string correo, string ubicacionImagen)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            BorrarImagen(UbicacionImagen);
            UbicacionImagen = GuardarImagen(ubicacionImagen);
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
                    else
                    {
                        BorrarImagen(partes[5]);
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
            return ID + "#" + Nombre + "#" + Apellido + "#" + Telefono + "#" + Correo + "#" + UbicacionImagen;
        }

        public string GuardarImagen(string path)
        {
            string pathNuevo = "Imagenes\\" + ID + path.Substring(path.Length - 4);
            if (path != pathNuevo)
            {
                File.Copy(path, pathNuevo);
                return pathNuevo;
            }
            return path;
        }

        public void BorrarImagen(string path)
        {
            File.Delete(path);
        }
        


    }
}
