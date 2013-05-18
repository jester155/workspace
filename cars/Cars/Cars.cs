using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Cars
    {
        private string make;
        private string model;
        private string color;
        private int year;

        public Cars()
        {
            this.make = "Lotus";
            this.model = "Elise";
            this.color = "Yellow";
            this.year = 2010;
        }

        public Cars(string make, string model, string color, int year) 
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public string getMake()
        {
            return this.make;
        }

        public string getModel()
        {
            return this.model;
        }

        public string getColor()
        {
            return this.color;
        }

        public int getYear()
        {
            return this.year;
        }
    }
}
