using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceFile
{
    public class myCollection 
    {
        virtual public void createException()
        {
            var s1 = " \n\n\t\tAkustyka to dział fizyki i techniki obejmujący zjawiska\n \t\tzwiązane z powstawaniem, propagacją i oddziaływaniem\n \t\tfal akustycznych. Ze względu na różnorodność działów\n \t\takustyka jest obecnie traktowana jako nauka\n \t\tinterdyscyplinarna obejmująca oprócz akustyki ogólnej,\n \t\tzajmującej się zagadnieniami podstawowymi,\n \t\trównież szereg działów akustyki stosowanej,\n \t\tzajmujących się praktycznym zastosowaniem zjawisk\n \t\takustycznych.";
          
            try
            {
               
                s1 = s1.Replace("ą", "a");
                s1 = s1.Replace("ć", "c");
                s1 = s1.Replace("ę", "e");
                s1 = s1.Replace("ł", "l");
                s1 = s1.Replace("ń", "n");
                s1 = s1.Replace("ś", "s");
                s1 = s1.Replace("ó", "o");
                s1 = s1.Replace("ż", "z");
                s1 = s1.Replace("ź", "z");
            }
            catch
            {
                Console.WriteLine("Proba zamiany nie powiodla sie.");
            }
         //kolekcje
            var salmons = new List<string>();
            salmons.Add("\n\nText do zamiany:\n");
            salmons.Add("\n\t\tAkustyka to dział fizyki i techniki obejmujący zjawiska\n \t\tzwiązane z powstawaniem, propagacją i oddziaływaniem\n \t\tfal akustycznych. Ze względu na różnorodność działów\n \t\takustyka jest obecnie traktowana jako nauka\n \t\tinterdyscyplinarna obejmująca oprócz akustyki ogólnej,\n \t\tzajmującej się zagadnieniami podstawowymi,\n \t\trównież szereg działów akustyki stosowanej,\n \t\tzajmujących się praktycznym zastosowaniem zjawisk\n \t\takustycznych.");
            salmons.Add("\n\nText po zamianie:\n");
            salmons.Add(s1);
            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }    
    }
}
