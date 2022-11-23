
using Parte_1.Entities;

Console.Write("Room Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Checkin Date (dd/MM/yyyy): ");
DateTime checkin = DateTime.Parse(Console.ReadLine());
Console.Write("Checkout Date (dd/MM/yyyy): ");
DateTime checkout = DateTime.Parse(Console.ReadLine());

if (checkout <= checkin)
{
    Console.WriteLine("Error in reservation: Check-out date must be after checkin date");
}
else
{
    Reservation reservation = new Reservation(number, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();

    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Checkin Date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Checkout Date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());

    DateTime now = DateTime.Now;

    if (checkin < now || checkout < now)
    {

        Console.WriteLine("Error in reservation: Reservation dates for update must be future dates ");
    }
    else if(checkout<=checkin){
        Console.WriteLine("Error in reservation: Check-out date must be after checkin date");
    }
    else {
        reservation.UpdateDate(checkin, checkout);

        Console.WriteLine("Reservation: " + reservation);

    }

}

