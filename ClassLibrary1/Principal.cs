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

        public void AgregarCliente(Clientes cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();

        }
        public void CrearCuentaBancaria(Cuenta_Bancarias cuenta)
        {
            context.Cuentas_Bancarias.Add(cuenta);
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
        public void BloquearTarjetaCredito(int tarjetaId)
        {
            var tarjeta = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.estado = "Bloqueada";
                context.SaveChanges();
            }
        }
        public void ActivarTarjetaCredito (int tarjetaId)
        {
            var tarjeta = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (tarjeta != null)
            {
                tarjeta.estado = "Activa";
                context.SaveChanges();
            }
        }
        public void RealizarDeposito(int cuentaId, double monto)
        {
            var cuenta = context.Cuentas_Bancarias.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.saldo += monto;
                context.SaveChanges();
            }
        }
        public void RealizarExtraccion(int cuentaId, double monto)
        {
            var cuenta = context.Cuentas_Bancarias.Find(cuentaId);
            if (cuenta != null && cuenta.saldo >= monto)
            {
                cuenta.saldo -= monto;
                context.SaveChanges();
            }
        }
        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, double monto)
        {
            var cuentaOrigen = context.Cuentas_Bancarias.Find(cuentaOrigenId);
            var cuentaDestino = context.Cuentas_Bancarias.Find(cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && (cuentaOrigen.saldo >= monto))
            {
                cuentaOrigen.saldo -= monto;
                cuentaDestino.saldo += monto;
                context.SaveChanges();
            }
        }
        public bool PagarTarjetaCredito(int tarjetaId, double monto)
        {
            var tarjeta = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (tarjeta != null && tarjeta.estado == "Activa")
            {
                if (monto <= tarjeta.montoDeuda)
                {
                    tarjeta.montoDeuda -= monto;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        
        }
        public string GenerarResumenTarjeta(int tarjetaId)
        {
            var resumen = context.Tarjeta_De_Creditos.Find(tarjetaId);
            if (resumen != null)
            {
                return resumen.estado + "\n" + resumen.saldoDisponible + "\n" + resumen.montoDeuda + "\n" + resumen.limiteCredito;


            }
            else return "Error";
        }
        public List<Clientes> ListaClientes()
        {
            return context.Clientes.ToList();
        }
        public List<Cuenta_Bancarias> ListaBancaria()
        {
            return context.Cuentas_Bancarias.ToList();
        }
        public List<Tarjeta_de_Crédito> ListaTarjeta()
        {
            return context.Tarjeta_De_Creditos.ToList();
        }
    }
}
