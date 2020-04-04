using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class UsuarioVM
    {
        public UsuarioVM()
        {
            //this.Ventas = new HashSet<Venta>();
        }

        public int id_usu { get; set; }
        public string tipo_usu { get; set; }
        public string nombres_usu { get; set; }
        public string Apellidos_usu { get; set; }
        public Nullable<int> telefono_usu { get; set; }

        //public virtual ICollection<Venta> Ventas { get; set; }
    }
}
