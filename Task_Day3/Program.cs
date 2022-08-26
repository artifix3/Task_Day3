using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task_Day3.Model;

namespace Task_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Insturuments[] insturumentsArrays =
           {
                new Piano
                {
                InstrumentName = "C7X",
                Brand = "Yamaha",
                Price = 60.4,
                Height = 40.5,
                Weight = 50,
                Body_Material = "Wood",
                Color = "Black",
                Type = "Grand Piano",
                PedalType = "Shift/Damper",
                ToneCollector = true,
                FrameType = "V-pro Vacuum"
                },
                new Piano
                {
                    InstrumentName = "C6X",
                 Brand = "Yamaha",
                 Price = 100.4,
                 Height = 42.5,
                 Weight = 53,
                 Body_Material = "Wood",
                 Color = "Blue",
                 Type = "Grand Piano",
                 PedalType = "Shift/Sostenuto",
                 ToneCollector = true,
                 FrameType = "Shield Mold"
                },
                new Vibraphones
                {
                    InstrumentName = "YV-4110(M)",
                Brand = "Yamaha",
                Price = 300.4,
                Height = 20.5,
                Weight = 53,
                Body_Material = "Wood/Iron",
                Color = "Yellow",
                Resonators= "Gold finish",
                Range= "4 octaves; C28-C76",
                PedalType= "Swivel"
                },
                new Vibraphones
                {
                InstrumentName = "YV-3910(M)",
                Brand = "Yamaha",
                Price = 290.4,
                Height = 21.5,
                Weight = 53,
                Body_Material = "Wood/Iron",
                Color = "Yellow",
                Resonators = "Gold finish",
                Range = "3.5 octaves; C28-F69",
                PedalType = "oversized"
                },
               
                new Guitar
                {
                    InstrumentName="700 Series",
                    Brand="Yamaha",
                    Price=300.9,
                    Height=7.9,
                    Weight=6,
                    Body_Material="Iron",
                    Color="Blue",
                    Type="Electronic",
                    NumberOfFrets=21,
                    Fret_Wire="Medium",
                    StringSpacing=19,


                },
                   new Guitar
                {
                    InstrumentName="900 Series",
                    Brand="Yamaha",
                    Price=300.9,
                    Height=7.9,
                    Weight=6,
                    Body_Material="Iron",
                    Color="Yellow",
                    Type="Silent",
                    NumberOfFrets=30,
                    Fret_Wire="Medium",
                    StringSpacing=17,


                },
                   new Drums
                   {
                    InstrumentName="PHX",
                    Brand="Yamaha",
                    Price=300.9,
                    Height=7.9,
                    Weight=6,
                    Body_Material="Aluminum",
                    Type="Die-cast",
                    Thickness=11,
                    Bottom="Clear Ambassador",
                    Top="PS3 SW without hole",
                   },
            };


            PrintAllInstruments(insturumentsArrays);
            Console.ReadLine();
        }
        public static void PrintAllInstruments(Insturuments[] insturuments)
        {
            for (int i = 0; i < insturuments.Length; i++)
            {
                var properties = insturuments[i].GetType().GetProperties();
                var methods = insturuments[i].GetType().GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Where(x => !x.IsSpecialName).ToArray();
                Console.WriteLine($"{i + 1}) Instrumental : {insturuments[i].GetType().Name}");
                Console.WriteLine($"**********************************************************\nParameters :");
                for (int j = properties.Length - 1; j >= 0; j--)
                {
                    Console.WriteLine($"      {properties[j].Name} : {properties[j].GetValue(insturuments[i])}");
                }
                Console.WriteLine("Methods :");
                for (int j = 0; j < methods.Length; j++)
                {
                    Console.WriteLine($"      {methods[j].Name} : {methods[j].Invoke(insturuments[i], null)}");
                }
                Console.WriteLine($"\n");

            }
        }
    }
}