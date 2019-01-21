public class DogAdoptionService
{
    public void Adopt((Dog, Shelter) data)
    {
        data.Item1.IsAdopted = true;
    }
}

public class Dog
{
    public bool IsAdopted { get; set; }
}
public class Shelter { }