using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public int UsuarioId { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }        
    }
}
