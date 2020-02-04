using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.container
{
    public class ClienteContainer : IClienteContainer
    {
        private readonly ClienteContext clienteContext;

        public ClienteContainer(ClienteContext clienteContext)
        {
            this.clienteContext = clienteContext;
        }

        public void Add(Cliente cliente)
        {
            cliente.IsDeleted = false;
            this.clienteContext.Set<Cliente>().Add(cliente);
            this.clienteContext.SaveChanges();
        }

        public IEnumerable<Cliente> list()
        {
            return this.clienteContext.Set<Cliente>().ToList();
        }

        public Cliente Pesquisar(int id)
        {
            return this.clienteContext.Set<Cliente>().Find(id);
        }

        public void Editar(Cliente cliente)
        {
            this.clienteContext.Set<Cliente>().Update(cliente);
            this.clienteContext.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            cliente = this.SoftDelete(cliente);
            this.clienteContext.Set<Cliente>().Update(cliente);
            this.clienteContext.SaveChanges();
        }
        private Cliente SoftDelete(Cliente cliente)
        {
            cliente.IsDeleted = true;
            return cliente;
        }
    }
}
