namespace WindowsFormsApp1
{
    partial class FormEliminarCiclista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.btnEliminarCiclista = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(128, 15);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(161, 18);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "ELIMINAR CICLISTA";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(366, 66);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(116, 20);
            this.textDNI.TabIndex = 9;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.BackColor = System.Drawing.Color.Transparent;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.ForeColor = System.Drawing.SystemColors.Control;
            this.DNI.Location = new System.Drawing.Point(128, 67);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(232, 16);
            this.DNI.TabIndex = 8;
            this.DNI.Text = "Introduce el DNI del ciclista a eliminar:";
            this.DNI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEliminarCiclista
            // 
            this.btnEliminarCiclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCiclista.Location = new System.Drawing.Point(488, 63);
            this.btnEliminarCiclista.Name = "btnEliminarCiclista";
            this.btnEliminarCiclista.Size = new System.Drawing.Size(116, 24);
            this.btnEliminarCiclista.TabIndex = 7;
            this.btnEliminarCiclista.Text = "Eliminar ciclista";
            this.btnEliminarCiclista.UseVisualStyleBackColor = true;
            this.btnEliminarCiclista.Click += new System.EventHandler(this.btnEliminarCiclista_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 14);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // FormEliminarCiclista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.btnEliminarCiclista);
            this.Controls.Add(this.Titulo);
            this.Name = "FormEliminarCiclista";
            this.Text = "APLICACIÓN DE REGISTRO DE CICLISTAS - ELIMINAR CICLISTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Button btnEliminarCiclista;
        private System.Windows.Forms.Button buttonVolver;
    }
}