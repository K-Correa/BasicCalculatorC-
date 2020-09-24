namespace calculadoraFunction
{
    public class Resta
    {
        public double PrimerNumeroRes { get; set; }
        public double SegundoNumeroRes { get; set; }

        public double ResultadoRes { get; set; }

        public double Restar()
        {
            ResultadoRes = PrimerNumeroRes - SegundoNumeroRes;
            return ResultadoRes;
        }
    }
}