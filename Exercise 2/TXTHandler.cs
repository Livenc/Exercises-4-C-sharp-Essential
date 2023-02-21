using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT file");
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT file");
        }
        public override void Change()
        {
            Console.WriteLine("Change TXT file");
        }
        public override void Save()
        {
            Console.WriteLine("Save TXT file");
        }
    }
}
