using System;

namespace QuadrantFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TastEngles.QuadrantFinder(-1, 1, -2, 2));
        }
    }
    public enum Quadrants
    {
        First,
        Second,
        Third,
        Forth,
        Zero,
        Nintie,
        HandretEighty,
        TwoHandretSevanty,
        Null
    }
    public class TastEngles
    {
        
        public static Quadrants QuadrantFinder(int x0, int y0, int x1, int y1)
        {
            Quadrants[] xQ = new[] { Quadrants.Null, Quadrants.Null };
            Quadrants[] yQ = new[] { Quadrants.Null, Quadrants.Null };
            if (x1 > x0) { xQ[0] = Quadrants.Second; xQ[1] = Quadrants.Third; }
            else if (x1 < x0) { xQ[0] = Quadrants.First; xQ[1] = Quadrants.Forth; }
            if (y1 > y0) { yQ[0] = Quadrants.Third; yQ[1] = Quadrants.Forth; }
            else if (y1 < y0) { yQ[0] = Quadrants.First; yQ[1] = Quadrants.Second; }
            if (y1 == y0)
            {
                if (x0 < x1) return Quadrants.HandretEighty;
                if (x0 > x1) return Quadrants.Zero;
            }
            if (x1 == x0)
            {
                if (y1 > y0) return Quadrants.TwoHandretSevanty;
                if (y1 < y0) return Quadrants.Nintie;
            }
            if (y1 == y0) ;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    if (xQ[i] == yQ[j])
                        return xQ[i];
            return Quadrants.Null;
        }

    }
}
