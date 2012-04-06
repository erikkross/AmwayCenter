using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmwayCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketnumber;
            int input;

            //create a list of events that will be used throughout the rest of this application. 
            List<ArenaEvent> events = ArenaEvent.CreateEvents();
            
            //print out the event list. 
            ArenaEvent.PrintEvents(events);

            //infinite loop 
            while (true)
            {
                Console.WriteLine("Pick an event from the list above");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    //if the user enters a number less than or equal to 0 and greater then the event count, then they did not enter a valid value. 
                    if (input <= 0 || input > events.Count)
                    {
                        Console.WriteLine("Please select a valid event number");
                    }
                    else
                    {
                        //they entered 1, 2 or 3. continue app
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Value you entered is not a number...try again");
                }
            } //end while loop


            //create new event based on the one the user selected
            //use a lambda expression to find the event in the event list that matches the EventID the user inputted
            ArenaEvent eventSelected = events.Find(e => e.EventID == input);
            eventSelected.DisplayEventDetails();

 


            //myEvent.getEventDetails(input);


            //Console.WriteLine("continuing");

            //Console.WriteLine("Pick an event");


            

          

            //if (input == 0)
            //{
            //    Console.WriteLine("You picked the Beyonce Concert");
            //}
           

            //Console.WriteLine("How many tickets you want");
            //ticketnumber = Console.ReadLine();

            //myEvent.tickets(ticketnumber);
        }

        
    }
}

