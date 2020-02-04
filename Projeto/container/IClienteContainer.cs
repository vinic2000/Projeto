using Projeto.Models;
using System.Collections.Generic;

namespace Projeto.container
{
    public interface IClienteContainer
    {
        void Add(Cliente cliente);
        void Delete(Cliente cliente);
        void Editar(Cliente cliente);
        IEnumerable<Cliente> list();
        Cliente Pesquisar(int id);
    }
}