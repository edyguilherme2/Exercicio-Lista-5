using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
        }

        static void Exercicio1()
        {
            //Exercicio 1
            //Crie um programa que apresente ao usuário uma mensagem de boas-vindas conforme padrãodescrito abaixo:
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Boa noite " + nome.ToUpper());
            Console.WriteLine("Voce esta utilizando a maquina " + Environment.MachineName);
            Console.WriteLine("Hoje é " + DateTime.Now.ToLongDateString());
            Console.WriteLine();
            Console.WriteLine();


        }

        static void Exercicio2()
        {
            Console.WriteLine("Exercicio 2");

            //Após a apresentação inicial, desenvolva um trecho de código que seja capaz dedescobrir na string abaixo, quais são os 5 números consecutivos que retornam o maior produto.
            //Mostre quais foram esses números.Você precisa utilizar comandos em código para retirar eventuais caracteres que não serão 
            //utilizados na atividade. 
            string superstring = "3.2649195; 9300419; 8240871 % 2791073; 3917173; 9851056#9925124,4763040.0965918;9309297%1010589;5634190,7310819#0258142,0929306.0592849#2628868;1392209;4941711%6802169%3655235.1180040#6889981;4529558,3395538;3095206.8162707,5306168%3277453.0758859,8014857.6402319%2329297.7429486#4680437%5500518#7865391#2873377#8086382#5447877%5426116,5085634%7224325#5798439,1178516%4312072.0796522.9304179;0434651%6509028#4787438#8491024%3015385,5290222%5294927%5561596.0460024%1321386,1368206;3408249,6508625.7336954%8002371;7576263%3747889#7408701%0201462#4900590;9622169#0048623%4969522%4528884#4990786.3003232;6365305%3586311.5647329%3264194;2114295,3171009;9876958,4020305,1632979%0031475.2552181%2602640.5303671.8059160%4988532.4693670%9150725,3340225,6376627.0780785;0990199.4341820.0463039%3299347,7393254%4523854#6603120%9368998#5944279,9085068#8137433,3239866,6379195#7431356.5898614.5810497.3487996#5400022#6149677,8533754%6088682%2032031.6332587,7284531#9239331%8866454,3964222#3314980#8428029.2546101;7316677%0460178;8789264;9316756.1965642;7585590,7383219;9062609,8482023,5717895;2684729;0466794%5370084,0484922;4599156,5815576%3414149.1343440#16129".Replace(",", ";").Replace("%", ";").Replace("#", "").Replace(".", ";").Replace(" ","").Replace(";","");
            int MaiorProduto = 0;
            int vezes = 0;
            for(int i=0; i<= superstring.Length - 5; i +=5)
            {
                var parteString = superstring.Substring(i, 5); 
                int multiplicacao = 1;

                for (int k=0; k < 5; k++)
                {
                    int parteInt = int.Parse(parteString[k].ToString());
                    multiplicacao *= parteInt;
                }

                if (multiplicacao > MaiorProduto)
                {
                    MaiorProduto = multiplicacao;
                }
                vezes++;
            }

            //Mostre ao final todas as substrings que terminam com a cadeia de caracteres “11”e a soma inteira desses caracteres contidos em cada substring.
            Console.WriteLine("Maior multiplicacao é: " + MaiorProduto);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exercicio 3");
            Console.WriteLine();

            int soma_11 = 0;
            for (int i = 0; i <= superstring.Length - 5; i += 5)
            {
                var parteString = superstring.Substring(i, 5);
                if (parteString.Substring(3, 2) == "11")
                {
                    soma_11 += int.Parse(parteString);
                    Console.WriteLine("Numeros que terminam com '11' : "+parteString);
                }
            }

            Console.WriteLine("Soma dos numeros que terminam com '11' : " + soma_11.ToString());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
