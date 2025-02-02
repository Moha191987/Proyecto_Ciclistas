namespace WindowsFormsApp1
{
    partial class FormListarPendientesPago
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
            this.Titulo = new System.Windows.Forms.Label();
            this.dgvCiclistasPendientesPago = new System.Windows.Forms.DataGridView();
            this.buttonActualizarEstadoPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistasPendientesPago)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(21, 13);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 11;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(143, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(403, 18);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "LISTA DE PARTICIPANTES PENDIENTES DE PAGO";
            // 
            // dgvCiclistasPendientesPago
            // 
            this.dgvCiclistasPendientesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclistasPendientesPago.Location = new System.Drawing.Point(21, 83);
            this.dgvCiclistasPendientesPago.Name = "dgvCiclistasPendientesPago";
            this.dgvCiclistasPendientesPago.Size = new System.Drawing.Size(632, 382);
            this.dgvCiclistasPendientesPago.TabIndex = 9;
            // 
            // buttonActualizarEstadoPago
            // 
            this.buttonActualizarEstadoPago.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonActualizarEstadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarEstadoPago.Location = new System.Drawing.Point(21, 486);
            this.buttonActualizarEstadoPago.Name = "buttonActualizarEstadoPago";
            this.buttonActualizarEstadoPago.Size = new System.Drawing.Size(259, 38);
            this.buttonActualizarEstadoPago.TabIndex = 12;
            this.buttonActualizarEstadoPago.Text = "Marcar seleccionados como pagados";
            this.buttonActualizarEstadoPago.UseVisualStyleBackColor = false;
            this.buttonActualizarEstadoPago.Click += new System.EventHandler(this.buttonActualizarEstadoPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selecciona uno o varios ciclistas que desees marcar como PAGADOS:";
            // 
            // FormListarPendientesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActualizarEstadoPago);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dgvCiclistasPendientesPago);
            this.Name = "FormListarPendientesPago";
            this.Text = "APLICACIÓN DE REGISTRO DE CICLISTAS - PENDIENTES DE PAGO";
            this.Load += new System.EventHandler(this.FormListarPendientesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistasPendientesPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView dgvCiclistasPendientesPago;
        private System.Windows.Forms.Button buttonActualizarEstadoPago;
        private System.Windows.Forms.Label label1;
    }
}