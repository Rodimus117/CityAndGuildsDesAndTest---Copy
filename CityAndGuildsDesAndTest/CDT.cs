﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CityAndGuildsDesAndTest
{
    public class Course
    {
        private string courseName;
        private string date;
        private string price;
        private string seats;
        private int element;

        public Course(string courseName, string date, string price, string seats, int element)
        {
            this.courseName = courseName;
            this.date = date;
            this.price = price;
            this.seats = seats;
            this.element = element;
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Seats
        {
            get { return seats; }
            set { seats = value; }

        }

        public int Element
        {
            get { return element; }
            set { element = value; }
        }
    }

   
}

