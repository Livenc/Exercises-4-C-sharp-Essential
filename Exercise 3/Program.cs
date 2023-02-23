namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Chouse player(1) or dictofon(2) :  ");
            int chouse = Convert.ToInt32(Console.ReadLine());
            if (chouse == 1)
            {
                IPlayable playable = new Player();
                playable.Play();
                playable.Pause();
                playable.Stop();


            }else if (chouse == 2) 
            {
                IRecodable playable = new Player();
                playable.Record();
                playable.Pause();
                playable.Stop();
            }
            else
            {
                Console.WriteLine("Miss chouse");
            }
            Console.ReadLine();


        }
    }
}