using Modificador_de_parametros;

namespace Modificador_de_parametros
{
    class Program {
        static void Main(string[] args) {

            int calcular =  Calculator.Sum( 10, 20, 30 );
            int calc2 = Calculator.Sum( 10, 250, 30,410,48,115,001 );

            Console.WriteLine(calcular);
            Console.WriteLine(calc2);
        }

        

    }
    
}