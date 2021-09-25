namespace TryDotNet6
{
    public struct Animal : IAnimal
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public IAnimal.SpeciesEnum Species { get; set; }
    }
}

