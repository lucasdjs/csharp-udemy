
using Parte_1.Entities;



Console.Write("Room Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Checkin Date (dd/MM/yyyy): ");
DateTime checkin = DateTime.Parse(Console.ReadLine());
Console.Write("Checkout Date (dd/MM/yyyy): ");
DateTime checkout = DateTime.Parse(Console.ReadLine());
Reservation reservation = new Reservation(number, checkin, checkout);

string error = reservation.UpdateDate(checkin, checkout);

if (error != null) {

    Console.WriteLine("Error in reservation " + error);
}

else
{
    Console.WriteLine("Reservation: " + reservation);

}

