using System;

namespace lab2Space
{
    class Person
    {
        public string _name;
        public string _surname;
        public System.DateTime _datuum;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Date
        {
            get
            {
                return _datuum.Year;
            }
            set
            {
                System.DateTime ChangeDatuun;
                ChangeDatuun = _datuum.AddYears(value);
            }
        }
        public Person()
        {
            _name = "James";
            _surname = "Smith";
            _datuum = DateTime.Now;
        }
        Person(string naming, string surnaming, System.DateTime datuuming)
        {
            _name = naming;
            _surname = surnaming;
            _datuum = datuuming;
        }

        private string ToFullString()
        {
            string fullString;
            fullString = String.Join(Environment.NewLine, Name, Surname, Date)
               ;
            return fullString;
        }
    }
}
