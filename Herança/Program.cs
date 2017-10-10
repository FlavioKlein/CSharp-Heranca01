using System;
using System.Collections.Generic;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFiguraGeometrica> figura = new List<IFiguraGeometrica>();
            
            OpcaoTela opcao;
            bool continuar = true;
            do
            {
                Tela.menuTela();
                try
                {
                    opcao = Tela.lerOpcao();
                    switch (opcao)
                    {
                        case OpcaoTela.Retangulo:
                            figura.Add(Tela.umTriangulo());
                            break;
                        case OpcaoTela.Triangulo:
                            figura.Add(Tela.umRetangulo());
                            break;
                        case OpcaoTela.Sair:
                            continuar = false;
                            break;
                    }
                }
                catch (TelaException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            } while (continuar);

            if (figura.Count > 0)
            {
                Tela.imprimirResultado(figura);             
            }            
        }

    }
}
