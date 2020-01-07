using System.Collections.Generic;
using System;

namespace ShippingParcel.Models
{
    public class Parcel
    {
        private double width;
        private double length;
        private double height;
        private double weight;
        private double price;

        private static List<Parcel> myParcel = new List<Parcel> {};
        public Parcel ()
        {

        }
        public Parcel (double width, double length, double height, double weight)
        {
            this.width = width;
            this.length = length;
            this.height = height;
            this.weight = weight;
            this.price = 0;
            myParcel.Add(this);
        }

        public static List<Parcel> GetAllParcels()
        {
            return myParcel;
        }

        public static void RemoveParcels()
        {
            myParcel.Clear();
        }
        public double GetWidth()
        {
            return this.width;
        }

        public void SetWidth(double new_width)
        {
            this.width = new_width;
        }

        public double GetLength()
        {
            return this.length;
        }

        public void SetLength(double new_length)
        {
            this.length = new_length;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double new_height)
        {
            this.height = new_height;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(double new_weight)
        {
            this.weight = new_weight;
        }

        public string CheckValidation()
        {
            if (this.width < 0 || this.length < 0 || this.height < 0 || this.weight < 0)
            {
                return "Invalid input.";
            }
            else if (this.width == null || this.length == null || this.height == null || this.weight == null)
            {
                return "Fill all the fields.";
            }
            return "Valid input!";
        }

        public double Volume()
        {
            return this.width * this.length * this.height;
        }

        public double CostToShip()
        {
            double dimensions = Volume();
            if (dimensions < 30)
            {
                this.price = 50;
            }
            else if (dimensions >= 30 && dimensions < 60)
            {
                this.price = 100;
            }
            else
            {
                this.price = 150;
            }
            return this.price;
        }

        public double TotalPrice()
        {
            double total = 0;
            for (int index = 0; index < myParcel.Count; index++)
            {
                total += myParcel[index].CostToShip();
            }
            return total;
        }

        public string ToString()
        {
            string output = $"Your package dimension: {this.width} x {this.length} x {this.height} =  {Volume()} ㎤ ";
            return output;
        }
    }
}