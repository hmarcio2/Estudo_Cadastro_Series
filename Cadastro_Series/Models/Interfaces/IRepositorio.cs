﻿namespace Cadastro_Series.Models
{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();       
        

        
    }
}
