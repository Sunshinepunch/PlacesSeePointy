namespace Places
{
  public class Diary
  {
    public string CityName { get; set; }
    public string DateVisited { get; set; }
    public int ID { get; set; }

    public void City(string cityName)
    {
      CityName = cityName;
    }

     public void Date(string dateVisited)
    {
      DateVisited = dateVisited;
    }

  }
}




