namespace WindowsFormsApp1
{
    partial class FormEditarCompeticion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCompeticion));
            this.buttonVolver = new System.Windows.Forms.Button();
            this.btnEditarCompeticion = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.textPoblacion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(41, 12);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(46, 23);
            this.buttonVolver.TabIndex = 15;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompeticion
            // 
            this.btnEditarCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCompeticion.Location = new System.Drawing.Point(137, 153);
            this.btnEditarCompeticion.Name = "btnEditarCompeticion";
            this.btnEditarCompeticion.Size = new System.Drawing.Size(200, 39);
            this.btnEditarCompeticion.TabIndex = 12;
            this.btnEditarCompeticion.Text = "Guardar los cambios";
            this.btnEditarCompeticion.UseVisualStyleBackColor = true;
            this.btnEditarCompeticion.Click += new System.EventHandler(this.btnEditarCompeticion_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(134, 17);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(188, 18);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "EDITAR COMPETICIÓN";
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(137, 69);
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(200, 20);
            this.textPoblacion.TabIndex = 18;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.Nombre.Location = new System.Drawing.Point(38, 72);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(54, 13);
            this.Nombre.TabIndex = 17;
            this.Nombre.Text = "Población";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Nombre.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseWaitCursor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(137, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 22;
            // 
            // FormEditarCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPoblacion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.btnEditarCompeticion);
            this.Controls.Add(this.Titulo);
            this.Name = "FormEditarCompeticion";
            this.Text = "APP DE REGISTRO DE CICLISTAS - EDITAR COMPETICIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button btnEditarCompeticion;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox textPoblacion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}