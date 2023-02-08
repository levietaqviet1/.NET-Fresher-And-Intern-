using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2
{
    internal class Manager : IManager
    {
        List<Student> students;

        public Manager()
        {
            students = new List<Student>();
        }

        public void Create()
        {
            Student student = new Student();
            Console.Write("Input Id: ");
            student.Id = int.Parse(Console.ReadLine());
            Console.Write("Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Money");
            student.Money = int.Parse(Console.ReadLine());
            students.Add(student);
        }

        public void Delete()
        {
            Console.Write("Input Id: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (Student item in students)
            {
                if (item.Id == id)
                {
                    count++;
                    students.Remove(item);
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found");
            }
        }

        public void LoadFile(string path)
        { 
            using (StreamReader str = new StreamReader(path))
            {
                try
                {
                string line = str.ReadLine();
                while (line != null)
                {
                    try
                    {
                    Student student = new Student();
                    string[] arr = line.Split('\t');
                    student.Id = int.Parse(arr[0]);
                    student.Name = arr[1];
                    student.Money = int.Parse(arr[2]);
                    Console.WriteLine($"{student.ToString()}");
                    students.Add(student);
                    }
                    catch (Exception)
                    {
                        line = str.ReadLine();
                    }
                        line = str.ReadLine();
                  }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void SaveFile(string path)
        {
            using (StreamWriter stw = new StreamWriter(path))
            {
                try
                {
                foreach (Student item in students)
                {
                     stw.WriteLine(item.ToString());
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void ShowList()
        {
            foreach(Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Update()
        {
            Console.Write("Input Id: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (Student item in students)
            {
                if (item.Id == id)
                {
                    count++;
                    Console.Write("Name:");
                    item.Name = Console.ReadLine();
                    Console.WriteLine("Money");
                    item.Money = int.Parse(Console.ReadLine());
                    break;
                }
            }
            if (count== 0)
            {
                Console.WriteLine("Not found");
            }


        }

        
    }
}
