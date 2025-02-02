namespace WindowsFormsApp1
{
    partial class FormAgregarCiclista
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
            this.buttonRegistrarCiclista = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.ModeloBicicleta = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textModeloBicicleta = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.checkPagado = new System.Windows.Forms.CheckBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistrarCiclista
            // 
            this.buttonRegistrarCiclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarCiclista.Location = new System.Drawing.Point(248, 210);
            this.buttonRegistrarCiclista.Name = "buttonRegistrarCiclista";
            this.buttonRegistrarCiclista.Size = new System.Drawing.Size(100, 23);
            this.buttonRegistrarCiclista.TabIndex = 0;
            this.buttonRegistrarCiclista.Text = "Agregar ciclista";
            this.buttonRegistrarCiclista.UseVisualStyleBackColor = true;
            this.buttonRegistrarCiclista.Click += new System.EventHandler(this.buttonRegistrarCiclista_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.Nombre.Location = new System.Drawing.Point(170, 75);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Nombre.UseWaitCursor = true;
            // 
            // ModeloBicicleta
            // 
            this.ModeloBicicleta.AutoSize = true;
            this.ModeloBicicleta.BackColor = System.Drawing.Color.Transparent;
            this.ModeloBicicleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloBicicleta.ForeColor = System.Drawing.SystemColors.Control;
            this.ModeloBicicleta.Location = new System.Drawing.Point(120, 106);
            this.ModeloBicicleta.Name = "ModeloBicicleta";
            this.ModeloBicicleta.Size = new System.Drawing.Size(106, 16);
            this.ModeloBicicleta.TabIndex = 2;
            this.ModeloBicicleta.Text = "Modelo bicicleta";
            this.ModeloBicicleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.BackColor = System.Drawing.Color.Transparent;
            this.DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.ForeColor = System.Drawing.SystemColors.Control;
            this.DNI.Location = new System.Drawing.Point(196, 145);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(30, 16);
            this.DNI.TabIndex = 3;
            this.DNI.Text = "DNI";
            this.DNI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(248, 71);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textModeloBicicleta
            // 
            this.textModeloBicicleta.Location = new System.Drawing.Point(248, 106);
            this.textModeloBicicleta.Name = "textModeloBicicleta";
            this.textModeloBicicleta.Size = new System.Drawing.Size(100, 20);
            this.textModeloBicicleta.TabIndex = 5;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(248, 142);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 20);
            this.textDNI.TabIndex = 6;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 12);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // checkPagado
            // 
            this.checkPagado.AutoSize = true;
            this.checkPagado.Location = new System.Drawing.Point(248, 178);
            this.checkPagado.Name = "checkPagado";
            this.checkPagado.Size = new System.Drawing.Size(63, 17);
            this.checkPagado.TabIndex = 8;
            this.checkPagado.Text = "Pagado";
            this.checkPagado.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(135, 15);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(213, 18);
            this.Titulo.TabIndex = 9;
            this.Titulo.Text = "LISTA DE PARTICIPANTES";
            // 
            // FormAgregarCiclista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.checkPagado);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textModeloBicicleta);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.ModeloBicicleta);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.buttonRegistrarCiclista);
            this.Name = "FormAgregarCiclista";
            this.Text = "APP DE REGISTRO DE CICLISTAS - LISTA DE PARTICIPANTES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarCiclista;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ModeloBicicleta;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textModeloBicicleta;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.CheckBox checkPagado;
        private System.Windows.Forms.Label Titulo;
    }
}