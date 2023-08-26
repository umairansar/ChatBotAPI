namespace ChatBot.HotelSupport.Domain.Entities;

public class Hotel
{
    public string Name { get; set; }
    public string Area { get; set; }
    public int Rating { get; set; }

    Hotel(string name, string area, int rating)
    {
        Name = name;
        Area = area;
        Rating = rating;
    }
}