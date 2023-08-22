
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
            this.btnodenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericfechainicio = new System.Windows.Forms.NumericUpDown();
            this.numericlargofecha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.validarFecha = new System.Windows.Forms.Button();
            this.fecha_validar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericfechainicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericlargofecha)).BeginInit();
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
            this.Extraer.Text = "Analizar Produccion";
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
            // btnodenar
            // 
            this.btnodenar.Location = new System.Drawing.Point(315, 505);
            this.btnodenar.Name = "btnodenar";
            this.btnodenar.Size = new System.Drawing.Size(272, 48);
            this.btnodenar.TabIndex = 13;
            this.btnodenar.Text = "Ordenar";
            this.btnodenar.UseVisualStyleBackColor = true;
            this.btnodenar.Click += new System.EventHandler(this.btnodenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "inicio de fecha ";
            // 
            // numericfechainicio
            // 
            this.numericfechainicio.Location = new System.Drawing.Point(467, 270);
            this.numericfechainicio.Name = "numericfechainicio";
            this.numericfechainicio.Size = new System.Drawing.Size(120, 26);
            this.numericfechainicio.TabIndex = 15;
            // 
            // numericlargofecha
            // 
            this.numericlargofecha.Location = new System.Drawing.Point(513, 313);
            this.numericlargofecha.Name = "numericlargofecha";
            this.numericlargofecha.Size = new System.Drawing.Size(74, 26);
            this.numericlargofecha.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "cantidad de caracteres";
            // 
            // validarFecha
            // 
            this.validarFecha.Location = new System.Drawing.Point(504, 397);
            this.validarFecha.Name = "validarFecha";
            this.validarFecha.Size = new System.Drawing.Size(83, 29);
            this.validarFecha.TabIndex = 18;
            this.validarFecha.Text = "Validar";
            this.validarFecha.UseVisualStyleBackColor = true;
            this.validarFecha.Click += new System.EventHandler(this.validarFecha_Click);
            // 
            // fecha_validar
            // 
            this.fecha_validar.AutoSize = true;
            this.fecha_validar.Location = new System.Drawing.Point(311, 406);
            this.fecha_validar.Name = "fecha_validar";
            this.fecha_validar.Size = new System.Drawing.Size(49, 20);
            this.fecha_validar.TabIndex = 19;
            this.fecha_validar.Text = "fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "corte para carpetas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_validar);
            this.Controls.Add(this.validarFecha);
            this.Controls.Add(this.numericlargofecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericfechainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnodenar);
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
            this.Text = "analisis de logs";
            ((System.ComponentModel.ISupportInitialize)(this.numericfechainicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericlargofecha)).EndInit();
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
        private System.Windows.Forms.Button btnodenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericfechainicio;
        private System.Windows.Forms.NumericUpDown numericlargofecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validarFecha;
        private System.Windows.Forms.Label fecha_validar;
        private System.Windows.Forms.Label label5;
    }
}

