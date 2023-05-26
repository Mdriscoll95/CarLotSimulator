using System;
namespace CarLotSimulator
{
	public class Car

	{
        public Car()
        {

        }
        public Car(int year, string make, string model, string honkNoise,string enginNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EnginNoise = enginNoise;
            IsDrivable = isDrivable;
        }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public string EnginNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string MakeEngineNoise)
        {
            Console.WriteLine($"{Make} and {Model} has an engin noise that sounds like {MakeEngineNoise}");
        }

        public void MakeHonkNoise(string MakeHonkNoise)
        {
            Console.WriteLine($"{Make} and {Model} has an honk noise that sounds like {MakeHonkNoise}");
        }





    }
}

