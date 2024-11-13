using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo_DSOO_PI.Entidades
{
    public class E_Persona
    {
        public int idRegistro { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipodoc { get; set; }
        public int nrodoc { get; set; }
        public bool aptofisico { get; set; }
        public bool condicion { get; set; }

    }
}
