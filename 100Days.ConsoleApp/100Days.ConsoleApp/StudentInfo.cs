namespace _100Days.ConsoleApp
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

        public string _name;

        public string Name
        {
            get
            {
                return _name; 
            }
        }
        public int Age { get; set; }
        public int _age;
        public int Ages
        {
            get
            {
                return Age;
            }
            set
            {
                _age = value;
            }

        }
    }

}