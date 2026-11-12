namespace GyakorloMasodikFeladat
{
    internal class Program
    {
        static int[] elemek = new int[10];
        static Random r = new Random();

        static void Feltolto(int mini,  int maxi)
        {
            int randomom;
            for (int i = 0; i < elemek.Length; i++)
            {
                do
                {
                    randomom = r.Next(mini, maxi + 1);
                } while (elemek.Contains(randomom));
                elemek[i] = randomom;

            }
        }



        static void Main(string[] args)
        {
            int mini;
            int maxi;
            do
            {
                Console.Write("A 10 tagu tömböt feltöltő random számoknak mi legyen\n a minimuma?");
                mini = Convert.ToInt32(Console.ReadLine()!);
                Console.Write("\n és a maximuma");
                maxi = Convert.ToInt32(Console.ReadLine()!);
            } while (mini + 9 > maxi);
            Feltolto(mini, maxi);
            foreach (var item in elemek)
            {
                Console.WriteLine(item);
            }

        }
    }
}
