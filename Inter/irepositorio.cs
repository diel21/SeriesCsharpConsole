using System.Collections.Generic;
namespace DIO.project.Inter

{
    public interface irepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id,T entidade);
         int ProximoId();
    }
}