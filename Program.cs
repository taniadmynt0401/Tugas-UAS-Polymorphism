using Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TicketBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Meminta pengguna untuk memilih jenis tiket
            Console.WriteLine("Pilih jenis tiket:");
            Console.WriteLine("1. Tiket Reguler");
            Console.WriteLine("2. Tiket VIP");
            Console.Write("Pilihan: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Membuat objek TicketBooking berdasarkan jenis tiket yang dipilih
            TicketBooking ticketBooking;
            if (choice == 1)
            {
                ticketBooking = new RegularTicket();
            }
            else if (choice == 2)
            {
                ticketBooking = new VipTicket();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. Program berakhir.");
                return;
            }

            // Meminta pengguna untuk memasukkan informasi pemesanan tiket
            Console.Write("Masukkan Nama: ");
            string name = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu Vaksin: ");
            string vaccinationCardNumber = Console.ReadLine();
            Console.Write("Masukkan NIK: ");
            string nik = Console.ReadLine();
            Console.Write("Masukkan Nomor Telepon: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Masukkan Nomor Kartu: ");
            string cardNumber = Console.ReadLine();

            // Mengatur nilai properti menggunakan method polymorphism
            ticketBooking.SetInfo(name, vaccinationCardNumber, nik, phoneNumber, cardNumber);

            // Memanggil method BookTicket untuk memesan tiket
            ticketBooking.BookTicket();
        }
    }
}
