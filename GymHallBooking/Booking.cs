using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymHallBooking
{
    public class Booking
    {
        public int ID { get; set; }           //Booking ID, som skal være unik - f.eks. 101
        public DateTime Start { get; set; }   //Start på booking - f.eks. 21-06-2024 14:00
        public DateTime End { get; set; }     //Slut på booking -  f.eks. 21-06-2024 16:00
        public int Participants { get; set; } //Antal deltagere på bookningen

        public override string ToString()
        {
            return $"ID: {ID}, Start: {Start}, End: {End}, Participants: {Participants}";
        }

        public bool BookingDurationOK
        {
            get { return Start.AddHours(2) >= End; }
        }

        public bool IsSundayBooking
        {
            get { return Start.DayOfWeek == DayOfWeek.Sunday; }
        }
    }
}
