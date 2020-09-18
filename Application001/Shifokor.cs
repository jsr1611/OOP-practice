using System;
namespace Application001
{
    public class Shifokor : Hodim
    {
        public override void MaoshOlish(float pulMiqdori)
        {
            float mukofot = 1000000F;
            pulMiqdori += mukofot;
            Console.WriteLine(pulMiqdori.ToString() + " sum miqdorida maosh olindi.");

            //base.MaoshOlish(pulMiqdori);
        }
        public int Yonalish { get; set; }
        public Shifokor() { }

    }
}
