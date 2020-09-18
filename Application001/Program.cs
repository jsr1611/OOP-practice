using System;

namespace Application001
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Inson inson1 = new Inson();
            Inson inson2 = new Inson(170, 70);
            inson1.Boy = 180;
            //Hodim hodim1 = new Hodim(180, 90, 2500);
            //hodim1.Maosh = 3000;
            Shifokor shifokor1 = new Shifokor();
            shifokor1.Tajriba = 7;
            shifokor1.MaoshOlish(5000000F);


            //Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
