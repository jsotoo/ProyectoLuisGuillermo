//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfraDataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DevolucionesXProducto
    {
        public int id_dev_prod { get; set; }
        public int id_devolucion { get; set; }
        public int id_prod { get; set; }
    
        public virtual Devolucione Devolucione { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
