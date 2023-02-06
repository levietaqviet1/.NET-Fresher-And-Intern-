using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Students
    {
        public int Id { get; set; }

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		///  Contrucstor có tham số truyền vào
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		public Students(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public Students()
		{
		}

		/// <summary>
		/// In dữ liệu
		/// </summary>
		/// <returns></returns>
		public override string? ToString()
		{
			return $"Id: {Id}, Name: {Name}";
		}
	}
}
