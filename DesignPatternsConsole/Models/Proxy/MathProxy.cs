namespace DesignPatternsConsole.Models.Proxy
{
    public class MathProxy : IMath
    {
        private readonly Math _math = new Math();

        public double Add(double x, double y) => _math.Add(x, y);
        public double Sub(double x, double y) => _math.Sub(x, y);
        public double Mul(double x, double y) => _math.Mul(x, y);
        public double Div(double x, double y) => _math.Div(x, y);
    }
}
