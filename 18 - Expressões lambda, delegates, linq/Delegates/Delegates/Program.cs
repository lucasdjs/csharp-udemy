using Delegates.Services;

namespace System
{
    //delegate double BynaryNumericOperation(double n1, double n2);
    delegate void BynaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            BynaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
           
        }
       
    }
}