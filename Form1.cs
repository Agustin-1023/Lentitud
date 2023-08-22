using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lentitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string RutaDirectorio = null;
        string dato_resultado;
        string Nombre_archivo;
        string RutaDirectorioDestino = "C:";
        int inicioFecha;
        int largofecha;
        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            bool archivosDistintos = false;
            lbArchivos.Items.Clear();
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RutaDirectorio = fbd.SelectedPath;
            }
            else
            {
                RutaDirectorio = "C:";
                MessageBox.Show("Al no determinar la ruta se dejara en: " + RutaDirectorio);
            }

            DirectoryInfo di = new DirectoryInfo(@RutaDirectorio);
            
            foreach (var item in di.GetFiles())
            {
                lbArchivos.Items.Add(item.Name);
                //busca un archivo que no se le pasa, se debe seleccionar el archivo exsacto
                string nombre = "Production";
                TextReader leer = new StreamReader(di.ToString() + @"\" + item.Name);                
                if (item.Name.Substring(0,10) == nombre){
                    string texto_log = leer.ReadToEnd();
                    string tipo_tarj = "RES - Job name:            ";
                    string resultado_tipo;
                    int resultado_cantidad;
                    string resultado_tiempo;
                    string tiempo_prod = "| RES - Time Run  : ";
                    resultado_tipo = texto_log.Substring(texto_log.IndexOf(tipo_tarj) + 27, 2);
                    string cantidad_tarj = "RES - Cards to produce:    ";
                    resultado_cantidad = Convert.ToInt32(texto_log.Substring(texto_log.IndexOf(cantidad_tarj) + 27, 3));
                    resultado_tiempo = texto_log.Substring(texto_log.IndexOf(tiempo_prod) + 20, largofecha);
                    string resultado = resultado_tipo + "    " + resultado_cantidad + "    " + resultado_tiempo;
                    Nombre_archivo =  @"\"+item.Name.Substring(inicioFecha, largofecha) + ".txt";
                    lbresultado.Text = resultado;
                    Datos_res.Items.Add(resultado);
                    leer.Close();
                }
                else
                {
                    archivosDistintos = true;
                }
            }
            if (archivosDistintos == true)
            {
                MessageBox.Show("algunos archivos no eran logs de produccions y fueron ignorados.");
                archivosDistintos = false;
            }
            Ruta_ori.Text = di.FullName;
        }

        private void Extraer_Click(object sender, EventArgs e)
        {
            if (RutaDirectorioDestino != null || dato_resultado != null || Nombre_archivo != null)
            {
                string datos_lb = string.Join(Environment.NewLine, Datos_res.Items.OfType<object>());

                MessageBox.Show(datos_lb);
                Extraer_archivo(RutaDirectorioDestino, datos_lb, Nombre_archivo);
            }
            else
            {
                MessageBox.Show("falta asignar uno de estos datos");
            }
        }
        public void Extraer_archivo(string Ruta,string datos,string nombre_archivo)
        {
            try
            {
                if (File.Exists(RutaDirectorio + Nombre_archivo))
                {

                    StreamWriter agrega = new StreamWriter(RutaDirectorioDestino + nombre_archivo);
                    agrega.WriteLine(datos);
                    agrega.Close();
                }
                else
                {
                    MessageBox.Show("Ruta" + Ruta + "datos" + datos + "nombre " + nombre_archivo);
                    TextWriter escribe = new StreamWriter(RutaDirectorioDestino + nombre_archivo);
                    escribe.WriteLine(datos);
                    escribe.Close();
                }
                if (Ruta != null || datos != null || nombre_archivo != null)
                {

                }
                else
                {
                    MessageBox.Show("No se pudo extraer.");
                }
            }
            catch (Exception)
            {
                StreamWriter agrega = new StreamWriter(RutaDirectorioDestino + nombre_archivo);
                agrega.WriteLine(datos);
                agrega.Close();
                throw;
            }

        }

        private void Ruta_Destino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RutaDirectorioDestino = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show("Al no asignar la ruta se dejara en: " + RutaDirectorioDestino);
            }
            Ruta_dest.Text = fbd.SelectedPath;
        }

        private void lbArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnodenar_Click(object sender, EventArgs e)
        {
            if(RutaDirectorio == null)
            {
                MessageBox.Show("no se indico la ruta a ordenar");
            }
            else
            {
                Ordenador();
            };
        }
        private void Ordenador()
        {
            DirectoryInfo di = new DirectoryInfo(@RutaDirectorio);
            List<String> nombres_archivos = new List<string>();
            foreach(var item in di.GetFiles())
            {

                if (nombres_archivos.Contains(item.Name.Substring(inicioFecha, largofecha)))
                {
                }
                else
                {
                    nombres_archivos.Add(item.Name.Substring(inicioFecha, largofecha));
                }

            }
            string diToString = di.ToString();
            if(largofecha == 0 || inicioFecha == 0)
            {
                MessageBox.Show("se necesitan valores para la fecha");
            }
            else
            {
                foreach (string nombres_carpetas in nombres_archivos)
                {
                    Directory.CreateDirectory(RutaDirectorioDestino + @"\" + nombres_carpetas);
                    if (RutaDirectorioDestino == "C:")
                    {
                        MessageBox.Show("se crearan las carpetas por defecto en la unidad C:");
                    }
                }
                MessageBox.Show("Carpetas creadas");
                foreach (var item in di.GetFiles())
                {
                    try
                    {
                        File.Move(RutaDirectorio + @"\" + item.Name, RutaDirectorioDestino + @"\" + item.Name.Substring(inicioFecha, largofecha) + @"\" + item.Name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("no se pudo mover el archivo");
                        throw;
                    }
                }
            }

        }

        private void validarFecha_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@RutaDirectorio);
            foreach(var item in di.GetFiles())
            {
                fecha_validar.Text = item.Name.Substring(inicioFecha, largofecha);
                inicioFecha = Convert.ToInt32(numericfechainicio.Value);
                largofecha = Convert.ToInt32(numericlargofecha.Value);
            }
        }
    }
}
