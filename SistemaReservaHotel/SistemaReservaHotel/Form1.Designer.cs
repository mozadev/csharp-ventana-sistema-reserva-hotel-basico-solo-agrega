namespace SistemaReservaHotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstReserva = new System.Windows.Forms.ListView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboTipodoc = new System.Windows.Forms.ComboBox();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtcodigohabit = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDiasReserva = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tipo doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "numero de doc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "codigo habitacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "categoria habitacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "dias de reserva";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lstReserva
            // 
            this.lstReserva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstReserva.CheckBoxes = true;
            this.lstReserva.Location = new System.Drawing.Point(34, 273);
            this.lstReserva.Name = "lstReserva";
            this.lstReserva.Size = new System.Drawing.Size(767, 132);
            this.lstReserva.TabIndex = 9;
            this.lstReserva.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(174, 213);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(62, 38);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboTipodoc
            // 
            this.cboTipodoc.FormattingEnabled = true;
            this.cboTipodoc.Location = new System.Drawing.Point(83, 65);
            this.cboTipodoc.Name = "cboTipodoc";
            this.cboTipodoc.Size = new System.Drawing.Size(122, 21);
            this.cboTipodoc.TabIndex = 11;
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Location = new System.Drawing.Point(109, 111);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(96, 20);
            this.txtnumdoc.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(83, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtcodigohabit
            // 
            this.txtcodigohabit.Location = new System.Drawing.Point(337, 67);
            this.txtcodigohabit.Name = "txtcodigohabit";
            this.txtcodigohabit.Size = new System.Drawing.Size(96, 20);
            this.txtcodigohabit.TabIndex = 14;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(337, 103);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(96, 21);
            this.cboCategoria.TabIndex = 15;
            // 
            // txtDiasReserva
            // 
            this.txtDiasReserva.Location = new System.Drawing.Point(337, 158);
            this.txtDiasReserva.Name = "txtDiasReserva";
            this.txtDiasReserva.Size = new System.Drawing.Size(96, 20);
            this.txtDiasReserva.TabIndex = 17;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(313, 214);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 36);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtDiasReserva);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtcodigohabit);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtnumdoc);
            this.Controls.Add(this.cboTipodoc);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lstReserva);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lstReserva;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboTipodoc;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtcodigohabit;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtDiasReserva;
        private System.Windows.Forms.Button btnCerrar;
    }
}

