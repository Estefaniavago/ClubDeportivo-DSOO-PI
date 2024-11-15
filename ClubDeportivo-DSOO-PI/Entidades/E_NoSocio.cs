using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo_DSOO_PI.Entidades
{
    public class E_NoSocio : E_Persona
    {
        public string actividadElegida { get; set; }
        public float precio { get; set; } // Precio de la actividad elegida
    }
}