using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    class CEO : Human , IWorkers
    {
        public string Position { get; set; }
        public double Salary { get; set; }
    }

    class Worker : Human, IWorkers
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public Worker(string name, string surname, int age, string position, double salary, string startTime, string endTime)
        {
            _guid =new Guid();
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
            StartTime = startTime;
            EndTime = endTime;
        }

    }

    class Operation:Empty
    {
        string ProcessName { set; get; }
        
    }
}
