using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        static void OnRoomSoldOut(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Sala Lotada");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            SeatsInUser = 0;
        }

        private int SeatsInUser = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            SeatsInUser++;
            if (SeatsInUser >= Seats)
            {
                //Evento fechado!
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Acento Reservado!");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs eventArgs)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, eventArgs);
        }
    }
}