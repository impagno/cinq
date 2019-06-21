using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            IFiguraGeometrica quadrado = new Quadrado()
            {
                Lado = 2
            };
            Retangulo retangulo = new Retangulo()
            {
                Lado1 = 2,
                Lado2 = 3
            };
            var p = new Program();

            p.CalculaArea(quadrado);
            p.CalculaArea(retangulo);

            dynamic x = 2;
            x = "abacate";
        }

        void CalculaArea(IFiguraGeometrica f)
        {
            Console.WriteLine($"A area é {f.CalculaArea()}");
        }
    }

    public interface IFiguraGeometrica
    {
        double CalculaArea();
    }

    public class Quadrado : IFiguraGeometrica
    {
        public int Lado { get; set; }

        public double CalculaArea()
        {
            return Lado * Lado;
        }
    }

    class Retangulo : IFiguraGeometrica
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public double CalculaArea()
        {
            return Lado1 * Lado2;
        }
    }

    public abstract class MinhaClasse
    {
        public int Id { get; set; }

        public int RetornaId()
        {
            return this.Id;
        }

        public abstract void ImprimeId();
    };
}
