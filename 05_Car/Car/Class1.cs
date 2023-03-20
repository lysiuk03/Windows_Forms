using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    [Serializable]
    public class Cars
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Probig { get; set; }
        public double Volume { get; set; }
        public Cars(string model, int year, string color, int probig, double volume)
        {
            Model = model;
            Year = year;
            Color = color;
            Probig = probig;
            Volume = volume;
        }
        public string AllInfo()
        {
            return $" ----------Car----------\n Model: {Model}\n Year: {Year}\n Color: {Color}\n Probig: {Probig}\n Volume: {Volume}";
        }
        public override string ToString()
        {
            return $"\t{Model} — {Year} — {Probig} km ";
        }
    }
}
