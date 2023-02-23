namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler file;
            Console.Write("input file name :");
            string fileName = Console.ReadLine();
            if (fileName.EndsWith("txt"))
            {
                file = new TXTHandler();
                Console.WriteLine("txt");
            }
            else if (fileName.EndsWith("doc"))
            {
                file = new DOCHandler();
                Console.WriteLine("doc");
            }
            else if (fileName.EndsWith("xml"))
            {
                file = new XMLHandler();
                Console.WriteLine("xml");
            }
            else
            {

                file = null;
                Console.WriteLine("Not join");
            }
            if (file != null)
            {
                file.Open();
                file.Change();
                file.Save();
            }



        }
    }
}