
namespace Exercicio_Resolvido_01.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; set; }

        public OutsourcedEmployee(string name,int hours,double valuePerHour,double addicionalCharge) :base(name, hours,  valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
            ValueTot = Payment();
        }
        public OutsourcedEmployee() { 
        
        }

        public override double Payment()
        {
            return base.Payment() + (AddicionalCharge * 1.1);
        }

       
    }
}
