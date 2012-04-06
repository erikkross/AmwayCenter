using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AmwayCenter
{
    class Tickets
    {
        int[] seats = new int[20000];  //seats is a 20000 array
        int count = 0;

        public void tickets(string tic)
        {
            int parse;

            parse = int.Parse(tic);

            try
            {
                count += 1;
                seats[count] = 1;

                Console.WriteLine("Your seat was successfully purchased");
                {
                    Exception up = new Exception("I am sorry this event is full, there are no more available seats");
                    throw up;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}

    