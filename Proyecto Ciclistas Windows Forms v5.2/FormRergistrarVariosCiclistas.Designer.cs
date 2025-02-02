namespace WindowsFormsApp1
{
    partial class FormRegistrarVariosCiclistas
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
            this.dgvVariosCiclistas = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloBicicleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonAgregarVariosCiclistas = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariosCiclistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVariosCiclistas
            // 
            this.dgvVariosCiclistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariosCiclistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.ModeloBicicleta,
            this.PAGADO});
            this.dgvVariosCiclistas.Location = new System.Drawing.Point(135, 64);
            this.dgvVariosCiclistas.Name = "dgvVariosCiclistas";
            this.dgvVariosCiclistas.Size = new System.Drawing.Size(530, 194);
            this.dgvVariosCiclistas.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ModeloBicicleta
            // 
            this.ModeloBicicleta.HeaderText = "ModeloBicicleta";
            this.ModeloBicicleta.Name = "ModeloBicicleta";
            // 
            // PAGADO
            // 
            this.PAGADO.HeaderText = "Pagado";
            this.PAGADO.Name = "PAGADO";
            this.PAGADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PAGADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonAgregarVariosCiclistas
            // 
            this.buttonAgregarVariosCiclistas.Location = new System.Drawing.Point(135, 285);
            this.buttonAgregarVariosCiclistas.Name = "buttonAgregarVariosCiclistas";
            this.buttonAgregarVariosCiclistas.Size = new System.Drawing.Size(121, 23);
            this.buttonAgregarVariosCiclistas.TabIndex = 1;
            this.buttonAgregarVariosCiclistas.Text = "Registrar ciclistas";
            this.buttonAgregarVariosCiclistas.UseVisualStyleBackColor = true;
            this.buttonAgregarVariosCiclistas.Click += new System.EventHandler(this.buttonAgregarVariosCiclistas_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(132, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(256, 18);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "REGISTRAR VARIOS CICLISTAS";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(9, 15);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // FormRegistrarVariosCiclistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonAgregarVariosCiclistas);
            this.Controls.Add(this.dgvVariosCiclistas);
            this.Name = "FormRegistrarVariosCiclistas";
            this.Text = "APP DE REGISTRO DE CICLISTAS - REGISTRAR MÚLTIPLES CICLISTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariosCiclistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVariosCiclistas;
        private System.Windows.Forms.Button buttonAgregarVariosCiclistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloBicicleta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PAGADO;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonVolver;
    }
}