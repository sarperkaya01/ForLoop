using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz :");
            int sayac = int.Parse(Console.ReadLine());
            int tekToplam=0;
            int ciftToplam=0;
            for(int i = 0;i<sayac;i++){
                if(i%2==1){
                    Console.WriteLine(i);//1den n e kadar olan sayılar
                }
            }
            for (int i = 0;i<sayac;i++){
                if(i%2==1){
                    tekToplam+=i;

                }
                else{
                    ciftToplam+=i;
                }
            }
            Console.WriteLine("Çift sayıların toplamı :"+ciftToplam);
            Console.WriteLine("Tek Sayıların Toplamı :"+tekToplam); 
            //Break komutuyla döngü kırılıyor
            //Continue komutuyla döngü içerisinde kısıt değer geldiği zaman ilgili değeri atlayıp döngüye devam eder
        }
    }
}
