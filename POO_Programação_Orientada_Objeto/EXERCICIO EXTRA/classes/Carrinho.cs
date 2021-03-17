using System;
using System.Collections.Generic;

namespace EXERCICIO_EXTRA.classes
{
    public class Carrinho : ICarrinho
    {
        List<Produto> item = new List<Produto>();
        public void Alterar(int cod, Produto produto)
        {
            item.Find(x => x.Codigo == cod).Nome = produto.Nome;
            item.Find(x => x.Codigo == cod).Preco = produto.Preco;
            item.Find(x => x.Codigo == cod).Codigo = produto.Codigo;
            
        }

        public void Cadastrar(Produto produto)
        {
            item.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            item.Remove(produto);
        }

        public void Listar()
        {
            foreach (var coisa in item)
            {
                Console.WriteLine($"Produto: {coisa.Nome} \n Preco: R$ {coisa.Preco} \n Código: {coisa.Codigo}");
            }
        }
    }
}