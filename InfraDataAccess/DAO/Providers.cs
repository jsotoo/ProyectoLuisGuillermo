using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.EF;
using InfraDataAccess.Abstractions;

namespace InfraDataAccess.DAO
{
    class Providers: DML<Proveedore>
    {
        public async Task<Proveedore> Add(Proveedore prov)
        {

            using (CeramicasEntities context = new CeramicasEntities())
            {
                var obj = context.Proveedores.Find(prov.id_prov);
                if (obj == null)
                {
                    obj = new Proveedore();
                    context.Proveedores.Add(obj);
                   
                }
                obj.id_prov = prov.id_prov;
                obj.ciudad_prov = prov.ciudad_prov;
                obj.id_per = prov.id_per;
                await context.SaveChangesAsync();

            }

            return prov;
        }

        public List<Proveedore> Get(Proveedore prov)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                return context.Proveedores.Where(x =>
                    x.id_prov == prov.id_prov ||
                    x.ciudad_prov == prov.ciudad_prov ||
                    x.id_per == prov.id_per
                    ).ToList();


            }
        }

        public async Task<Proveedore> Remove(Proveedore prov)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                context.Proveedores.Remove(prov);
                await context.SaveChangesAsync();
            }

            return prov;
        }





    }
}
