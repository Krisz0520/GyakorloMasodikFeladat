namespace GyakorloMasodikFeladat
{
    internal class Program
    {
        static int[] elemek = new int[10];
        static Random r = new Random();
        static void Kiiro()
        {
            foreach (var item in elemek)
            {
                Console.WriteLine(item);
            }
        }
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
        static void LeghosszabNovekvo()
        {
            int leghosszab = 0;
            int mostani = 0;
            int leghossazbindex=0;
            for (int i = 1; i < elemek.Length; i++)
            {

                if (elemek[i - 1] < elemek[i])
                {
                    mostani++;
                    if (mostani >= leghosszab)
                    {
                        leghosszab++;
                        leghossazbindex = i;
                        Console.WriteLine($"leghosszab{leghosszab} leghosszabindex{leghossazbindex}");
                    }
                    
                }
                else
                {
                    mostani = 0;
                } 
            }
            int[] tomb = new int[leghosszab];
            int startindex = leghossazbindex - leghosszab+1;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = elemek[startindex+i];
            }
            Console.WriteLine("__");
            foreach (var item in tomb)
            {
                Console.WriteLine(item);
            }
        }
        static void AtlagAlattiDuplazas()
        {
            int sum = 0;
            for (int i = 0; i < elemek.Length; i++)
            {
                sum += elemek[i];
            }
            double sumdb = Convert.ToDouble(sum);
            double avg = sumdb / elemek.Length;
            int avgint = Convert.ToInt32(Math.Floor(avg));
            for (int i = 0; i < elemek.Length; i++)
            {
                if (elemek[i] <= avgint)
                {
                    elemek[i]*=2;
                }
                
                
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
            Kiiro();
            LeghosszabNovekvo();
            AtlagAlattiDuplazas();
            Console.WriteLine("---");
            Kiiro();
            

        }
    }
}
