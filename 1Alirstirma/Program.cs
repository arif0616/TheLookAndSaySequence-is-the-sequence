using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Alirstirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int Asayi;
            int Bsayi;
             Console.Write("A-Dizinin adetini girin: ");
             Asayi = int.Parse(Console.ReadLine());
             int[] Anumber = new int[Asayi];
             Console.Write("B-Dizisinin adetini girin: ");
             Bsayi = int.Parse(Console.ReadLine());
             int[] Bnumber = new int[Bsayi];

             for (int i = 0; i < Anumber.Length; i++)
             {
                 Console.Write("A dizisinin sayisni girin: ");
                 Anumber[i] = int.Parse(Console.ReadLine());
             }   
             for (int j = 0; j < Bnumber.Length; j++)
             {
                 Console.Write("B dizisinin saysini girin: ");
                 Bnumber[j] = int.Parse(Console.ReadLine()); 
             }
             for (int k = 0; k < Bnumber.Length; k++)
             {
                int sayac = 0;
                for (int s = 0; s < k; s++)
                {
                    if (Bnumber[k] == Bnumber[s]) 
                    {
                        sayac = -1;
                    }
                }
                if (sayac != -1)
                {
                    for (int m = 0; m < Anumber.Length; m++)
                    {

                        if (Bnumber[k] == Anumber[m])
                        {
                            sayac++;

                        }

                    }
                }                
                Console.WriteLine("B[{0}]=>{1}",k,sayac);
             }
             Console.ReadLine();
        }
    }
}