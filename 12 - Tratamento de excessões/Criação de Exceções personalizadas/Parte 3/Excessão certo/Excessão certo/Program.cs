
using Excessão_certo.Entities.Exceptions;
using Parte_1.Entities;

try
{

    Console.Write("Room Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Checkin Date (dd/MM/yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Checkout Date (dd/MM/yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());


    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Checkin Date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Checkout Date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDate(checkin, checkout);


    Console.WriteLine("Reservation: " + reservation);
}

catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);

}
catch(FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);

}
catch (Exception e) {
    Console.WriteLine("Unexpected erro: " + e.Message) ;
}


