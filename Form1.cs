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
            lbArchivos.Items.Clear();

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                RutaDirectorio = fbd.SelectedPath;
            }
            else {
                RutaDirectorio = "C:";
            }

            DirectoryInfo di = new DirectoryInfo(@RutaDirectorio);
            MessageBox.Show(di.ToString());
            foreach (var item in di.GetFiles())
            {
                lbArchivos.Items.Add(item.Name);
                //busca un archivo que no se le pasa, se debe seleccionar el archivo exsacto
                TextReader leer = new StreamReader(di.ToString() +@"\"+ item.Name);

                string texto_log = leer.ReadToEnd();
                string tipo_tarj = "RES - Job name:            ";
                string resultado_tipo;
                int resultado_cantidad;
                string resultado_tiempo;
                bool bien=false;
                if (texto_log.Contains(tipo_tarj))
                {
                    //MessageBox.Show("contiene");
                    //MessageBox.Show("la cadena esta en la posicion" + texto_log.IndexOf(tipo_tarj_MC));
                    MessageBox.Show("el plastico es " + texto_log.Substring(texto_log.IndexOf(tipo_tarj)+27, 2));
                    resultado_tipo = texto_log.Substring(texto_log.IndexOf(tipo_tarj) + 27, 2);
                    bien = true;
                }
                else
                {
                    MessageBox.Show("algo va mal");
                }
                if (bien == true)
                {
                    string cantidad_tarj = "RES - Cards to produce:    ";
                    //MessageBox.Show("la cadena esta " + texto_log.IndexOf(cantidad_tarj));
                    MessageBox.Show("la cantidad de tarjetas son" + texto_log.Substring(texto_log.IndexOf(cantidad_tarj) + 27, 3));
                    resultado_cantidad = Convert.ToInt32(texto_log.Substring(texto_log.IndexOf(cantidad_tarj) + 27, 3));
                    resultado_tipo = texto_log.Substring(texto_log.IndexOf(tipo_tarj) + 27, 2);
                    lbresultado.Text = resultado_tipo + "    " + resultado_cantidad;
                }
                else
                {
                }
                leer.Close();
                
            }
        }
    }
}
