namespace Nomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorSalarioBase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDctoSalud = new System.Windows.Forms.Label();
            this.lblDctoPension = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescuentoCcf = new System.Windows.Forms.Label();
            this.btnCalcularSalarioBase = new System.Windows.Forms.Button();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.btnCalcularDescuentos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblValorSalarioFinal = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nómida de Empleados";
            // 
            // lblValorSalarioBase
            // 
            this.lblValorSalarioBase.AutoSize = true;
            this.lblValorSalarioBase.Font = new System.Drawing.Font("Arial", 14F);
            this.lblValorSalarioBase.Location = new System.Drawing.Point(179, 188);
            this.lblValorSalarioBase.Name = "lblValorSalarioBase";
            this.lblValorSalarioBase.Size = new System.Drawing.Size(112, 22);
            this.lblValorSalarioBase.TabIndex = 1;
            this.lblValorSalarioBase.Text = "SalarioBase";
            this.lblValorSalarioBase.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(179, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(179, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pensión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(179, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCF:";
            // 
            // lblDctoSalud
            // 
            this.lblDctoSalud.AutoSize = true;
            this.lblDctoSalud.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDctoSalud.Location = new System.Drawing.Point(325, 244);
            this.lblDctoSalud.Name = "lblDctoSalud";
            this.lblDctoSalud.Size = new System.Drawing.Size(95, 22);
            this.lblDctoSalud.TabIndex = 5;
            this.lblDctoSalud.Text = "dctoSalud";
            this.lblDctoSalud.Visible = false;
            // 
            // lblDctoPension
            // 
            this.lblDctoPension.AutoSize = true;
            this.lblDctoPension.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDctoPension.Location = new System.Drawing.Point(325, 291);
            this.lblDctoPension.Name = "lblDctoPension";
            this.lblDctoPension.Size = new System.Drawing.Size(116, 22);
            this.lblDctoPension.TabIndex = 6;
            this.lblDctoPension.Text = "dctoPension";
            this.lblDctoPension.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16F);
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ingrese la cantidad de horas trabajadas:";
            // 
            // lblDescuentoCcf
            // 
            this.lblDescuentoCcf.AutoSize = true;
            this.lblDescuentoCcf.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDescuentoCcf.Location = new System.Drawing.Point(325, 338);
            this.lblDescuentoCcf.Name = "lblDescuentoCcf";
            this.lblDescuentoCcf.Size = new System.Drawing.Size(165, 22);
            this.lblDescuentoCcf.TabIndex = 8;
            this.lblDescuentoCcf.Text = "dctoCajaCFamiliar";
            this.lblDescuentoCcf.Visible = false;
            // 
            // btnCalcularSalarioBase
            // 
            this.btnCalcularSalarioBase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcularSalarioBase.Location = new System.Drawing.Point(45, 174);
            this.btnCalcularSalarioBase.Name = "btnCalcularSalarioBase";
            this.btnCalcularSalarioBase.Size = new System.Drawing.Size(115, 36);
            this.btnCalcularSalarioBase.TabIndex = 9;
            this.btnCalcularSalarioBase.Text = "Salario Base";
            this.btnCalcularSalarioBase.UseVisualStyleBackColor = true;
            this.btnCalcularSalarioBase.Click += new System.EventHandler(this.btnCalcularSalarioBase_Click);
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Font = new System.Drawing.Font("Arial", 14F);
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(412, 117);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(89, 29);
            this.txtHorasTrabajadas.TabIndex = 10;
            // 
            // btnCalcularDescuentos
            // 
            this.btnCalcularDescuentos.Enabled = false;
            this.btnCalcularDescuentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalcularDescuentos.Location = new System.Drawing.Point(45, 244);
            this.btnCalcularDescuentos.Name = "btnCalcularDescuentos";
            this.btnCalcularDescuentos.Size = new System.Drawing.Size(113, 35);
            this.btnCalcularDescuentos.TabIndex = 11;
            this.btnCalcularDescuentos.Text = "Descuentos";
            this.btnCalcularDescuentos.UseVisualStyleBackColor = true;
            this.btnCalcularDescuentos.Click += new System.EventHandler(this.btnCalcularDescuentos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(325, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Salario Final:";
            // 
            // lblValorSalarioFinal
            // 
            this.lblValorSalarioFinal.AutoSize = true;
            this.lblValorSalarioFinal.Font = new System.Drawing.Font("Arial", 14F);
            this.lblValorSalarioFinal.Location = new System.Drawing.Point(464, 188);
            this.lblValorSalarioFinal.Name = "lblValorSalarioFinal";
            this.lblValorSalarioFinal.Size = new System.Drawing.Size(127, 22);
            this.lblValorSalarioFinal.TabIndex = 13;
            this.lblValorSalarioFinal.Text = "vlrSalarioFinal";
            this.lblValorSalarioFinal.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.Location = new System.Drawing.Point(522, 117);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 29);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblValorSalarioFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcularDescuentos);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.btnCalcularSalarioBase);
            this.Controls.Add(this.lblDescuentoCcf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDctoPension);
            this.Controls.Add(this.lblDctoSalud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorSalarioBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorSalarioBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDctoSalud;
        private System.Windows.Forms.Label lblDctoPension;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescuentoCcf;
        private System.Windows.Forms.Button btnCalcularSalarioBase;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Button btnCalcularDescuentos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValorSalarioFinal;
        private System.Windows.Forms.Button btnBorrar;
    }
}

