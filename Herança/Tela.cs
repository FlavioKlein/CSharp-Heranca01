using System;
using System.Globalization;
using System.Collections.Generic;

namespace curso
{
    class Tela
    {
        public static void menuTela()
        {
            Console.Clear();
            Console.WriteLine("Escolha a opção:");
            Console.WriteLine("[1] Informar dados de Trinagulo");
            Console.WriteLine("[2] Informar dados de Retangulo");
            Console.WriteLine("[0] Sair");
        }

        public static OpcaoTela lerOpcao()
        {
            try
            {
                OpcaoTela opcao;
                opcao = (OpcaoTela)int.Parse(Console.ReadLine());
                return opcao;
            }
            catch
            {
                throw new TelaException("Opção inválida...");
            }            
        }

        public static Retangulo umRetangulo()
        {
            double largura, comprimento;

            Console.Clear();
            Console.WriteLine("[Retangulo]");
            Console.Write("Informe a largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Retangulo(largura, comprimento);
        }

        public static Triangulo umTriangulo()
        {
            double a, b, c;

            Console.Clear();
            Console.WriteLine("[Triangulo]");
            Console.Write("Informe o valor de A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de C: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Triangulo(a, b, c);
        }

        public static void imprimirResultado(List<FiguraGeometrica> figura)
        {
            Console.Clear();
            Console.WriteLine("Total de figuras: " + figura.Count);
            Console.WriteLine();

            for (int i = 0; i < figura.Count; i++)
            {
                Console.WriteLine("Figura [" + (i + 1) + "] é um [" + figura[i].GetType().Name + "] sua área é: " + figura[i].area());

            }
            Console.ReadLine();
        }

    }
}
