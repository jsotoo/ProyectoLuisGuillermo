using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.Abstractions;
using InfraDataAccess.EF;

namespace InfraDataAccess.DAO
{
    class WareHouse
    {
        public async Task<Bodega> Add(Bodega bod)
        {

            using (CeramicasEntities context = new CeramicasEntities())
            {
                var obj = context.Bodegas.Find(bod.id_bog);
                if (obj == null)
                {
                    obj = new Bodega();
                    context.Bodegas.Add(obj);
                    await context.SaveChangesAsync();

                }
                obj.id_bog = bod.id_bog;
                obj.id_prod = bod.id_prod;
                obj.cantidad = bod.cantidad;

                await context.SaveChangesAsync();


            }

            return bod;
        }

        public List<Bodega> Get(Bodega bod)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                return context.Bodegas.Where(x =>
                    x.id_bog == bod.id_bog ||
                    x.id_prod == bod.id_prod ||
                    x.cantidad == bod.cantidad
                    ).ToList();


            }
        }

        public async Task<Bodega> Remove(Bodega bod)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                context.Bodegas.Remove(bod);
                await context.SaveChangesAsync();
            }

            return bod;
        }
    }
}
