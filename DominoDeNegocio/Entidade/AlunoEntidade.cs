using DominoDeNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoDeNegocio.Entidade
{
    public class AlunoEntidade
    {
        private IAlunoRepositorio _repositorio;

        public AlunoEntidade(IAlunoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }
        public IList<EnderecoEntidade> Enderecos { get; set; }

        public void Salvar() 
        {
            // Regras de negocio e validações
            
            this.IdAluno = this._repositorio.Salvar(this);

            if (this.Enderecos != null && this.Enderecos.Count > 0)
            {
                foreach (var endereco in this.Enderecos)
                {
                    endereco.IdAluno = this.IdAluno;
                    endereco.Salvar();
                }
            }
        }

        public void Atualizar() 
        { 
        }

        public void Excluir() 
        {
        }
    }
}
