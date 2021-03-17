namespace EXERCICIO_EXTRA.classes
{
    public interface ICarrinho
    {
         void Cadastrar(Produto produto);

         void Listar();

         void Alterar(int cod, Produto produto);

         void Deletar(Produto produto);
    }
}