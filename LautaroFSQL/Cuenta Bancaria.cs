using ClassLibrary1;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LautaroFSQL
{
    public partial class Cuenta_Bancaria : Form
    {
        public Cuenta_Bancaria()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.ListaBancaria();
        }

        private void Cuenta_Bancaria_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.ListaBancaria();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuenta_Bancarias NuevaCuentaBancaria = new Cuenta_Bancarias();
            NuevaCuentaBancaria.numeroCuenta = int.Parse(txtNumcuenta.Text);
            NuevaCuentaBancaria.saldo = double.Parse(txtSaldo.Text);
            NuevaCuentaBancaria.tipo = txtTipo.Text;
            principal.CrearCuentaBancaria(NuevaCuentaBancaria);
            ActualizarDataGridView();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.RealizarDeposito(((int)dataGridView1[0, CuentaId].Value), double.Parse(txtDepositar.Text));
            ActualizarDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.RealizarExtraccion(((int)dataGridView1[0, CuentaId].Value), double.Parse(txtRetirar.Text));
            ActualizarDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int OrigenId = int.Parse(txtOrigen.Text);
            int DestinoId = int.Parse(txtDestino.Text);

            principal.RealizarTransferencia(OrigenId, DestinoId, double.Parse(txtTransferencia.Text));
            ActualizarDataGridView();
        }
    }
}
