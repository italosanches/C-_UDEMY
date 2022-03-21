namespace AluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos ira alugar?: ");
            int roons = int.Parse(Console.ReadLine());
            Roons[] room = new Roons[10];

            int num = 0;
            for (int i = 0; i < roons; i++)
            {
                num++;
                Console.WriteLine($"Rent #{num}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomLocate = int.Parse(Console.ReadLine());
                room[i] = new Roons(name, email, roomLocate);
            }
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (room[i] != null)
                {
                    Console.WriteLine(room[i].ToString()); 
                }
            }
        }
    }
}
