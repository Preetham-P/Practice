using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seatingarray
{
    class Seat
    {
        public int RowId { get; set; }
        public int ColId { get; set; }
        public int Number { get; set; }
        public SeatType  SeatType { get; set; }
    }
    public enum SeatType
    {
        dabba,
        Aisle, 
        Window, 
        Middle
    }

    public class exaample
    {
        public void method()
        {
            int count = 1;
            int colcount = 1;
            List<Seat> seatList = new List<Seat>();
            int row1 = 5, row2=3,row3=6,row4=4;
            
            int col1=4,col2=4,col3=4,col4=3;

            for (int i = 1; i <=6; i++)
            {
                for (int j = 1; j <=15; j++)
                {
                    Seat s = new Seat();
                    s.RowId = i;
                    s.ColId = j;

                    if ((i > row1 && j <= col1) || (i > row2 && j <= col1 + col2) || (i > row3 && j <= col1 + col2 + col3))
                    {
                        s.SeatType = SeatType.dabba;
                    }

                    else if (j == 1 || j == 15)
                    {
                        s.SeatType = SeatType.Window;

                    }


                    else if (j == col1 || j == col1 + 1 || j == col1 + col2 || j == col1 + col2 + 1 || j == col1 + col2 + col3 || j == col1 + col2 + col3 + 1)
                    {

                        s.SeatType = SeatType.Aisle;


                    }

                    else
                    {
                        s.SeatType = SeatType.Middle;


                    }

                    seatList.Add(s);
                    colcount++;
                }
            }


            var aisleseats = seatList.Where(x => x.SeatType == SeatType.Aisle).ToList();
            foreach (var item in aisleseats)
            {
                item.Number = count++;
                
            }

            foreach (var item in aisleseats)
            {
                Console.WriteLine(item.RowId + " " + item.ColId + " " + item.Number + " " + item.SeatType.ToString());
            }



            var windowSeats = seatList.Where(x => x.SeatType == SeatType.Window).ToList();
            foreach (var item in windowSeats)
            {
                item.Number = count++;

            }
            foreach (var item in windowSeats)
            {
                Console.WriteLine(item.RowId + " " + item.ColId + " " + item.Number + " " + item.SeatType.ToString());
            }

            var middleSeats = seatList.Where(x => x.SeatType == SeatType.Middle).ToList();
            foreach (var item in middleSeats)
            {
                item.Number = count++;

            }
            foreach (var item in middleSeats)
            {
                Console.WriteLine(item.RowId + " " + item.ColId + " " + item.Number + " " + item.SeatType.ToString());
            }


        }
    }
}
