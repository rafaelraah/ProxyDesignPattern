using System;

namespace ProxyDesignPattern
{

    //Este é o meu Proxy Object Class
    public class MathProxy : IMath
    {
        //O objeto real MATH, criado anteriormente.
        private Math math = new Math();
        public double Add(double x, double y)
        {
            return math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return math.Div(x, y);
        }
    }
}
