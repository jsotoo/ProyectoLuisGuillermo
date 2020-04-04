using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.Abstractions;
using InfraDataAccess.EF;

namespace InfraDataAccess.DAO
{
    class Sales: DML<Venta>
    {
        public async Task<Venta> Add(Venta vent)
        {

            using (CeramicasEntities context = new CeramicasEntities())
            {
                var obj = context.Ventas.Find(vent.id_venta);
                if (obj == null)
                {
                    obj = new Venta();
                    context.Ventas.Add(obj);
                    await context.SaveChangesAsync();

                }
                obj.id_venta = vent.id_venta;
                obj.fecha_venta = vent.fecha_venta;
                obj.total_venta = vent.total_venta;
                obj.id_usu = vent.id_usu;
                obj.tipo_usu = vent.tipo_usu;

                await context.SaveChangesAsync();


            }

            return vent;
        }

        public List<Venta> Get(Venta vent)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                return context.Ventas.Where(x =>
                    x.id_venta == vent.id_venta ||
                    x.fecha_venta == vent.fecha_venta ||
                    x.total_venta == vent.total_venta
                    ).ToList();


            }
        }

        public async Task<Venta> Remove(Venta vent)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                context.Ventas.Remove(vent);
                await context.SaveChangesAsync();
            }

            return vent;
        }


    }
}
