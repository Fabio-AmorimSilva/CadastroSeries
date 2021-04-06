using System.Collections.Generic;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            listSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listSerie;
        }

        public int ProximoId()
        {
            return listSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listSerie[id];
        }
    }
}