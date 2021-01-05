using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi = 0.00;

            try
            {
                Console.WriteLine("Boyunuzu giriniz. (Örn: 173)");
                int metre = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kilonuzu giriniz. (Örn: 60)");
                int kg = Convert.ToInt32(Console.ReadLine());
                
                int control  = kg / (metre * metre);
                bmi = (double)kg / (double)(metre * metre);
                Console.WriteLine($"Vücut kitle endeksiniz: { (bmi * 10000).ToString("0.##")}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Kilonuzu kg, boyunuzu cm cinsinden giriniz.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Boyunuz 0 olamaz.");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Bir hata oluştu." + hata.Message );
            }


            bmi *= 10000;
            if(bmi > 0)
            if (bmi <= 18.4){
                Console.WriteLine("Zayıf");
            }
            else if(bmi <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi <= 29.9)
            {
                Console.WriteLine("Fazla Kilolu");
            }
            else if (bmi <= 34.9)
            {
                Console.WriteLine("Şişman (Obez) - I. Sınıf");
            }
            else if (bmi <= 44.9)
            {
                Console.WriteLine("Şişman (Obez) - II. Sınıf");
            }
            else if (bmi >= 45.0)
            {
                Console.WriteLine("Aşırı Şişman (Aşırı Obez) - III. Sınıf");
            }
            Console.ReadLine();
        }
    }
}
