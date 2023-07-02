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

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string RutaDirectorio = null;

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
                TextReader leer = new StreamReader(di.ToString() + @"\" + item.Name);
                string texto_log = leer.ReadToEnd();
                string tipo_tarj = "RES - Job name:            ";
                string resultado_tipo;
                int resultado_cantidad;
                string resultado_tiempo;
                string tiempo_prod = "| RES - Time Run  : ";
                //bool bien = false;
                resultado_tipo = texto_log.Substring(texto_log.IndexOf(tipo_tarj) + 27, 2);
                string cantidad_tarj = "RES - Cards to produce:    ";
                resultado_cantidad = Convert.ToInt32(texto_log.Substring(texto_log.IndexOf(cantidad_tarj) + 27, 3));
                resultado_tiempo = texto_log.Substring(texto_log.IndexOf(tiempo_prod) + 20, 8);
                string resultado = resultado_tipo + "    " + resultado_cantidad + "    " + resultado_tiempo;
                lbresultado.Text = resultado;
                leer.Close();
            }
        }

        private void Extraer_Click(object sender, EventArgs e)
        {

        }
        private void Extraer_archivo(string Ruta,string datos,string nombre_archivo)
        {

        }

        private void Ruta_Destino_Click(object sender, EventArgs e)
        {
            string RutaDirectorio = null;

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

            MessageBox.Show(fbd.SelectedPath);
        }
    }
}
