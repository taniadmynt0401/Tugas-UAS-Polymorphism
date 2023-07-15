using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class TicketBooking
    {
        protected string name;
        protected string vaccinationCardNumber;
        protected string nik;
        protected string phoneNumber;
        protected string cardNumber;

        public void SetInfo(string name, string vaccinationCardNumber, string nik, string phoneNumber, string cardNumber)
        {
            this.name = name;
            this.vaccinationCardNumber = vaccinationCardNumber;
            this.nik = nik;
            this.phoneNumber = phoneNumber;
            this.cardNumber = cardNumber;
        }

        public abstract void BookTicket();
    }
    class RegularTicket : TicketBooking
    {
        public override void BookTicket()
        {
            Console.WriteLine("Tiket Reguler berhasil dipesan untuk:");
            Console.WriteLine("Nama: " + name);
            Console.WriteLine("Nomor Kartu Vaksin: " + vaccinationCardNumber);
            Console.WriteLine("NIK: " + nik);
            Console.WriteLine("Nomor Telepon: " + phoneNumber);
            Console.WriteLine("Nomor Kartu: " + cardNumber);
        }
    }
    class VipTicket : TicketBooking
    {
        public override void BookTicket()
        {
            Console.WriteLine("Tiket VIP berhasil dipesan untuk:");
            Console.WriteLine("Nama: " + name);
            Console.WriteLine("Nomor Kartu Vaksin: " + vaccinationCardNumber);
            Console.WriteLine("NIK: " + nik);
            Console.WriteLine("Nomor Telepon: " + phoneNumber);
            Console.WriteLine("Nomor Kartu: " + cardNumber);
        }
    }
}



