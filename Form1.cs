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
        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

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
                    resultado_tiempo = texto_log.Substring(texto_log.IndexOf(tiempo_prod) + 20, 8);
                    string resultado = resultado_tipo + "    " + resultado_cantidad + "    " + resultado_tiempo;
                    Nombre_archivo =  @"\"+item.Name.Substring(11, 8) + ".txt";
                    lbresultado.Text = resultado;
                    dato_resultado = dato_resultado + resultado + "\n";
                    //MessageBox.Show(dato_resultado);
                    leer.Close();
                    //Extraer_archivo(RutaDirectorioDestino, dato_resultado, Nombre_archivo);
                }
                else
                {
                    MessageBox.Show("algunos archivos no eran logs de produccions y fueron ignorados.");
                }
            }
            Ruta_ori.Text = di.FullName;
        }

        private void Extraer_Click(object sender, EventArgs e)
        {
            if (RutaDirectorioDestino != null || dato_resultado != null || Nombre_archivo != null)
            {

                Extraer_archivo(RutaDirectorioDestino, dato_resultado, Nombre_archivo);
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
            //MessageBox.Show(fbd.SelectedPath);
            Ruta_dest.Text = fbd.SelectedPath;
        }

        private void lbArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
