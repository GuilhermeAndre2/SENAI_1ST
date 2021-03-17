using System;

namespace EXERCICIOS_18_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=0, c=0;
            

            Console.WriteLine("Digite quantos numeros deseja vez na sequencia: ");
            int vezes = int.Parse(Console.ReadLine());

            Console. WriteLine("Sequência com" + vezes + "vezes");

            for (int i = 0; i < vezes; i++){
                Console.WriteLine( c + " ,");
                c = a + b;
                a = b;
                b = c;

                
            }
            
        }
    }
}
