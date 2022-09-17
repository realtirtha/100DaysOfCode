﻿namespace _100Days.ConsoleApp
{
    public class StudentInfo
    {
        public StudentInfo()
        {
            _name = "Babu";
        }
        public StudentInfo(string name)
        {
            _name = name;
        }

        public StudentInfo(double min, double max, double pass)
        {
            _min = min;
            _max = max; 
            _pass = pass;
        }

        public string _name;

        public string Name
        {
            get
            {
                return _name; 
            }
            set
            {
                _name = value;
            }
        }
        //public int Age { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 100)
                {
                    _age = 100;
                }
                else if (value < 5)
                {
                    _age = 5;
                }
                else 
                    _age = value;
            }

        }


        private double _min = 0;
        private double _max = 100;
        private double _pass = 32;

        private double _math;
        public double Math
        {
            get { return _math; }
            set
            {
                if (value > _max)
                {
                    _math = _max;
                } 
                else if (value < _min)
                {
                    _math = _min;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private double _science;
        public double Science
        {
            get { return _science; }
            set
            {
                if (value > _max)
                {
                    _science = _max;
                }
                else if (value < _min)
                {
                    _science = _min;
                }
                else
                {
                    _science = value; 
                }
            }
        }

        public double Total
        {
            get
            {
                return Math + Science;
            }
        }

        public double Percentage
        {
            get
            {
                return Total/(2*_max) / 100;
            }
        }

        public string Division
        {
            get
            {
                var div = "";
                if (Percentage >= 80) div = "Distinction";
                else if (Percentage >= 60) div = "First Division";
                else if (Percentage >= 45) div = "Second Division";
                else if (Percentage >= 32) div = "Third Division";
                else div = "Failed";
                return div;
            }
        }
    }

}