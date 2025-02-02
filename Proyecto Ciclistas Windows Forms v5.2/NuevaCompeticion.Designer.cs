namespace WindowsFormsApp1
{
    partial class FormNuevaCompeticion
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.Poblacion = new System.Windows.Forms.Label();
            this.buttonNuevaCompeticion = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(137, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(594, 18);
            this.Titulo.TabIndex = 19;
            this.Titulo.Text = "APLICACIÓN DE REGISTRO DE CICLISTAS - CREAR NUEVA COMPETICIÓN";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(14, 15);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 17;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(210, 62);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 14;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(157, 100);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 12;
            this.Fecha.Text = "Fecha";
            this.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Poblacion
            // 
            this.Poblacion.AutoSize = true;
            this.Poblacion.Location = new System.Drawing.Point(140, 65);
            this.Poblacion.Name = "Poblacion";
            this.Poblacion.Size = new System.Drawing.Size(54, 13);
            this.Poblacion.TabIndex = 11;
            this.Poblacion.Text = "Población";
            this.Poblacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Poblacion.UseWaitCursor = true;
            // 
            // buttonNuevaCompeticion
            // 
            this.buttonNuevaCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaCompeticion.Location = new System.Drawing.Point(210, 274);
            this.buttonNuevaCompeticion.Name = "buttonNuevaCompeticion";
            this.buttonNuevaCompeticion.Size = new System.Drawing.Size(192, 23);
            this.buttonNuevaCompeticion.TabIndex = 10;
            this.buttonNuevaCompeticion.Text = "Crear competición";
            this.buttonNuevaCompeticion.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(210, 100);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            // 
            // NuevaCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Poblacion);
            this.Controls.Add(this.buttonNuevaCompeticion);
            this.Name = "NuevaCompeticion";
            this.Text = "NuevaCompeticion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Poblacion;
        private System.Windows.Forms.Button buttonNuevaCompeticion;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}