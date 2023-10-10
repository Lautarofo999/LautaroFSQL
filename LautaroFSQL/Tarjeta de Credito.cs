using ClassLibrary1;
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
    public partial class Tarjeta_de_Credito : Form
    {
        public Tarjeta_de_Credito()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = principal.ListaTarjeta();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tarjeta_de_Credito_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.ListaTarjeta();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.PausarTarjetaCredito((int)dataGridView1[0, CuentaId].Value);
            ActualizarDataGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tarjeta_de_Crédito NuevaTarjeta = new Tarjeta_de_Crédito();
            NuevaTarjeta.numeroTarjeta = int.Parse(txtNumeroTar.Text);
            NuevaTarjeta.limiteCredito = double.Parse(txtCredito.Text);
            NuevaTarjeta.saldoDisponible = double.Parse(txtSaldo.Text);
            NuevaTarjeta.estado = comboEstado.Text;
            NuevaTarjeta.montoDeuda = double.Parse(txtMonto.Text);


            principal.EmitirTarjetaCredito(NuevaTarjeta);
            ActualizarDataGridView();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.PausarTarjetaCredito((int)dataGridView1[0, CuentaId].Value);
            ActualizarDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.BloquearTarjetaCredito((int)dataGridView1[0, CuentaId].Value);
            ActualizarDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CuentaId = dataGridView1.CurrentCellAddress.Y;
            principal.ActivarTarjetaCredito((int)dataGridView1[0, CuentaId].Value);
            ActualizarDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtMontoPag.Text == null)
            {
                MessageBox.Show("Complete los datos pedidos");
            }
            else
            {
                int cuentaId = dataGridView1.CurrentCellAddress.Y;
                principal.PagarTarjetaCredito(((int)dataGridView1[0, cuentaId].Value), double.Parse(txtMontoPag.Text));
                ActualizarDataGridView();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cuentaId = dataGridView1.CurrentCellAddress.Y;
            MessageBox.Show(principal.GenerarResumenTarjeta(((int)dataGridView1[0, cuentaId].Value)));
        }
    }
}
