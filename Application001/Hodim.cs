using System;
namespace Application001
{
    abstract public class Hodim : Inson
    {
        public abstract void MaoshOlish(float pulMiqdori);
        //{
        //    Console.WriteLine(pulMiqdori.ToString() + " sum miqdorida maosh olindi.");
        //}
        private float _maosh;
        public float Maosh
        {
            get { return _maosh; } set { _maosh = value; }
        }
        public Hodim() { }
        public Hodim(int boy, int ogirlik, float maosh)
            :base(boy, ogirlik)
        {
            _maosh = maosh;
            
        }
        public int Tajriba { get; set; }
    }
}
