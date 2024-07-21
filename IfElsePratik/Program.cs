using System;

namespace IfElseDegiskenler 
{
    class program 
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Sayı Giriniz:");
            int Sayı = Convert.ToInt32 (Console.ReadLine());

            //İlk olarak bir sayı aldım ve sayısal değeri hakkında çıktı verileceğinden int'e dönüştürdüm.

            if (Sayı > 10)
            {
                Console.WriteLine("Girilen Sayı 10'dan Büyüktür.");
            }

            //İlk aşamada sayının 10'dan büyük olma durumunu inceledim.

            else if (Sayı ==10)
            {
                Console.WriteLine("Girilen Sayı 10'dur.");
            }

            //İkinci aşamada sayının 10'a eşit olma durumunu inceledim.

            else
            {
                Console.WriteLine("Girilen Sayı 10'dan Küçüktür.");
            }

            //Son aşamada sayının 10'dan küçük olma durumunu inceledim.


            //Ayrı bir kontrol mekanizması ile girilen sayının çift olup olmadığını kontrol ettim. Bunu 2'ye bölümünden kalanın sıfır olma durumuna göre şartladım.

            if (Sayı % 2 == 0)
            {
                Console.WriteLine("Girilen Sayı Çifttir.");

            }
            else
            {
                Console.WriteLine("Girilen Sayı Tektir.");
            }
            // Son aşamada çalıştırıldığında girilen sayının 10'dan büyük-küçük veya eşit olma durumuna ve çift olma durumuna ilişkin iki adet çıktı alınır hale geldi.
    {
    }
         



        }
    }
}