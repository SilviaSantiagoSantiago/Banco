namespace ATM
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cuent = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.deposito = new System.Windows.Forms.Button();
            this.retiro = new System.Windows.Forms.Button();
            this.estado = new System.Windows.Forms.Button();
            this.rfc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Cuenta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Disponible";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de operacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(75, 73);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(234, 20);
            this.nombre.TabIndex = 4;
            // 
            // cuent
            // 
            this.cuent.Location = new System.Drawing.Point(75, 157);
            this.cuent.Name = "cuent";
            this.cuent.Size = new System.Drawing.Size(234, 20);
            this.cuent.TabIndex = 5;
            // 
            // saldo
            // 
            this.saldo.Enabled = false;
            this.saldo.Location = new System.Drawing.Point(358, 157);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(234, 20);
            this.saldo.TabIndex = 6;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(75, 247);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(234, 20);
            this.cantidad.TabIndex = 7;
            // 
            // deposito
            // 
            this.deposito.Location = new System.Drawing.Point(142, 334);
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(116, 50);
            this.deposito.TabIndex = 8;
            this.deposito.Text = "Deposito";
            this.deposito.UseVisualStyleBackColor = true;
            this.deposito.Click += new System.EventHandler(this.deposito_Click);
            // 
            // retiro
            // 
            this.retiro.Location = new System.Drawing.Point(279, 334);
            this.retiro.Name = "retiro";
            this.retiro.Size = new System.Drawing.Size(116, 50);
            this.retiro.TabIndex = 9;
            this.retiro.Text = "Retiro";
            this.retiro.UseVisualStyleBackColor = true;
            this.retiro.Click += new System.EventHandler(this.retiro_Click);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(418, 334);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(116, 50);
            this.estado.TabIndex = 10;
            this.estado.Text = "Estado";
            this.estado.UseVisualStyleBackColor = true;
            this.estado.Click += new System.EventHandler(this.estado_Click);
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(358, 73);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(234, 20);
            this.rfc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "RFC";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 528);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.retiro);
            this.Controls.Add(this.deposito);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.cuent);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox cuent;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button deposito;
        private System.Windows.Forms.Button retiro;
        private System.Windows.Forms.Button estado;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.Label label5;
    }
}