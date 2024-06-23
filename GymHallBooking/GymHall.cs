using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GymHallBooking
{
    public class GymHall
    {
        Dictionary<int, Booking > _bookings = new Dictionary<int, Booking>();
        public int ID { get; set; }         //ID på gymnastiksal , som skal være unik
        public string Name { get; set; }    // Det gymnastiksalen kaldes på lokationen – f.eks. ”Den lille gymnastiksal”
        public string Address { get; set; } //Hele adressen på gymnastiksalens lokation
        public string Phone { get; set; }   //Telefon nummer med landekode – kan anvendes til spørgsmål vedr.booking
        public string Email { get; set; }   //E-mail – kan anvendes til spørgsmål vedr.booking

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address}, Phone: {Phone}, E-Mail: {Email}";
        }

        public void RegisterBooking(Booking booking) //metoden på klassen GymHall.Metoden skal tilføje booking.
        {
            _bookings.Add(booking.ID, booking);
        }

        public void PrintBookings()
        {
            foreach (Booking b in _bookings.Values)
            {
                Console.WriteLine(b);
            }
        }

        public void RemoveBooking(Booking booking)
        {
            _bookings.Remove(booking.ID);
        }

        public int TotalBookings
        {
            get { return _bookings.Count; }
        }

        public bool Validate()
        {
            foreach(Booking b in _bookings.Values)
            {
                if (!b.BookingDurationOK)
                {
                    //Opgave 7:
                    //Console.WriteLine("Booking exceeds max. duration");
                    //return false;

                    //Opgave 8:
                    throw new Exception("Booking exceeds max. duration");
                }

                if (b.End < b.Start)
                {
                    //Opgave 7:
                    //Console.WriteLine("End must be after Start");
                    //return false;

                    //Opgave 8:
                    throw new Exception("End must be after Start");
                }

                if (b.Participants > 22)
                {
                    //Opgave 7:
                    //Console.WriteLine("Number of participants is NOT allowed to exceed 22");
                    //return false;

                    //Opgave 8:
                    throw new Exception("Number of participants is NOT allowed to exceed 22");
                }
            }
            return true;
        }

        public TimeSpan TotalTimeBooked
        {
            get 
            { 
                TimeSpan result = new TimeSpan();
                
                foreach (Booking b in _bookings.Values)
                {
                    TimeSpan dif = b.End - b.Start;
                    result += dif;
                }

                return result;
            }
        }

    }
}
