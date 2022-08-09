namespace GitBranchingGroup2ElectricBoogaloo
{
    public class Pet
    {
        public string Name { get; set; }

        public int NumOfWhiskers { get; set; }
        public string Color { get; set; }

        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
