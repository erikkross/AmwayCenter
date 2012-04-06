using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmwayCenter
{
    public class BasketballGame: ArenaEvent 
    {
        public string Opponent { get; set; }
        public string HalftimeShow { get; set; }


        //constructor
        public BasketballGame(int eventID, string eventName, DateTime eventDate, string opponent)
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventDate = eventDate;
            this.Opponent = opponent;
        }

        //override parent (ArenaEvent) in order to show the opponent field 
        public override void DisplayEventDetails()
        {
            Console.WriteLine("You picked eventID " + EventID);
            Console.WriteLine("Event Name: " + EventName);
            Console.WriteLine("Event Date: " + EventDate.ToShortDateString());
            Console.WriteLine("Opponent: " + Opponent);
        }
    }
}
