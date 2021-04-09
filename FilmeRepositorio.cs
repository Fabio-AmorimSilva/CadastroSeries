using System.Collections.Generic;

namespace Series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> filmes = new List<Filme>();

        public void Atualizar(int id, Filme entidade)
        {
            filmes[id] = entidade;
        }

        public void Excluir(int id)
        {
            filmes[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            filmes.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return filmes;
        }

        public int ProximoId()
        {
            return this.filmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return this.filmes[id];
        }
    }
}