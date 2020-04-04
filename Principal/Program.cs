using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfraDataAccess.EF;
using Domain.Model;
using Domain.Model.Delegates;
using InfraDataAccess.DAO;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usu = new Usuario();
            usu.id_usu = 35;
            usu.nombres_usu = "Ferninda";
            usu.Apellidos_usu = "Soto";
            usu.tipo_usu = "C";
            usu.telefono_usu = 555555;


            BUsers u = new BUsers();
            //Task<bool> task = u.InsertarOne(usu);
            //task.Wait();



            DelegatesUsers du = new DelegatesUsers();

            //List<Usuario> dg = du.MostrarUsuarios(usu);
            du.MostrarNumeroTelefono(usu);

            
            //du.MostrarUsuarios(usu);
            du.MostrarNombreyApellidosUsuario(usu);

            //Task<List<Usuario>> task1 =u.ObtenerTodos(usu);
            //task1.Wait();

            //foreach ( Usuario t in task.Result)
            //{
            //    Console.WriteLine($"ID {t.id_usu} , Nombre {t.nombres_usu}, Apellido {t.Apellidos_usu}, Telefono {t.telefono_usu}, tipo {t.tipo_usu}");
            //}




        }
    }
}
