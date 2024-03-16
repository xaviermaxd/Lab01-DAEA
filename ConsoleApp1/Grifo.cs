using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Grifo
    {
        public List<Usuario> usuarios;

        public Grifo()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine();
            }
        }


    }
}
