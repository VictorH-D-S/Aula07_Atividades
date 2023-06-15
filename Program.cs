using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Atividades
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double nota1, nota2, nota3;
            Console.WriteLine("Nota1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota3: ");
            nota3 = double.Parse(Console.ReadLine());

            if(nota1 > nota2 && nota1 > nota3)
            {
                Console.WriteLine($"Maior Nota: {nota1}");
            }

            if (nota2 > nota1 && nota2 > nota3)
            {
                Console.WriteLine($"Maior Nota: {nota2}");
            }
            if (nota3 > nota2 && nota3 > nota1)
            {
                Console.WriteLine($"Maior Nota: {nota3}");
            }

            Console.ReadKey();
        }
       
        void Atv01()
        {
            double numero;
            Console.WriteLine("Insira número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine($"Numero vai ser tipo tá ligado dog igual a: {numero * 0.1}");
            }

            Console.WriteLine("BETTER CALL SAUL");
            
            Console.ReadKey();

        }
            void Atv02()
        {
            string nome;
            double media;

            Console.WriteLine("Nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a média: ");
            media = double.Parse(Console.ReadLine());

            if (media >= 6)
            {
                Console.WriteLine("ALUNO APROVADO!");
            }
            Console.WriteLine("ALUNO REPROVADO! VEJO VOCÊ ANO QUE VEM!");

            Console.ReadKey();
        }

            void Atv03()
        {
            double numba;
            Console.WriteLine("Digite Numba: ");
            numba = double.Parse(Console.ReadLine());

            if (numba > 100)
            {
                Console.WriteLine(numba + 150);
            }

            Console.ReadKey();
        }
    }
}
