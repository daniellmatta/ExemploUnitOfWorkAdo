using DominoDeNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoDeNegocio.Entidade
{
    public class EnderecoEntidade 
    {
        public IEnderecoRepositorio _repositorio;

        public EnderecoEntidade(IEnderecoRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        public int IdAluno { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public void Salvar() 
        {
            // Regras de validação e negocio

            this._repositorio.Salvar(this);
        }

        public void Atualizar() 
        {
            this._repositorio.Atualizar(this);
        }

        public void Excluir(int idEndereco) 
        {
            this.Excluir(idEndereco);
        }
    }
}
