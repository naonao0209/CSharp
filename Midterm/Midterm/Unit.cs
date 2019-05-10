using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Unit
    {

        public int unitNumber { get; set; }
        public double squareFeet { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public bool isFurnished { get; set; }

        public Unit() { }//default constructor
        public Unit(int unitNumber,double squareFeet,int bedrooms,int bathrooms,bool isFurnished) {
           this.unitNumber = unitNumber;
            this.squareFeet = squareFeet;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
            this.isFurnished = isFurnished;
        }//overloaded constructor
        double rent;
            int sale;
        public double rentPrice(double squareFeetPrice)
        {
            rent = squareFeet * squareFeetPrice;
            return rent;
        }
        public int salePrice(double squareFeetPrice)
        {
            sale = Convert.ToInt32(Math.Round(squareFeet * squareFeetPrice));
            return sale;
        }
    public void printUnit()
        {
            string furnished;
            if (isFurnished)
            {
                furnished = "YES";
            }
            else
            {
                furnished = "NO";
            }

            Console.WriteLine(
                $"Unit Number : {unitNumber}\n" +
                $"Squarefeet : {squareFeet}\n" +
                $"Bedrooms : {bedrooms}\n" +
                $"Bathrooms : {bathrooms}\n" +
                $"Furnished : {furnished}\n" +
                $"Rent : {rent}\n" +
                $"Sale : {sale}\n"
                );
            Console.ReadLine();
        }
    }
}
