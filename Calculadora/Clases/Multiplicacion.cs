namespace calculadoraFunction
{
    public class Multiplicacion
    {
        public double mulPrimerNumero { get; set; }
        public double mulSegundoNumero { get; set; }

        public double  mulResultado { get; set; }

        public double Multiplicar()
        {
            mulResultado = mulPrimerNumero * mulSegundoNumero;
            return mulResultado;
        }
    }
}