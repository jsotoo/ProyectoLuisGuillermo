using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using InfraDataAccess.Abstractions;
using InfraDataAccess.DAO;

namespace Domain.Model
{
    public class BUsers
    {
        public Users user = new Users();



       public async Task<bool> InsertarOne(Usuario u)
        {

            Usuario usu = await user.Add(u);

            return true;


        }

       public async Task<bool> EliminarOne(Usuario u)
        {
           
            Usuario usu = await user.Remove(u);

            return true;
        }


        public  List<Usuario> ObtenerTodos(Usuario u)
        {
            
            List<Usuario> usu = user.Get(u);

            return usu;

        }




    }

       
}
