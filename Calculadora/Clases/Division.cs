namespace calculadoraFunction
{
    public class Division
    {
        public double divPrimerNumero { get; set; }
        public double divSegundoNumero { get; set; }

        public double divResultado { get; set; }

        public double Dividir()
        {
            divResultado = divPrimerNumero / divSegundoNumero;
            return divResultado;
        }

    }
}