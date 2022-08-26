using System;
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

            };

            foreach (var item in insturumentsArrays)
            {
                foreach (var props in item.GetType().GetProperties())
                {
                    string val = props.GetValue(item).ToString();
                    Console.WriteLine(val);
                }
            }

            
       
            
            
        }
    }
}
