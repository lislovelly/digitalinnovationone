using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_net_api.Entities;

namespace trilha_net_api.Context
{

        public class TarefaContext(DbContextOptions<TarefaContext> options) : DbContext(options)
        {
           
        public DbSet<Tarefa> Tarefas { get; set;}
        }
    
}