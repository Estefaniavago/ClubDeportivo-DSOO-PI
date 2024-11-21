using System;

namespace ClubDeportivo_DSOO_PI.Entidades
{
    public class E_Vencimientos
    {
        public int idPago { get; set; }
        public int idRegistro { get; set; }
        public DateTime fechaPago { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string medioPago { get; set; }
        public string cuotas { get; set; }

        public string EstadoVencimiento
        {
            get
            {
                return fechaVencimiento < DateTime.Now
                    ? "Vencido"
                    : $"Vence el {fechaVencimiento:dd/MM/yyyy}";
            }
        }
    }
}