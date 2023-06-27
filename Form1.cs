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
            }
        }
    }
}
