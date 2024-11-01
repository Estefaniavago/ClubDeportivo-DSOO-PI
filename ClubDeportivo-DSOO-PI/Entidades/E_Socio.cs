using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo_DSOO_PI.Entidades
{
    public class E_Socio : E_Persona
    {
        public string numeroSocio { get; set; }
        public DateTime fechaDePago { get; set; }
    }
}
