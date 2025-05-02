using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.WriteLine("Digite com números inteiros (<int>) os dados dos alunos que farão os cursos A, B e C: ");
            Console.WriteLine();

      
                Console.Write("Quantos alunos farão o curso A ?");
                int qtdA = int.Parse(Console.ReadLine());
     
                for (int i = 0; i < qtdA; i++)
                {
                    Console.Write($"Código do aluno {i + 1}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    cursoA.Add(codigo);
                }

                Console.Write("Quantos alunos farão o curso B ?");
                int qtdB = int.Parse(Console.ReadLine());


                for (int i = 0; i < qtdB; i++)
                {
                    Console.Write($"Código do aluno {i + 1}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    cursoB.Add(codigo);
                }

                Console.Write("Quantos alunos farão o curso C ?");
                int qtdC = int.Parse(Console.ReadLine());

                for (int i = 0; i < qtdC; i++)
                {
                    Console.Write($"Código do aluno {i + 1}: ");
                    int codigo = int.Parse(Console.ReadLine());
                    cursoC.Add(codigo);
                }
            HashSet<int> estudantes = new HashSet<int>(cursoA);
            estudantes.UnionWith(cursoB);
            estudantes.UnionWith(cursoC);

            Console.WriteLine();
            Console.WriteLine($"Número de estudantes: {estudantes.Count}");
            foreach (int obj in estudantes)
            {
                Console.Write(obj + " ");
            }
        }         
           
        }
    }

