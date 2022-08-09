namespace GitBranchingGroup2ElectricBoogaloo
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}
