using System;

namespace Tanımlama__Erişim_ve_Döngülerle_Dizi_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler= new string[5];

            string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi=new int[5];

            //Dizilere değer atama ve erişim

            renkler[0]="Mavi";
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int[] sayıDizisi=new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
               Console.Write("Lütfen {0}. sayıyı giriniz",i+1);
               sayıDizisi[i]=int.Parse(Console.ReadLine());
            }
            
            int toplam=0;
            foreach (var item in sayıDizisi)
            {
                toplam=toplam+item;
            }
            Console.WriteLine("Ortalama : " + toplam/diziuzunlugu);


        }
    }
}
