using ChatBot.HotelSupport.Domain.Entities;
using ChatBot.HotelSupport.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Services;

public class HotelService:IHotelService
{
    public async Task<List<Hotel>> Recommend()
    {
        return HotelRepository.Table.ToList();
    }

    public async Task<List<Hotel>> RecommendByArea(string area)
    {
        return HotelRepository.Table.Where(hotel => hotel.Area.Contains(area)).ToList();
    }

    public async Task<List<Hotel>> RecommendByRating(int rating)
    {
        return HotelRepository.Table.Where(hotel => hotel.Rating.Equals(rating)).ToList();
    }

    public async Task<List<Hotel>> RecommendByWeather(string weather)
    {
        throw new NotImplementedException();
    }
}