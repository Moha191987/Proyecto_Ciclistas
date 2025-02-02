namespace WindowsFormsApp1
{
    partial class FormListarCiclistas
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
            this.dgvCiclistas = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCiclistas
            // 
            this.dgvCiclistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclistas.Location = new System.Drawing.Point(12, 52);
            this.dgvCiclistas.Name = "dgvCiclistas";
            this.dgvCiclistas.Size = new System.Drawing.Size(632, 510);
            this.dgvCiclistas.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(134, 13);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(213, 18);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "LISTA DE PARTICIPANTES";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 12);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // FormListarCiclistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dgvCiclistas);
            this.Name = "FormListarCiclistas";
            this.Text = "APP DE REGISTRO DE CICLISTAS - LISTA DE PARTICIPANTES";
            this.Load += new System.EventHandler(this.FormListarCiclistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCiclistas;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonVolver;
    }
}