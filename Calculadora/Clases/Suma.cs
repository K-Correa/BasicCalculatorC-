namespace calculadoraFunction
{
    public class Suma
    {
        public double PrimerNumeroSum { get; set; }
        public double SegundoNumeroSum { get; set; }
        public double ResultadoSum { get; set; }   


        public double Sumar()
        {
            ResultadoSum = PrimerNumeroSum + SegundoNumeroSum;
            return ResultadoSum;
        }
    }
}