
namespace Lentitud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRuta = new System.Windows.Forms.Button();
            this.lbArchivos = new System.Windows.Forms.ListBox();
            this.Ruta_Destino = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ruta_ori = new System.Windows.Forms.Label();
            this.Ruta_dest = new System.Windows.Forms.Label();
            this.Extraer = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.Datos_res = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(12, 12);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(272, 48);
            this.btnRuta.TabIndex = 0;
            this.btnRuta.Text = "Ruta de logs";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lbArchivos
            // 
            this.lbArchivos.FormattingEnabled = true;
            this.lbArchivos.ItemHeight = 20;
            this.lbArchivos.Location = new System.Drawing.Point(12, 130);
            this.lbArchivos.Name = "lbArchivos";
            this.lbArchivos.Size = new System.Drawing.Size(272, 444);
            this.lbArchivos.TabIndex = 1;
            this.lbArchivos.SelectedIndexChanged += new System.EventHandler(this.lbArchivos_SelectedIndexChanged);
            // 
            // Ruta_Destino
            // 
            this.Ruta_Destino.Location = new System.Drawing.Point(12, 66);
            this.Ruta_Destino.Name = "Ruta_Destino";
            this.Ruta_Destino.Size = new System.Drawing.Size(272, 48);
            this.Ruta_Destino.TabIndex = 3;
            this.Ruta_Destino.Text = "Ruta destino";
            this.Ruta_Destino.UseVisualStyleBackColor = true;
            this.Ruta_Destino.Click += new System.EventHandler(this.Ruta_Destino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destino: ";
            // 
            // Ruta_ori
            // 
            this.Ruta_ori.AutoSize = true;
            this.Ruta_ori.Location = new System.Drawing.Point(381, 26);
            this.Ruta_ori.Name = "Ruta_ori";
            this.Ruta_ori.Size = new System.Drawing.Size(64, 20);
            this.Ruta_ori.TabIndex = 9;
            this.Ruta_ori.Text = "Origen: ";
            // 
            // Ruta_dest
            // 
            this.Ruta_dest.AutoSize = true;
            this.Ruta_dest.Location = new System.Drawing.Point(381, 80);
            this.Ruta_dest.Name = "Ruta_dest";
            this.Ruta_dest.Size = new System.Drawing.Size(72, 20);
            this.Ruta_dest.TabIndex = 10;
            this.Ruta_dest.Text = "Destino: ";
            // 
            // Extraer
            // 
            this.Extraer.Location = new System.Drawing.Point(315, 150);
            this.Extraer.Name = "Extraer";
            this.Extraer.Size = new System.Drawing.Size(272, 48);
            this.Extraer.TabIndex = 11;
            this.Extraer.Text = "Extraer";
            this.Extraer.UseVisualStyleBackColor = true;
            this.Extraer.Click += new System.EventHandler(this.Extraer_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(348, 221);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(51, 20);
            this.lbresultado.TabIndex = 2;
            this.lbresultado.Text = "label1";
            // 
            // Datos_res
            // 
            this.Datos_res.FormattingEnabled = true;
            this.Datos_res.ItemHeight = 20;
            this.Datos_res.Location = new System.Drawing.Point(621, 130);
            this.Datos_res.Name = "Datos_res";
            this.Datos_res.Size = new System.Drawing.Size(272, 444);
            this.Datos_res.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 586);
            this.Controls.Add(this.Datos_res);
            this.Controls.Add(this.Extraer);
            this.Controls.Add(this.Ruta_dest);
            this.Controls.Add(this.Ruta_ori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ruta_Destino);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.lbArchivos);
            this.Controls.Add(this.btnRuta);
            this.Name = "Form1";
            this.Text = "Lentitud del centro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.ListBox lbArchivos;
        private System.Windows.Forms.Button Ruta_Destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Ruta_ori;
        private System.Windows.Forms.Label Ruta_dest;
        private System.Windows.Forms.Button Extraer;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.ListBox Datos_res;
    }
}

