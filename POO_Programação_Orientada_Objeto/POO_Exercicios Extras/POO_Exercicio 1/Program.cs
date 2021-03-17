using System;
using POO_Exercicio_1.classe;

namespace POO_Exercicio_Extra
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {   
            int terreo = 0;
            int desce;
            int Andar;
            int quantidade1;
            int quantidade;
            int colocar;
            string opcao;
            int resposta;
            int escolha;
            string[] passageiro;
            passageiro = new string [8];
            
            Elevador elevador = new Elevador();
            
            Console.WriteLine("--------");
            Console.WriteLine("BEM VINDO AO ELEVADOR");
            Console.WriteLine("--------");

            Console.WriteLine("QUANTAS PESSOAS TEM NO ELEVADOR?");
            Console.WriteLine("--------------------------------");
            resposta = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("[1] ENTRAR");
            Console.WriteLine("[2] ANDAR ATUAL");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
                do{
                    switch(escolha){
                case 1: 
                    Console.WriteLine("ADICIONAR UMA PESSOA ? (s) (n)");
                    Console.WriteLine("------------------------------");
                    opcao = Console.ReadLine();
                        if(opcao == "s"){
                            Console.WriteLine("DESEJA COLOCAR QUANTAS PESSOAS ?");
                            Console.WriteLine("--------------------------------");
                            colocar = int.Parse(Console.ReadLine());

                            quantidade = resposta + colocar;
                            Console.WriteLine($"O ELEVADOR TEM {quantidade} PESSOAS");
                            Console.WriteLine("------------------------------------");

                        if(quantidade > elevador.capacidade){
                            Console.WriteLine("ELEVADOR CHEIO ALGUEM PRECISA SAIR");
                            Console.WriteLine("----------------------------------");}
                        
                        if(quantidade <= elevador.capacidade){
                            Console.WriteLine("[1] SUBIR");
                            Console.WriteLine("[2] DESCER");
                            Console.WriteLine("[3] ANDAR ATUAL");
                            escolha = int.Parse(Console.ReadLine());

                        if(escolha == 1){
                            Console.WriteLine("SUBIR PARA QUAL ANDAR");
                            Console.WriteLine("---------------------");
                            Andar = int.Parse(Console.ReadLine());
                            Console.WriteLine($"VOCÊ CHEGOU AO {Andar} andar, com {quantidade} pessoas");
                            Console.WriteLine(""); 
                            Console.WriteLine("QUANTAS PESSOAS SAEM DO ELEVADOR NESSE ANDAR ?");
                            Console.WriteLine("----------------------------------------------");
                            desce = int.Parse(Console.ReadLine());

                            Console.WriteLine($"VOCÊ ESTÁ NO {Andar} ANDAR");
                            Console.WriteLine($"VOCÊ ESTÁ NO {Andar} ANDAR");

                            quantidade1 = quantidade - desce;
                            if(quantidade1 > 0){
                                Console.WriteLine("");
                                Console.WriteLine($"FICARAM {quantidade1} PESSOAS NO ELEVADOR");
                                Console.WriteLine("------------------------------------------");
                            }
                            if(quantidade1 == 0){
                                Console.WriteLine("ELEVADO VAZIO, ELE FICARÁ PARADO");
                            }


                        if (Andar > elevador.totalAndares){
                            Console.WriteLine("Andar Não Existe");
                            Console.WriteLine("----------------");}

                        if(Andar < elevador.andarAtual){
                            Console.WriteLine("Andar Invalido");
                            Console.WriteLine("----------------");

                        Console.WriteLine($"VOCÊ CHEGOU AO {Andar} andar");
                        Console.WriteLine("-----------------------------");
                        }
                    }
                }
                if(escolha == 2){
                    Console.WriteLine("NÃO HÁ COMO DESCER");
                    Console.WriteLine("------------------");
                }
            }break;
        
                case 2:
                Console.WriteLine("VOCÊ ESTÁ NO TERREO E NÃO PODE DESCER");
                Console.WriteLine("-------------------");

                 Console.WriteLine("SUBIR PARA QUAL ANDAR");
                 Console.WriteLine("---------------------");
                            int andar = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O ELEVADOR CHEGOU AO {andar} ANDAR");

                        if (andar > elevador.totalAndares){
                            Console.WriteLine("Andar Não Existe");}

                        if(andar < elevador.andarAtual){
                            Console.WriteLine("Andar Invalido");
                        }break;
                case 3:
                Console.WriteLine($"{elevador.andarAtual}");
                break;
                } 
            }while(escolha != 4);
        } 
    }
}
                   
                                  
