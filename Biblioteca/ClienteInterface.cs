using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface ClienteInterface
    {
        void InsereCliente(Cliente cliente);
        Cliente PesquisarCliente(string pesquisa);
    }
}
