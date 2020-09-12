using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        Salario salario = new Salario();
        Descuento descuento = new Descuento();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalarioBase_Click(object sender, EventArgs e)
        {
            salario.setCantidadHoras(double.Parse(txtHorasTrabajadas.Text));
            lblValorSalarioBase.Visible = true;
            lblValorSalarioBase.Text = Convert.ToString(string.Format("{0:n0}", salario.calcularSalarioBase()));
            btnCalcularDescuentos.Enabled = true;
        }

        private void btnCalcularDescuentos_Click(object sender, EventArgs e)
        {
            descuento.setCantidadHoras(double.Parse(txtHorasTrabajadas.Text));
            lblDctoSalud.Visible = true;
            lblDctoSalud.Text = Convert.ToString(string.Format("{0:n0}", descuento.calcularSalud()));
            lblDctoPension.Visible = true;
            lblDctoPension.Text = Convert.ToString(string.Format("{0:n0}", descuento.calcularPension()));
            lblDescuentoCcf.Visible = true;
            lblDescuentoCcf.Text = Convert.ToString(string.Format("{0:n0}", descuento.calcularCcf()));
            lblValorSalarioFinal.Visible = true;
            lblValorSalarioFinal.Text = Convert.ToString(string.Format("{0:n0}", descuento.calcularSalarioFinal()));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtHorasTrabajadas.Text = string.Empty;
            lblValorSalarioBase.Text = string.Empty;
            lblDctoSalud.Text = string.Empty;
            lblDctoPension.Text = string.Empty;
            lblDescuentoCcf.Text = string.Empty;
            lblValorSalarioFinal.Text = string.Empty;
            btnCalcularDescuentos.Enabled = false;
            txtHorasTrabajadas.Focus();
        }
    }
}
