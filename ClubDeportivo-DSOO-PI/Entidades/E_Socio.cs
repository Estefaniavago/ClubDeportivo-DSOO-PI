using System;

namespace ClubDeportivo_DSOO_PI.Entidades
{
    public class E_Socio : E_Persona
    {
        public string numeroSocio { get; set; }
        public DateTime? fechaVencimiento { get; set; } // Fecha de vencimiento de la cuota

        // Propiedad que devuelve el estado de la cuota
        public string EstadoCuota
        {
            get
            {
                if (!fechaVencimiento.HasValue || fechaVencimiento.Value <= DateTime.Now)
                {
                    return "Cuota vencida";
                }
                return $"Cuota al día (vence el {fechaVencimiento.Value.ToShortDateString()})";
            }
        }
    }
}