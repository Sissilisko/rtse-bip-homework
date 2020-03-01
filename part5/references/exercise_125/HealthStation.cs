namespace exercise_125
{
  public class HealthStation
  {
    public int weighings { get; private set; }

    // Create a constructor here, if needed
    public HealthStation()
    {
      this.weighings =0;
    }

    public int Weigh(Person person)
    {
      // return the weight of the person passed as the parameter
      this.weighings++;
      return person.weight;
      // incrase weighings
      
    }

    public void Feed(Person person)
    {
      // Increse the weight of the person with one kilogram
      person.weight++;
    }
  }
}