
namespace MercamaxApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPuntos = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnBodega = new System.Windows.Forms.Button();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.txtGondola = new System.Windows.Forms.TextBox();
            this.btnGondola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPuntos
            // 
            this.btnPuntos.Location = new System.Drawing.Point(12, 47);
            this.btnPuntos.Name = "btnPuntos";
            this.btnPuntos.Size = new System.Drawing.Size(101, 23);
            this.btnPuntos.TabIndex = 0;
            this.btnPuntos.Text = "Verificar puntos";
            this.btnPuntos.UseVisualStyleBackColor = true;
            this.btnPuntos.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(12, 87);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(101, 23);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Listar productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnBodega
            // 
            this.btnBodega.Location = new System.Drawing.Point(12, 126);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(101, 23);
            this.btnBodega.TabIndex = 3;
            this.btnBodega.Text = "Ver en bodega";
            this.btnBodega.UseVisualStyleBackColor = true;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // txtBodega
            // 
            this.txtBodega.Location = new System.Drawing.Point(119, 127);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(100, 20);
            this.txtBodega.TabIndex = 4;
            // 
            // txtGondola
            // 
            this.txtGondola.Location = new System.Drawing.Point(119, 166);
            this.txtGondola.Name = "txtGondola";
            this.txtGondola.Size = new System.Drawing.Size(100, 20);
            this.txtGondola.TabIndex = 5;
            // 
            // btnGondola
            // 
            this.btnGondola.Location = new System.Drawing.Point(12, 165);
            this.btnGondola.Name = "btnGondola";
            this.btnGondola.Size = new System.Drawing.Size(101, 23);
            this.btnGondola.TabIndex = 6;
            this.btnGondola.Text = "Ver en gondola";
            this.btnGondola.UseVisualStyleBackColor = true;
            this.btnGondola.Click += new System.EventHandler(this.btnGondola_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGondola);
            this.Controls.Add(this.txtGondola);
            this.Controls.Add(this.txtBodega);
            this.Controls.Add(this.btnBodega);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnPuntos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MercamaxApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPuntos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnBodega;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.TextBox txtGondola;
        private System.Windows.Forms.Button btnGondola;
    }
}

