using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendas
{
    public static class Sessao
    {
        public static int UsuarioId { get; set; }
    }
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public enum ETipoUsuario
    {
        Admin = 1,
        Funcionario
    }
    
}
