
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
            this.lbresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(12, 12);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(272, 48);
            this.btnRuta.TabIndex = 0;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // lbArchivos
            // 
            this.lbArchivos.FormattingEnabled = true;
            this.lbArchivos.ItemHeight = 20;
            this.lbArchivos.Location = new System.Drawing.Point(12, 210);
            this.lbArchivos.Name = "lbArchivos";
            this.lbArchivos.Size = new System.Drawing.Size(272, 364);
            this.lbArchivos.TabIndex = 1;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(427, 210);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(51, 20);
            this.lbresultado.TabIndex = 2;
            this.lbresultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 586);
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
        private System.Windows.Forms.Label lbresultado;
    }
}

