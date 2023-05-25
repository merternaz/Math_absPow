using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
         static void Main(string[] args)
        {
            double sum1=0,sum2=0;

            Console.Write("Kaç adet sayı girilecek ? :");
            int x=Convert.ToInt32(Console.ReadLine());


            for(int i=0;i<x;i++){
                int data=Convert.ToInt32(Console.ReadLine());
                if(data<67){
                    sum1+=(67-data);
                }else{
                    sum2+=Math.Pow((double)Math.Abs(data-67),2);
                }

                Console.WriteLine("Sonuc:"+sum1+" "+sum2);
            }

        }
    }
}