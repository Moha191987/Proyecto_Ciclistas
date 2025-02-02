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
            this.textPoblacion = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.Poblacion = new System.Windows.Forms.Label();
            this.buttonNuevaCompeticion = new System.Windows.Forms.Button();
            this.monthCalendarCompeticion = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(137, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(246, 18);
            this.Titulo.TabIndex = 19;
            this.Titulo.Text = "CREAR NUEVA COMPETICIÓN";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(14, 15);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 17;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textPoblacion
            // 
            this.textPoblacion.Location = new System.Drawing.Point(210, 62);
            this.textPoblacion.Name = "textPoblacion";
            this.textPoblacion.Size = new System.Drawing.Size(192, 20);
            this.textPoblacion.TabIndex = 14;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.ForeColor = System.Drawing.SystemColors.Control;
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
            this.Poblacion.BackColor = System.Drawing.Color.Transparent;
            this.Poblacion.ForeColor = System.Drawing.SystemColors.Control;
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
            this.buttonNuevaCompeticion.Size = new System.Drawing.Size(192, 37);
            this.buttonNuevaCompeticion.TabIndex = 10;
            this.buttonNuevaCompeticion.Text = "Crear competición";
            this.buttonNuevaCompeticion.UseVisualStyleBackColor = true;
            this.buttonNuevaCompeticion.Click += new System.EventHandler(this.buttonNuevaCompeticion_Click);
            // 
            // monthCalendarCompeticion
            // 
            this.monthCalendarCompeticion.Location = new System.Drawing.Point(210, 100);
            this.monthCalendarCompeticion.Name = "monthCalendarCompeticion";
            this.monthCalendarCompeticion.TabIndex = 20;
            // 
            // FormNuevaCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.monthCalendarCompeticion);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.textPoblacion);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Poblacion);
            this.Controls.Add(this.buttonNuevaCompeticion);
            this.Name = "FormNuevaCompeticion";
            this.Text = "APP DE REGISTRO DE CICLISTAS - CREAR NUEVA COMPETICIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textPoblacion;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Poblacion;
        private System.Windows.Forms.Button buttonNuevaCompeticion;
        private System.Windows.Forms.MonthCalendar monthCalendarCompeticion;
    }
}