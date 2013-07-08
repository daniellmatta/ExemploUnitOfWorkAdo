using DominoDeNegocio.Entidade;
using System;

namespace DominoDeNegocio.Repositorio
{
    public interface IAlunoRepositorio
    {
        int Salvar(AlunoEntidade aluno);
        void Atualizar(AlunoEntidade aluno);
        void Excluir(int idAluno);
    }
}
