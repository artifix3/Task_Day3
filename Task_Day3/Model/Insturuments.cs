using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Day3.Model
{
    public abstract class Insturuments
    {
        public string InstrumentName { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Body_Material { get; set; }
        public string Color { get; set; }
        public abstract string Voice();

    }
    public class Piano : Insturuments
    {
        public string Type { get; set; }
        public string PedalType { get; set; }
        public bool ToneCollector { get; set; }
        public string FrameType { get; set; }
        public override string Voice()
        {
            return "Diririn";
        }
    }
    public class Vibraphones : Insturuments
    {

        public string Resonators { get; set; }
        public string Range { get; set; }
        public string PedalType { get; set; }
        public override string Voice()
        {
            return "lololol";
        }
    }
    public class Guitar : Insturuments
    {
        public string Type { get; set; }
        public int NumberOfFrets { get; set; }
        public string Fret_Wire { get; set; }

        public int StringSpacing { get; set; }
        public override string Voice()
        {
            return "Guitar";
        }
    }
    public class Drums : Insturuments
    {
        public string Type { get; set; }
        public int Thickness { get; set; }
        public string Bottom { get; set; }
        public string Top { get; set; }
        public override string Voice()
        {



            return " Drum drum";
        }
    }

}
