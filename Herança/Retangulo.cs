namespace curso

{
    class Retangulo : FiguraGeometrica
    {
        public double largura { get; private set; }
        public double comprimento { get; private set; }

        public Retangulo (double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public override double area()
        {
            return largura * comprimento;
        }

        public override double perimetro()
        {
            return 0.0;
        }
    }
}
