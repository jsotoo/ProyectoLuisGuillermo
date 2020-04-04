using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.Abstractions;
using InfraDataAccess.EF;

namespace InfraDataAccess.DAO
{
    class Products:DML<Producto>
    {
        public async Task<Producto> Add(Producto prod)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                context.Productos.Add(prod);
                await context.SaveChangesAsync();
            }

            return prod;
        }

        public List<Producto> Get(Producto prod)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                return context.Productos.Where(x =>

                    x.nombre_prod.Contains(prod.nombre_prod) ||
                    x.descp_prod.Contains(prod.descp_prod)).ToList();


            }
        }

        public async Task<Producto> Remove(Producto prod)
        {
            using (CeramicasEntities context = new CeramicasEntities())
            {
                context.Productos.Remove(prod);
                await context.SaveChangesAsync();
            }

            return prod;
        }
    }
}
