using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AmwayCenter
{
    //Event is a special keyword in C#, use something else. 
    public class ArenaEvent
    {

        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        //constructor
        public ArenaEvent(int eventID, string eventName, DateTime eventDate)
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventDate = eventDate;
        }

        //blank constructor...needed for the inherited class (BasketballGame)
        public ArenaEvent()
        {
        }

        //create the events
        //static method can be called without an instance of the class. 
        public static List<ArenaEvent> CreateEvents()
        {
            List<ArenaEvent> events = new List<ArenaEvent>();
            events.Add(new ArenaEvent(1, "Beyonce", new DateTime(2012, 4, 15)));
            events.Add(new BasketballGame(2, "Orlando Magic", new DateTime(2012, 5, 23), "Dallas Mavericks"));
            events.Add(new ArenaEvent(3, "Predators Football", new DateTime(2012, 6, 10)));
            return events;
        }

        //static method can be called without an instance of the class. 
        public static void PrintEvents(List<ArenaEvent> events)
        {
            foreach (ArenaEvent arenaEvent in events)
            {
                Console.WriteLine(arenaEvent.EventID + "-" + arenaEvent.EventName);
            }
        }


        //declare virtual so it can be overridden by the BasketballGame class
        public virtual void DisplayEventDetails()
        {
            Console.WriteLine("You picked eventID " + EventID);
            Console.WriteLine("Event Name: " + EventName);
            Console.WriteLine("Event Date: " + EventDate.ToShortDateString());
        }


    }
}


