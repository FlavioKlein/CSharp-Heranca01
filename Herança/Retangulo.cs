namespace curso

{
    class Retangulo : IFiguraGeometrica
    {
        public double largura { get; private set; }
        public double comprimento { get; private set; }

        public Retangulo (double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public double area()
        {
            return largura * comprimento;
        }

        public double perimetro()
        {
            return 0.0;
        }
    }
}
