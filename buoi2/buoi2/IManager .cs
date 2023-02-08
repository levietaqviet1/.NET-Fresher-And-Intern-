using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2
{
    internal interface IManager
    {
        public void LoadFile(string path);
        public void SaveFile(string path);
        public void ShowList();
        public void Update();
        public void Delete();
        public void Create();

    }
}
