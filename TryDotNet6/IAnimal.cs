namespace TryDotNet6
{
    public interface IAnimal
    {
        enum SpeciesEnum
        {
            NotSet = 0,
            Dog = 1,
            Cat = 2
        }

        string Name { get; set; }

        string Breed { get; set; }

        SpeciesEnum Species { get; set; }
    }
}

