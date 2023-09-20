namespace utilizando_componente
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
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.Black;
            this.btnPlayer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlayer.Location = new System.Drawing.Point(79, 82);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(213, 65);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "reproductor media player";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Black;
            this.btnPDF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.Location = new System.Drawing.Point(79, 194);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(213, 65);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "lector de PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.BackColor = System.Drawing.Color.Black;
            this.btnNavegador.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNavegador.Location = new System.Drawing.Point(79, 306);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(213, 65);
            this.btnNavegador.TabIndex = 2;
            this.btnNavegador.Text = "navegador web";
            this.btnNavegador.UseVisualStyleBackColor = false;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnNavegador;
    }
}

