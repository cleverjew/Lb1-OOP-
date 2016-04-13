using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lb1
{
    struct Passenger
    {
        public int Passengers;
        public double Weight;
        public int Item;
        public Passenger(int passenger, double weight, int item)
        {
            Passengers = passenger;
            Weight = weight;
            Item = item;
        }
    }
    class Lab1
    {
        static void Main()
        {
            Passenger[] info = new Passenger[10];
            info[0] = new Passenger(1, 25, 2);
            info[1] = new Passenger(2, 30, 3);
            info[2] = new Passenger(3, 45, 4);
            info[3] = new Passenger(4, 20, 2);
            info[4] = new Passenger(5, 24, 1);
            info[5] = new Passenger(6, 19, 2);
            info[6] = new Passenger(7, 18, 1);
            info[7] = new Passenger(8, 40, 4);
            info[8] = new Passenger(9, 44, 6);
            info[9] = new Passenger(10, 55, 8);
            Console.WriteLine(MoreThenTwo(info));
            Console.WriteLine(MoreThen25(info));
            Console.WriteLine(ExceedAverageItems(info));
            Console.WriteLine(ExceedAverageWeight(info));

        }
        static int MoreThenTwo(Passenger[] ps)
        {
            int more = 0;
            foreach (Passenger items in ps)
            {
                if (items.Item > 2)
                {
                    more++;
                }
            }
            return more;
        }
        static string MoreThen25(Passenger[] ps)
        {
            string mr = "";
            foreach (Passenger wg in ps)
            {
                if (wg.Item == 1 && wg.Weight < 25)
                {
                    mr += wg.Passengers + " ";
                }
            }
            return mr;
        }
        static int ExceedAverageItems(Passenger[] ps)
        {
            double avr = 0;
            int mavr = 0;
            double sum = 0;

            for (int i = 0; i < ps.Length; i++)
            {
                sum += ps[i].Item;
            }
            avr = sum / ps.Length;
            for (int i = 0; i < ps.Length; i++)
            {
                if (ps[i].Item > avr)
                {
                    mavr++;
                }

            }
            return mavr;
        }
        static string ExceedAverageWeight(Passenger[] ps)
        {
            double avr = 0;
            double sum = 0;
            double sum1 = 0;
            string pas = "";
            for (int i = 0; i < ps.Length; i++)
            {
                sum += ps[i].Weight;
            }
            for (int i = 0; i < ps.Length; i++)
            {
                sum1 += ps[i].Item;
            }
            avr = sum / sum1;
            foreach (Passenger wg in ps)
            {
                if (wg.Weight / wg.Item <= avr + 0.5 && wg.Weight / wg.Item >= avr - 0.5)
                {
                    pas += wg.Passengers + " ";
                }
            }
            return pas;
        }
    }
}

