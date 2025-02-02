namespace WindowsFormsApp1
{
    partial class FormActualizarEstadoPago
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.btnCambiarAPagado = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(11, 17);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 15;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(532, 66);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(126, 20);
            this.textDNI.TabIndex = 14;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.BackColor = System.Drawing.Color.Transparent;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.ForeColor = System.Drawing.SystemColors.Control;
            this.DNI.Location = new System.Drawing.Point(127, 65);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(399, 17);
            this.DNI.TabIndex = 13;
            this.DNI.Text = "Introduce el DNI del ciclista que quieres marcar como pagado:";
            this.DNI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCambiarAPagado
            // 
            this.btnCambiarAPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarAPagado.Location = new System.Drawing.Point(532, 108);
            this.btnCambiarAPagado.Name = "btnCambiarAPagado";
            this.btnCambiarAPagado.Size = new System.Drawing.Size(126, 39);
            this.btnCambiarAPagado.TabIndex = 12;
            this.btnCambiarAPagado.Text = "Cambiar a pagado";
            this.btnCambiarAPagado.UseVisualStyleBackColor = true;
            this.btnCambiarAPagado.Click += new System.EventHandler(this.btnCambiarAPagado_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(127, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(259, 18);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "ACTUALIZAR ESTADO DE PAGO";
            // 
            // FormActualizarEstadoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.btnCambiarAPagado);
            this.Controls.Add(this.Titulo);
            this.Name = "FormActualizarEstadoPago";
            this.Text = "APP DE REGISTRO DE CICLISTAS - ACTUALIZAR ESTADO DE PAGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Button btnCambiarAPagado;
        private System.Windows.Forms.Label Titulo;
    }
}