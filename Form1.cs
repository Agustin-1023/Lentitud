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

            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                RutaDirectorio = fbd.SelectedPath;
            }

            DirectoryInfo di = new DirectoryInfo(@RutaDirectorio);

            foreach (var item in di.GetFiles())
            {
                lbArchivos.Items.Add(item.Name);
                //busca un archivo que no se le pasa, se debe seleccionar el archivo exsacto
                TextReader leer = new StreamReader(@"C:\Origen\" + item.Name);

                string texto_log = leer.ReadToEnd();
                string tipo_tarj = "| RES - Job name:            ";
                if (texto_log.Contains(tipo_tarj))
                {
                    MessageBox.Show("contiene");
                }
                else
                {
                    MessageBox.Show("algo va mal");
                }




                leer.Close();
                
            }
        }
    }
}
