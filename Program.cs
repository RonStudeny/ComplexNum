using System;

namespace ComplexNum
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum num1 = new ComplexNum(3,4);
            ComplexNum num2 = new ComplexNum(8,6);

            ComplexNum res;

            res = num1.AddNums(num2);
            Console.WriteLine(res.ToString());
        }
    }

    public class ComplexNum
    {
        int Im { get; set; }
        int Re { get; set; }
        public ComplexNum(int imNum, int reNum)
        {
            Im = imNum;
            Re = reNum;
        }

        public ComplexNum AddNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Im, Re);
            
            res.Re += input.Re;
            res.Im += input.Im;
            return res;
        }

        public ComplexNum SubstractNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Im, Re);

            res.Re -= input.Re;
            res.Im -= input.Im;
            return res;
        }

        public ComplexNum MultiplyNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Im, Re);

            res.Re = (Re * input.Re) - (Im * input.Im);
            res.Im = (Re * input.Im) + (Re * input.Im + input.Re * Im);
            return res;
        }
        public ComplexNum ComplexPair(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Im, Re);

            res.Im = Im * -1;
            return res;
        }

        public ComplexNum DivNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Im, Re);
            ComplexNum pair = res.ComplexPair(input);
            ComplexNum multiplyResUp = MultiplyNums(pair);
            ComplexNum multiplyResDown = input.MultiplyNums(pair);

            res.Re = multiplyResUp.Re / multiplyResDown.Re;
            res.Im = multiplyResUp.Im/multiplyResDown.Im;
            return res;
        }

        public override string ToString()
        {
            string res;
            if (Im > 0) res = $"{Re} + {Im}i ";
            if (Im < 0) res = $"{Re} - {Im * -1}i";
            else res = Re.ToString();
            return res;
        }
    }
}
