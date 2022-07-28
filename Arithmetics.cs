namespace basics
{
    public class Arithmetics
    {
        public int one {get;set;}
        public int two {get;set;}


        public Arithmetics(int one, int two)
        {
            this.one = one;
            this.two = two;
        }  

        public int Multiply()
        {
            return one * two;
        }

        public int Add()
        {
            return one + two;
        }

        public int Subtract()
        {
            return one - two;
        }

        public int Divide()
        {
            return one / two;
        }

        public int Modulus()
        {
            return one % two;
        }

        public int Power()
        {
            return (int)Math.Pow(one, two);
        }

        public int SquareRoot()
        {
            return (int)Math.Sqrt(one);
        }

        public int Square()
        {
            return one * one;
        }

        public int Cube()
        {
            return one * one * one;
        }
    }
}