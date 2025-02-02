namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnRegistrarCiclista = new System.Windows.Forms.Button();
            this.btnListarParticipantes = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.btnEliminarCiclista = new System.Windows.Forms.Button();
            this.buttonListarCiclistasBorrados = new System.Windows.Forms.Button();
            this.buttonRegistrarVariosCiclistas = new System.Windows.Forms.Button();
            this.buttonCambiarEstadoPago = new System.Windows.Forms.Button();
            this.buttonListarPendientesPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarCiclista
            // 
            this.btnRegistrarCiclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCiclista.Location = new System.Drawing.Point(42, 81);
            this.btnRegistrarCiclista.Name = "btnRegistrarCiclista";
            this.btnRegistrarCiclista.Size = new System.Drawing.Size(221, 33);
            this.btnRegistrarCiclista.TabIndex = 0;
            this.btnRegistrarCiclista.Text = "Registrar un ciclista";
            this.btnRegistrarCiclista.UseVisualStyleBackColor = true;
            this.btnRegistrarCiclista.Click += new System.EventHandler(this.btnRegistrarCiclista_Click);
            // 
            // btnListarParticipantes
            // 
            this.btnListarParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarParticipantes.Location = new System.Drawing.Point(42, 176);
            this.btnListarParticipantes.Name = "btnListarParticipantes";
            this.btnListarParticipantes.Size = new System.Drawing.Size(221, 33);
            this.btnListarParticipantes.TabIndex = 1;
            this.btnListarParticipantes.Text = "Listar ciclistas";
            this.btnListarParticipantes.UseVisualStyleBackColor = true;
            this.btnListarParticipantes.Click += new System.EventHandler(this.btnListarParticipantes_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(1, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(79, 33);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Atrás";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btnEliminarCiclista
            // 
            this.btnEliminarCiclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCiclista.Location = new System.Drawing.Point(496, 81);
            this.btnEliminarCiclista.Name = "btnEliminarCiclista";
            this.btnEliminarCiclista.Size = new System.Drawing.Size(221, 33);
            this.btnEliminarCiclista.TabIndex = 4;
            this.btnEliminarCiclista.Text = "Eliminar ciclista";
            this.btnEliminarCiclista.UseVisualStyleBackColor = true;
            this.btnEliminarCiclista.Click += new System.EventHandler(this.btnEliminarCiclista_Click);
            // 
            // buttonListarCiclistasBorrados
            // 
            this.buttonListarCiclistasBorrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarCiclistasBorrados.Location = new System.Drawing.Point(269, 176);
            this.buttonListarCiclistasBorrados.Name = "buttonListarCiclistasBorrados";
            this.buttonListarCiclistasBorrados.Size = new System.Drawing.Size(221, 33);
            this.buttonListarCiclistasBorrados.TabIndex = 5;
            this.buttonListarCiclistasBorrados.Text = "Listar bajas";
            this.buttonListarCiclistasBorrados.UseVisualStyleBackColor = true;
            this.buttonListarCiclistasBorrados.Click += new System.EventHandler(this.buttonListarCiclistasBorrados_Click);
            // 
            // buttonRegistrarVariosCiclistas
            // 
            this.buttonRegistrarVariosCiclistas.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrarVariosCiclistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVariosCiclistas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegistrarVariosCiclistas.Location = new System.Drawing.Point(269, 81);
            this.buttonRegistrarVariosCiclistas.Name = "buttonRegistrarVariosCiclistas";
            this.buttonRegistrarVariosCiclistas.Size = new System.Drawing.Size(221, 33);
            this.buttonRegistrarVariosCiclistas.TabIndex = 6;
            this.buttonRegistrarVariosCiclistas.Text = "Registrar varios ciclistas";
            this.buttonRegistrarVariosCiclistas.UseVisualStyleBackColor = true;
            this.buttonRegistrarVariosCiclistas.Click += new System.EventHandler(this.buttonRegistrarVariosCiclistas_Click);
            // 
            // buttonCambiarEstadoPago
            // 
            this.buttonCambiarEstadoPago.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCambiarEstadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarEstadoPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCambiarEstadoPago.Location = new System.Drawing.Point(42, 276);
            this.buttonCambiarEstadoPago.Name = "buttonCambiarEstadoPago";
            this.buttonCambiarEstadoPago.Size = new System.Drawing.Size(221, 33);
            this.buttonCambiarEstadoPago.TabIndex = 7;
            this.buttonCambiarEstadoPago.Text = "Cambiar estado pago";
            this.buttonCambiarEstadoPago.UseVisualStyleBackColor = false;
            this.buttonCambiarEstadoPago.Click += new System.EventHandler(this.buttonCambiarEstadoPago_Click);
            // 
            // buttonListarPendientesPago
            // 
            this.buttonListarPendientesPago.BackColor = System.Drawing.SystemColors.Control;
            this.buttonListarPendientesPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarPendientesPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonListarPendientesPago.Location = new System.Drawing.Point(269, 276);
            this.buttonListarPendientesPago.Name = "buttonListarPendientesPago";
            this.buttonListarPendientesPago.Size = new System.Drawing.Size(221, 33);
            this.buttonListarPendientesPago.TabIndex = 8;
            this.buttonListarPendientesPago.Text = "Listar pendientes de pago";
            this.buttonListarPendientesPago.UseVisualStyleBackColor = false;
            this.buttonListarPendientesPago.Click += new System.EventHandler(this.btnCambiarEstadoPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALTAS/BAJAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "LISTADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(39, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "PAGO DE REGISTROS";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonListarPendientesPago);
            this.Controls.Add(this.buttonCambiarEstadoPago);
            this.Controls.Add(this.buttonRegistrarVariosCiclistas);
            this.Controls.Add(this.buttonListarCiclistasBorrados);
            this.Controls.Add(this.btnEliminarCiclista);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnListarParticipantes);
            this.Controls.Add(this.btnRegistrarCiclista);
            this.Name = "FormMenu";
            this.Text = "APP REGISTRO DE CICLISTAS - Gestionar competición";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCiclista;
        private System.Windows.Forms.Button btnListarParticipantes;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btnEliminarCiclista;
        private System.Windows.Forms.Button buttonListarCiclistasBorrados;
        private System.Windows.Forms.Button buttonRegistrarVariosCiclistas;
        private System.Windows.Forms.Button buttonCambiarEstadoPago;
        private System.Windows.Forms.Button buttonListarPendientesPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}