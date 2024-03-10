using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    //entidade que vai representar uma tabela do banco de dados
    public class Contato
    {
        public int Id { get; set; }
        public string Nome{ get; set; }

        public string Telefone { get; set; }
        public bool Status { get; set; }
    }
}