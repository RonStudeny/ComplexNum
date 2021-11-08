using System;

namespace ComplexNum
{
    class Program
    {
        static void Main(string[] args)
        {

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

        public override string ToString()
        {
            string res = $"{Re}  {Im}i ";

            return res;
        }
    }
}
