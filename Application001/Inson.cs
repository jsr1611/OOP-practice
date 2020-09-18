using System;
namespace Application001
{
    public class Inson
    {
        private int _boy; // bo`y
        private int _ogirlik; //og`irlik

        // Bo`y xossasi
        public int Boy
        {
            get { return _boy; }
            set { _boy = value; }
        }

        //Og`irlik xossasi

        public int Ogirlik
        {
            get { return _ogirlik; }
            set { _ogirlik = value; }
        }
        public string Ism
        {
            get; set;
        }
        //1chi konstruktor
        public Inson() { }
        public Inson(int boy, int ogirlik)
        {
            _boy = boy;
            _ogirlik = ogirlik;
        }
    }
}
