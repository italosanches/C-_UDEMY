namespace Matrizes
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.Write("Digite as quantidades de linhas e colunas");
            string [] quantidade =Console.ReadLine().Split(" ");
            int l, c = 0;
            l = int.Parse(quantidade[0]);
            c = int.Parse(quantidade[1]);
            double [,] mat = new double[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int loc = int.Parse(Console.ReadLine());
            
            for (int x= 0; x < l; x++)
            {
                for (int y= 0; y < c; y++)
                {
                    if (mat [x,y] == loc)
                    {
                        Console.WriteLine($"Posição{x} {y}");
                        if (y > 0)
                        {
                            Console.WriteLine($"Left {mat[x,y-1]}");
                        }
                        if (y < c - 1)
                        {
                            Console.WriteLine($"Rigth: {mat[x, y + 1]}");
                        }

                        if (x > 0)
                        {
                            Console.WriteLine($"Up: {mat[x-1,y]}");
                        }
                       
                        if(x < l -1 )
                        {
                            Console.WriteLine($"Down: {mat[x + 1, y]}");
                        }

                    }
                }
            }


        }
    }
}