using DominoDeNegocio.Entidade;
using MyUnitOfWork;

namespace DominoDeNegocio.Repositorio
{
    public class AlunoRepositorio : Repository<AlunoEntidade>, IAlunoRepositorio
    {
        public AlunoRepositorio(AdoNetContext context) : base(context)
        {
        }

        public void Salvar(AlunoEntidade aluno) 
        {
            using (var comand = Context.CreateCommand())
            {
            }
        }

        public void Atualizar(AlunoEntidade aluno) 
        {
            using (var comand = Context.CreateCommand())
            {
            }
        }

        public void Excluir(int idAluno) 
        {
            using (var comand = Context.CreateCommand())
            {
            }
        }
    }
}
