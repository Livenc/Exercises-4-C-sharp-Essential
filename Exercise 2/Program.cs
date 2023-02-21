namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler file;
            string fileName = Console.ReadLine();
           if( fileName.EndsWith("txt"))
            {
                file = new TXTHandler();
                Console.WriteLine("txt");
            }else if (fileName.EndsWith("doc"))
            {
                file = new TXTHandler();
                Console.WriteLine("doc");
            }else if (fileName.EndsWith("xml"))
            {
                file = new TXTHandler();
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
            


           // Console.WriteLine(fileName.TakeLast(3).ToString());
            Console.ReadLine();
        }
    }
}