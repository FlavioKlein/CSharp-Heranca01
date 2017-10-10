using System;

namespace curso
{
    class Triangulo: FiguraGeometrica
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangulo (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double area()
        {
            double p;
            p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double perimetro()
        {
            return 0.0;
        }
    }
}
