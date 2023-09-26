using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Principal
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(Cuenta_Bancaria cuenta)
        {
            context.Cuenta_Bancarias.Add(cuenta);
            context.SaveChanges();
        }

        public void EmitirTarjetaCredito(Tarjeta_de_Crédito tarjeta)
        {
            context.Tarjeta_De_Creditos.Add(tarjeta);
            context.SaveChanges();
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.estado = "Pausada";
                context.SaveChanges();
            }
        }
        public void RealizarDeposito(int cuentaId, double monto)
        {
            var cuenta = context.Cuenta_Bancarias.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.saldo += monto;
                context.SaveChanges();
            }
        }
        public void RealizarExtraccion(int cuentaId, double monto)
        {
            var cuenta = context.Cuenta_Bancarias.Find(cuentaId);
            if (cuenta != null && cuenta.saldo >= monto)
            {
                cuenta.saldo -= monto;
                context.SaveChanges();
            }
        }
        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, double monto)
        {
            var cuentaOrigen = context.Cuenta_Bancarias.Find(cuentaOrigenId);
            var cuentaDestino = context.Cuenta_Bancarias.Find(cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && (cuentaOrigen.saldo >= monto))
            {
                cuentaOrigen.saldo -= monto;
                cuentaDestino.saldo += monto;
                context.SaveChanges();
            }
        }
        public void PagarTarjetaCredito(int tarjetaId, double monto)
        {
            var tarjeta = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (tarjeta != null && tarjeta.estado == "Activa")
            {
                if (monto <= tarjeta.montoDeuda)
                {
                    tarjeta.montoDeuda -= monto;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("El pago supera la deuda actual de la tarjeta.");
                }
            }
        }
        public void GenerarResumenTarjeta(Tarjeta_de_Crédito tarjeta)
        {

            Console.WriteLine("Resumen de la Tarjeta de credito");
            Console.WriteLine("Número de la Tarjeta: " + tarjeta.numeroTarjeta);
            Console.WriteLine("Saldo Disponible: " + tarjeta.saldoDisponible);
            Console.WriteLine("Limite del Crédito: " + tarjeta.limiteCredito);
        }
    }
}
