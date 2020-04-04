using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.EF;

namespace Domain.Model.Delegates
{
    public class DelegatesUsers
    {
        public BUsers user = new BUsers();

        public List<Usuario> list;
        public List<Usuario> MostrarUsuarios(Usuario usuario)
        {
            Func<Usuario,List<Usuario>> RetornarListaUsuarios = (u) => user.ObtenerTodos(usuario);

            list = RetornarListaUsuarios(usuario);
            return list;
        }


        public void MostrarNumeroTelefono(Usuario usuario)
        {

            Action<string> nombreUsuario = (string message) =>
            {
                
                Console.WriteLine(message);
            };

            nombreUsuario(usuario.telefono_usu.ToString());

        }


        public void MostrarNombreyApellidosUsuario(Usuario usuario)
        {
            
            Action<string> nombreUsuario = delegate (string message)
            {
             
                mostrarNombreUsuario(message);
            };

            nombreUsuario(usuario.nombres_usu + " " + usuario.Apellidos_usu);


        }


        public string mostrarNombreUsuario(string nombre)
        {
            return nombre;

        }



    }





}

