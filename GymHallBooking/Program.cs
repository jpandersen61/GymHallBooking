namespace GymHallBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 2. Opret Klassen Booking");
            Booking b1 = new Booking()
            {
                ID = 1,
                Start = new DateTime(2024, 6, 21, 14, 0, 0), //Start på booking - f.eks. 21 - 06 - 2024 14:00:00
                End = new DateTime(2024, 6, 21, 16, 0, 0),   //Slut på booking  - f.eks. 21 - 06 - 2024 16:00:00
                Participants = 15
            };

            Booking b2 = new Booking()
            {
                ID = 2,
                Start = new DateTime(2024, 7, 23, 12, 0, 0), //Start på booking - f.eks. 23 - 07 - 2024 12:00:00
                End = new DateTime(2024, 7, 23, 13, 0, 0),   //Slut på booking  - f.eks. 23 - 07 - 2024 13:00:00
                Participants = 15
            };

            Booking b3 = new Booking()
            {
                ID = 3,
                Start = new DateTime(2024, 6, 11, 10, 0, 0), //Start på booking - f.eks. 11 - 06 - 2024 10:00:00
                End = new DateTime(2024, 6, 11, 13, 0, 0),   //Slut på booking  - f.eks. 11 - 06 - 2024 13:00:00
                Participants = 15
            };

            Booking bookingSunday = new Booking()
            {
                ID = 4,
                Start = new DateTime(2024, 6, 23, 12, 0, 0), //Start på booking - f.eks. 23 - 06 - 2024 12:00:00
                End = new DateTime(2024, 6, 23, 13, 0, 0),   //Slut på booking  - f.eks. 23 - 06 - 2024 13:00:00
                Participants = 10
            };

            Console.WriteLine(b1);
            Console.WriteLine(b2);

            Console.WriteLine();
            Console.WriteLine("Opgave 3. Opret Klassen GymHall.");
            GymHall gh1 = new GymHall()
            {
                ID = 1,
                Address = "Maglegaardsvej 2, 4000 Roskilde",
                Name = "Fitnessrummet",
                Email = "roskilde@zealand.dk",
                Phone = "12345678"
            };

            GymHall gh2 = new GymHall()
            {
                ID = 2,
                Address = "Maglegaardsvej 2, 4000 Roskilde",
                Name = "De lille Fitnessrum",
                Email = "roskilde@zealand.dk",
                Phone = "12345678"
            };

            Console.WriteLine(gh1);
            Console.WriteLine(gh2);

            Console.WriteLine();
            Console.WriteLine("Opgave 4: Opret CRUD metoder på klassen GymHall");
            gh1.RegisterBooking(b1);
            gh1.RegisterBooking(b2);

            gh1.PrintBookings();

            gh1.RemoveBooking(b1);

            gh1.PrintBookings();

            gh1.RegisterBooking(b1);

            Console.WriteLine();
            Console.WriteLine("6. Beregninger");
            Console.WriteLine($"Duration OK: {b1.BookingDurationOK}, Sunday booking: {b1.IsSundayBooking}");
            Console.WriteLine($"Duration OK: {b2.BookingDurationOK}, Sunday booking: {b2.IsSundayBooking}");
            Console.WriteLine($"Duration OK: {b3.BookingDurationOK}, Sunday booking: {b3.IsSundayBooking}");
            Console.WriteLine($"Duration OK: {bookingSunday.BookingDurationOK}, Sunday booking: {bookingSunday.IsSundayBooking}");
            Console.WriteLine($"Total antal bookninger: {gh1.TotalBookings}");

            Console.WriteLine();
            Console.WriteLine("Opgave 7: Validerings funktioner & Opgave 8: Exception handling");
            

            Console.WriteLine();
            Console.WriteLine(gh1);
            gh1.PrintBookings();
            Console.WriteLine($"Gym hall has only valid bookings :{gh1.Validate()}");

            Console.WriteLine();
            Console.WriteLine(gh2);
            gh2.PrintBookings();
            Console.WriteLine($"Gym hall has only valid bookings: {gh2.Validate()}");

            Booking bookingTooLong =  new Booking()
            {
                ID = 5,
                Start = new DateTime(2024, 6, 23, 12, 0, 0), //Start på booking - f.eks. 23 - 06 - 2024 12:00:00
                End = new DateTime(2024, 6, 23, 15, 0, 0),   //Slut på booking  - f.eks. 23 - 06 - 2024 15:00:00
                Participants = 10
            };

            Booking bookingEndBeforeStart = new Booking()
            {
                ID = 6,
                End = new DateTime(2024, 6, 23, 12, 0, 0), //Start på booking - f.eks. 23 - 06 - 2024 12:00:00
                Start = new DateTime(2024, 6, 23, 13, 0, 0),   //Slut på booking  - f.eks. 23 - 06 - 2024 13:00:00
                Participants = 10
            };

            Booking bookingMoreThan22 = new Booking()
            {
                ID = 7,
                Start = new DateTime(2024, 6, 23, 12, 0, 0), //Start på booking - f.eks. 23 - 06 - 2024 12:00:00
                End = new DateTime(2024, 6, 23, 13, 0, 0),   //Slut på booking  - f.eks. 23 - 06 - 2024 13:00:00
                Participants = 23
            };

            Console.WriteLine();
            gh2.RegisterBooking(bookingTooLong);
            Console.WriteLine(gh2);
            gh2.PrintBookings();

            //Opgave 7:
            //Console.WriteLine($"Gym hall has only valid bookings: {gh2.Validate()}");
            
            //Opgave 8:
            try
            {
                gh2.Validate();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            
            gh2.RemoveBooking(bookingTooLong);

            Console.WriteLine();
            gh2.RegisterBooking(bookingEndBeforeStart);
            Console.WriteLine(gh2);
            gh2.PrintBookings();
            
            //Opgave 7:
            //Console.WriteLine($"Gym hall has only valid bookings: {gh2.Validate()}");

            //Opgave 8:
            try
            {
                gh2.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            gh2.RemoveBooking(bookingEndBeforeStart);

            Console.WriteLine();
            gh2.RegisterBooking(bookingMoreThan22);
            Console.WriteLine(gh2);
            gh2.PrintBookings();

            //Opgave 7:
            //Console.WriteLine($"Gym hall has only valid bookings: {gh2.Validate()}");

            //Opgave 8:
            try
            {
                gh2.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            gh2.RemoveBooking(bookingMoreThan22);

            Console.WriteLine();
            Console.WriteLine("Opgave 11. Mere beregning");
            
            Console.WriteLine($"Total tid booked: {gh1.TotalTimeBooked}");
            Console.WriteLine($"Total tid booked: {gh2.TotalTimeBooked}");


        }
    }
}
