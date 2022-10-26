using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadora 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Minha primeira calculadora
            /// Ela só realizará operações de adição

            while (true)
            {
                //Primeiro passo receber valor A
                Console.WriteLine("informar o valor A");
                int valorA = int.Parse(Console.ReadLine());
                //segundo passo receber valor B
                Console.WriteLine("informar o valor B");
                int valorB = int.Parse(Console.ReadLine());
                //terceiro passo gerar o resultado
                int resultado = valorA - valorB;
                Console.WriteLine("resultado final");
                Console.WriteLine(resultado);

                bool respostaerrada = true;
                while (respostaerrada)
                {
                    Console.WriteLine("deseja realizar outra operação se sim digite S ou N para não");
                    string respostadosoun = Console.ReadLine();
                    //recebi o S de sim o que eu faço... continuo a operação
                    //recebi o n de não o que eu faço... encerro a aplicação
                    //se eu receber qualquer coisa diferente do que estou pedindo... o que eu faço... repetirei a pergunta ate ele responder corretamente de acordo com o que estou pedindo
                    if (respostadosoun == "s")
                    {
                        respostaerrada = false;
                        continue;
                    }
                    else if (respostadosoun == "n")
                    {
                        respostaerrada = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        respostaerrada = true;

                    }
                }
            }
        }
    }
}
