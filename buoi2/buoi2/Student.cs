using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int money;

        public int Money
        {
            get { return money; }
            set { money = value<0?0:value; }
        }

        public Student()
        {
        }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        } 
        public Student(int id, string name, int money) : this(id, name)
        {
            Money = money < 0 ? 0 : money;
        }

        public Student(string name, int money)
        {
            Name = name;
            Money = money < 0 ? 0 : money;
        }

        public override string? ToString()
        {
            return $"{Id}\t{Name}\t{Money}";
        }
    }
}
