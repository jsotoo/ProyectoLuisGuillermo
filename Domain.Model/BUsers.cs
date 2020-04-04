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
using Utilities;

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

        public List<Usuario> ObtenerTodos(Usuario u)
        {
            List<Usuario> usu = user.Get(u);
            return usu;
        }

        public List<UsuarioVM> ObtenerTodos(UsuarioVM u)
        {
            Usuario elUsuario = new Usuario() {
                id_usu = u.id_usu,
                Apellidos_usu = u.Apellidos_usu,
                nombres_usu = u.nombres_usu,
                telefono_usu = u.telefono_usu,
                tipo_usu = u.tipo_usu,
            };

            List<Usuario> usuarios = user.Get(elUsuario);
            List<UsuarioVM> losUsuarios = (from usuario in usuarios
                                          select new UsuarioVM
                                          {
                                              id_usu = usuario.id_usu,
                                              Apellidos_usu = usuario.Apellidos_usu,
                                              nombres_usu = usuario.nombres_usu,
                                              telefono_usu = usuario.telefono_usu,
                                              tipo_usu = usuario.tipo_usu
                                          }).ToList();
            return losUsuarios;
        }
    }
}
