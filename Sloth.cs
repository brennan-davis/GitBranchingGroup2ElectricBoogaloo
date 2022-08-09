namespace GitBranchingGroup2ElectricBoogaloo
{
    public class Sloth : Pet
    {
        public Sloth(string name)
        {
            Name = name;
            MovementSpeed = 1;
        }

        public override void MakeHappyNoise()
        {
            Console.WriteLine($"{Name} says: SCREEEEAAAACCCHHHHHH");
        }
    }
}
