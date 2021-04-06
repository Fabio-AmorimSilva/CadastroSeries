using System.Collections.Generic;

namespace Series
{
    //Utilização de tipos genéticos permite generelização de uso
    public interface IRepositorio<T> //Tipo genérico
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atualizar(int id, T entidade);

        int ProximoId();

    }
}