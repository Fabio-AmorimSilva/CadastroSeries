using System.Collections.Generic;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}