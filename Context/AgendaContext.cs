using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class AgendaContext : DbContext
    {
        //faz a conexao com o banco de dados com a seguinte config
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }
        //representa a tabela no banco de dados
        public DbSet<Contato> Contatos{ get; set; }
    }
}