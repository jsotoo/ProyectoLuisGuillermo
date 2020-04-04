using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.Abstractions;
using InfraDataAccess.EF;

namespace InfraDataAccess.DAO
{
    public class Users : DML<Usuario>
    {
        CeramicasEntities context = null;
    public Users()
    {
        context = new CeramicasEntities();
    }
    public async Task<Usuario> Add(Usuario element)
    {
        try
        {

            var obj = context.Usuarios.SingleOrDefault(x => x.id_usu == element.id_usu);
            if (obj == null)
            {
                obj = new Usuario();
                context.Usuarios.Add(obj);
            }

            obj.tipo_usu = element.tipo_usu;
            obj.nombres_usu = element.nombres_usu;
            obj.Apellidos_usu = element.Apellidos_usu;
            obj.telefono_usu = element.telefono_usu;
            await context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return element;
    }


    public List<Usuario> Get(Usuario element)
    {
        using (CeramicasEntities context = new CeramicasEntities())
        {
            return context.Usuarios.Where(x =>

                x.nombres_usu.Contains(element.nombres_usu) ||
                x.Apellidos_usu.Contains(element.Apellidos_usu)).ToList();


        }
    }

    public async Task<Usuario> Remove(Usuario element)
    {
        using (CeramicasEntities context = new CeramicasEntities())
        {
            context.Usuarios.Remove(element);
            await context.SaveChangesAsync();
        }

        return element;
    }
}
}
