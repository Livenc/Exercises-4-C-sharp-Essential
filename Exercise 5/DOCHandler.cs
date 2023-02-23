using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC file");
        }
        public override void Create()
        {
            Console.WriteLine("Create DOC file");
        }
        public override  void Change()
        {
            Console.WriteLine("Change DOC file");
        }
        public override  void Save()
        {
            Console.WriteLine("Save DOC file");
        }
    }
}
