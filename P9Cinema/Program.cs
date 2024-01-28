string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeats = int.Parse(Console.ReadLine());   

if (typeOfMovie == "Normal")
{
    double totalCountSeats = countOfRows * countOfSeats;
    double totalPrice = totalCountSeats * 7.50;
    Console.WriteLine($"{totalPrice:F2}");
}
 else if (typeOfMovie == "Premiere")
{
    double totalCountSeats = (countOfRows * countOfSeats);
    double totalPrice = totalCountSeats * 12.00;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (typeOfMovie == "Discount") {
    double totalCountSeats = countOfRows * countOfSeats;
    double totalPrice = totalCountSeats * 5.00;
    Console.WriteLine($"{totalPrice:F2}");
}