using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BenzinovaPumpa
{
    internal class Pocty
    {
        Random r = new Random();
        public void Run ()
        {
            
           
           
            bool proceed = true;
                while (proceed)
            {
               

                string input = Console.ReadLine();
                if (input == "go")
                {
                    int gas = r.Next(15000, 22000);
                    int[] cars = new int[r.Next(15, 20)];
                    for (int i = 0; i < cars.Length; i++)
                    {
                        cars[i] = r.Next(35, 80);
                    }
                    int pocet = 0;
                    Console.WriteLine("počet aut:" + cars.Length);

                    while (gas > 35)
                    {
                        if (gas >=0)
                        {
                            for (int i = 0; i < cars.Length; i++)
                            {
                                if (gas - cars[i] >= 0)
                                {
                                    gas -= cars[i];
                                    pocet++;
                                }
                                else
                                {
                                    proceed = false;
                                }
                            }
                        }
                    }      
                    Console.WriteLine("kolik zbývá benzínu:" + gas);
                    Console.WriteLine("kolik natankuje aut:" + pocet);
                }
            }           
        }
        string b = "ijhgbv";
    }
    //ggggggggggggggggggggggggggggg
  
}