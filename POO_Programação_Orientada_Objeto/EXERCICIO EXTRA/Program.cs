using System;
using EXERCICIO_EXTRA.classes;

namespace EXERCICIO_EXTRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto item1 = new Produto();
            item1.Codigo = 1;
            item1.Nome = "Iphone";
            item1.Preco = 5000f;

            Produto item2 = new Produto();
            item2.Codigo = 2;
            item2.Nome = "Xiaomi";
            item2.Preco = 2500f;

            Produto item3 = new Produto();
            item3.Codigo = 3;
            item3.Nome = "Motorola";
            item3.Preco = 2000f;

            cart.Cadastrar(item1);
            Console.WriteLine("");
            cart.Cadastrar(item2);
            cart.Listar();
            Console.WriteLine("");

            cart.Alterar(item1.Codigo, item3);
            cart.Listar();
            Console.WriteLine("");

            cart.Deletar(item2);
            cart.Listar();
        }
    }
}
