using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {



            Conta c = new Conta();
            string acao = "";
            double resultado;

            double segSaque;
            double resultDois;
            double segDeposito;

            Console.WriteLine("Ola, por favor nos informe seu nome: ");
            c.Nome = Console.ReadLine();

            Console.WriteLine("voce deseja sacar(s), depositar(d)? ou sair(f)?");
            acao = Console.ReadLine();

            while (acao != "f")
            {




                if (acao == "s")
                {
                    Console.WriteLine("Por favor informe o quanto voce tem na conta: ");
                    c.Saldo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor informe quanto voce quer sacar: ");
                    c.Saque = double.Parse(Console.ReadLine());

                    resultado = (c.Saldo - c.Saque);
                    if (resultado < 0)
                    {
                        Console.WriteLine("Saldo de " + resultado + " infelizmente não podemos dar prosseguimento!");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("por favor digite (f) para sair");
                        acao = Console.ReadLine();

                    }
                    else if (resultado > 0)
                    {
                        Console.WriteLine("seu saque de " + c.Saque + " foi bem sucedido, seu saldo agora é de " + resultado);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                        acao = Console.ReadLine();

                        if (acao == "s")
                        {
                            Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar quanto?");
                            segSaque = double.Parse(Console.ReadLine());
                            resultDois = (resultado - segSaque);
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                            acao = Console.ReadLine();



                            if (acao == "d")
                                Console.WriteLine("Seu saldo é igual a " + resultDois);

                            {
                                Console.WriteLine("deseja depositar quanto?");
                                c.Deposito = double.Parse(Console.ReadLine());
                                resultDois = (c.Deposito + resultado);
                                Console.WriteLine("--------------------------------!");
                                Console.WriteLine("Seu novo saldo é de " + resultDois);
                                Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                acao = Console.ReadLine();


                                while (acao == "d")
                                {
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja depositar quanto?");
                                    segDeposito = double.Parse(Console.ReadLine());
                                    resultDois = (resultDois + segDeposito);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                    acao = Console.ReadLine();

                                    if (acao == "s")
                                    {
                                        Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar quanto?");
                                        segSaque = double.Parse(Console.ReadLine());
                                        resultDois = (resultado - segSaque);
                                        Console.WriteLine("-----------------------------------------------");
                                        Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                        acao = Console.ReadLine();

                                        while (acao == "s")
                                        {
                                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar quanto?");
                                            segSaque = double.Parse(Console.ReadLine());
                                            resultDois = (resultado - segSaque);
                                            Console.WriteLine("-----------------------------------------------");
                                            Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                            Console.WriteLine("------------------------------------------------");
                                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                            acao = Console.ReadLine();

                                        }

                                    }
                                }

                            }


                        }
                        else
                        {
                            if (acao == "d")
                                Console.WriteLine("Seu saldo é igual a " + resultado);

                            {
                                Console.WriteLine("deseja depositar quanto?");
                                c.Deposito = double.Parse(Console.ReadLine());
                                resultDois = (c.Deposito + resultado);
                                Console.WriteLine("--------------------------------!");
                                Console.WriteLine("Seu novo saldo é de " + resultDois);
                                Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                acao = Console.ReadLine();


                                while (acao == "d")
                                {
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja depositar quanto?");
                                    segDeposito = double.Parse(Console.ReadLine());
                                    resultDois = (resultDois + segDeposito);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                    acao = Console.ReadLine();

                                    if (acao == "s")
                                    {
                                        Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar quanto?");
                                        segSaque = double.Parse(Console.ReadLine());
                                        resultDois = (resultado - segSaque);
                                        Console.WriteLine("-----------------------------------------------");
                                        Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                        Console.WriteLine("------------------------------------------------");
                                        Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                        acao = Console.ReadLine();

                                        while (acao == "s")
                                        {
                                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar quanto?");
                                            segSaque = double.Parse(Console.ReadLine());
                                            resultDois = (resultado - segSaque);
                                            Console.WriteLine("-----------------------------------------------");
                                            Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                            Console.WriteLine("------------------------------------------------");
                                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                            acao = Console.ReadLine();

                                        }

                                    }
                                }


                                if (acao == "s")
                                {
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar mais quanto?");
                                    segSaque = double.Parse(Console.ReadLine());
                                    resultDois = (resultado - segSaque);
                                    if (resultDois < 0)
                                    {
                                        Console.WriteLine("Saldo de " + resultDois + " infelizmente não podemos dar prosseguimento ao saque, voce deseja depositar?");
                                        Console.WriteLine("----------------------------------------");
                                        Console.WriteLine("Digite (f) para cancelar ou (d) para depositar");
                                        acao = Console.ReadLine();

                                        if (acao == "d")
                                        {
                                            Console.WriteLine("quanto voce deseja depositar? ");
                                            segDeposito = double.Parse(Console.ReadLine());
                                            resultDois = (resultado + segDeposito);

                                            Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                                            Console.WriteLine("--------------------------------------------------");
                                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                            acao = Console.ReadLine();

                                            while (acao == "d")
                                            {
                                                Console.WriteLine("quanto voce deseja depositar? ");
                                                segDeposito = double.Parse(Console.ReadLine());
                                                resultDois = (resultado + segDeposito);

                                                Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                                                Console.WriteLine("--------------------------------------------------");
                                                Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                                acao = Console.ReadLine();


                                            }

                                        }

                                    }
                                    else if (resultDois > 0)
                                    {
                                        Console.WriteLine("-----------------------------------------------");
                                        Console.WriteLine("agora voce tem " + resultDois + " obrigado por usar o nosso banco!");
                                        Console.WriteLine("Por favor digite (f) para sair!");
                                        acao = Console.ReadLine();
                                    }

                                }

                                else if (acao == "d")
                                {
                                    Console.WriteLine("agora voce tem " + resultado + " voce deseja depositar quanto?");
                                    segDeposito = double.Parse(Console.ReadLine());
                                    resultDois = (resultado + segDeposito);
                                    Console.WriteLine("seu deposito de " + c.Deposito + " foi bem sucedido, seu saldo agora é de " + resultado);
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                    acao = Console.ReadLine();

                                }

                            }




                        }

                    }


                }


                else if (acao == "d")
                {
                    Console.WriteLine("Por favor informe o quanto voce tem na conta: ");
                    c.Saldo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor informe quanto voce quer depositar: ");
                    c.Deposito = double.Parse(Console.ReadLine());

                    resultado = (c.Saldo + c.Deposito);
                    Console.WriteLine("seu deposito de " + c.Deposito + " foi bem sucedido, seu saldo agora é de " + resultado);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                    acao = Console.ReadLine();



                    if (acao == "s")
                    {
                        Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar mais quanto?");
                        segSaque = double.Parse(Console.ReadLine());
                        resultDois = (resultado - segSaque);
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("agora voce tem " + resultDois + " obrigado por usar o nosso banco!");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Por favor digite (f) para sair!");
                        acao = Console.ReadLine();
                    }

                    else if (acao == "d")
                    {
                        Console.WriteLine("agora voce tem " + resultado + " voce deseja depositar quanto?");
                        segDeposito = double.Parse(Console.ReadLine());
                        resultDois = (resultado + segDeposito);
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("agora voce tem " + resultDois + " obrigado por usar o nosso banco!");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Por favor digite (f) para sair!");
                        acao = Console.ReadLine();

                    }

                    else if (acao == "d")
                    {
                        Console.WriteLine("agora voce tem " + resultado + " voce deseja depositar quanto?");
                        segDeposito = double.Parse(Console.ReadLine());
                        resultDois = (resultado + segDeposito);
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                        acao = Console.ReadLine();

                        while (acao == "d")
                        {
                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja depositar quanto?");
                            segDeposito = double.Parse(Console.ReadLine());
                            resultDois = (resultDois + segDeposito);
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("seu deposito de " + segDeposito + " foi bem sucedido, seu saldo agora é de " + resultDois);
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                            acao = Console.ReadLine();

                            if (acao == "s")
                            {
                                Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar quanto?");
                                segSaque = double.Parse(Console.ReadLine());
                                resultDois = (resultado - segSaque);
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                Console.WriteLine("------------------------------------------------");
                                Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                acao = Console.ReadLine();

                                while (acao == "s")
                                {
                                    Console.WriteLine("agora voce tem " + resultado + " voce deseja sacar quanto?");
                                    segSaque = double.Parse(Console.ReadLine());
                                    resultDois = (resultado - segSaque);
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.WriteLine("seu saque de " + segSaque + " foi bem sucedido!");
                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine("agora voce tem " + resultDois + " voce deseja sacar(s), depositar(d)? ou sair(f)?");
                                    acao = Console.ReadLine();

                                }
                            }

                        }
                    }
                }
            }
        }
    }
}

