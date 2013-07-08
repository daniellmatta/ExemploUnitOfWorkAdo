using DominoDeNegocio.Entidade;
using MyUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoDeNegocio.Repositorio
{
    public class EnderecoRepositorio : Repository<EnderecoEntidade>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(AdoNetContext context) : base(context)
        {
        }

        public void Salvar(EnderecoEntidade endereco)       
        {
        }

        public void Atualizar(EnderecoEntidade endereco) 
        {
        }

        public void Excluir(int idEndereco) 
        { 
        }
    }
}
