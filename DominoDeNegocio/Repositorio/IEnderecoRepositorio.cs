using DominoDeNegocio.Entidade;
using System;

namespace DominoDeNegocio.Repositorio
{
    public interface IEnderecoRepositorio
    {
        void Atualizar(EnderecoEntidade endereco);
        void Excluir(int idEndereco);
        void Salvar(EnderecoEntidade endereco);
    }
}
