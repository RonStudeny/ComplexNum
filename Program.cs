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

            res = num1.AddNums(num2); //scitani priklad
            Console.WriteLine(res.ToString());
            res = num1.SubstractNums(num2); // odcitani priklad
            Console.WriteLine(res.ToString());
            res = num1.MultiplyNums(num2); // nasobeni priklad
            Console.WriteLine(res.ToString()); 
            res = num1.ComplexPair(); // sdruzene cislo pro num1
            Console.WriteLine(res.ToString());
            res = num1.DivNums(num2); // deleni priklad
            Console.WriteLine(res.ToString());
          
        }
    }

    public class ComplexNum
    {
        double Re { get; set; }
        double Im { get; set; }
        public ComplexNum(double reNum, double imNum)
        {
            Re = reNum;
            Im = imNum;
        }

        public ComplexNum AddNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Re, Im);
            
            res.Re = res.Re + input.Re;
            res.Im = res.Im + input.Im;
            return res;
        }

        public ComplexNum SubstractNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Re, Im);

            res.Re -= input.Re;
            res.Im -= input.Im;
            return res;
        }

        public ComplexNum MultiplyNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Re, Im);

            res.Re = (Re * input.Re) - (Im * input.Im);
            res.Im = (Re * input.Im) + (input.Re * Im);
            return res;
        }
        public ComplexNum ComplexPair()
        {
            ComplexNum res = new ComplexNum(Re, Im);

            res.Im = Im * -1;
            return res;
        }

        public ComplexNum DivNums(ComplexNum input)
        {
            ComplexNum res = new ComplexNum(Re, Im);
            ComplexNum pair = input.ComplexPair();
            ComplexNum multiplyResUp = MultiplyNums(pair);
            ComplexNum multiplyResDown = input.MultiplyNums(pair);

            res.Re = multiplyResUp.Re / multiplyResDown.Re;
            res.Im = multiplyResUp.Im/multiplyResDown.Re;
            return res;
        }

        public override string ToString()
        {
            if (Im > 0) return $"{Re} + {Im}i ";
            if (Im < 0) return $"{Re} - {Im * -1}i";
            else return Re.ToString();
        }  
        
    }
}
