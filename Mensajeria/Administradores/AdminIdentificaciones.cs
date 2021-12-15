using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mensajeria.Administradores
{
    //Clase para que los IDs sean manejados en el background y que el usuario no tenga que preocuparse al respecto.
    class AdminIdentificaciones
    {
        //Se guarda el último ID creado.
        private int UltimoID { get; set; }
        private string Archivo { get; set; }

        //
        public AdminIdentificaciones()
        {
            Archivo = "Identificaciones.txt";
            UltimoID = CargarUltimoID();
        }

        public int ObtenerIDDisponible()
        {
            if (ExisteIDReutilizable())
            {
                return ObtenerIDReutilizable();

            }
            else
            {
                return ObtenerSiguienteID();
            }
        }

        public void DevolverIDParaReutilizar(int id)
        {
            Insertar(id);
        }

        private int CargarUltimoID()
        {
            int ultimoID = Buscar();
            if (ultimoID == -1)
            {
                return 0;
            }
            else
            {
                return ultimoID;
            }
        }

        private bool ExisteIDReutilizable()
        {
            return Buscar() >= 1;
        }

        private int ObtenerIDReutilizable()
        {
            int ID = Buscar();
            Borrar(ID);
            return ID;
        }
        private int ObtenerSiguienteID()
        {
            UltimoID++;
            if (UltimoID == 1)
            {
                Insertar(UltimoID);
            }
            else
            {
                RemplazarUltimoID();
            }
            return UltimoID;
        }


        private bool Insertar(int id)
        {
            StreamWriter escribir = null;

            try
            {
                escribir = File.AppendText(Archivo);
                escribir.WriteLine(id);
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

        private bool Borrar(int id)
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
                    if (int.Parse(linea) != id)
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
        //TODO <----------------------------------------------------------------------- SI EL ARCHIVO NO EXISTE, HAY QUE CREARLO
        private int Buscar()
        {
            StreamReader leer = null;

            try
            {
                leer = File.OpenText(Archivo);

                string linea = leer.ReadLine();
                if (linea == null)
                {
                    return -1;
                }

                linea = leer.ReadLine();
                if (linea != null)
                {
                    return int.Parse(linea);
                }
                else
                {
                    return -2;
                }
            }
            catch (Exception ex)
            {
                return -3;
            }
            finally
            {
                if (leer != null)
                    leer.Close();
            }
        }

        private bool RemplazarUltimoID()
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
                    if (int.Parse(linea) == (UltimoID - 1))
                    {
                        escribir.WriteLine(UltimoID);
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

    }
}
