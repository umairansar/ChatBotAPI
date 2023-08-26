using ChatBot.HotelSupport.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Services;

public interface IHotelService
{
    Task<List<Hotel>> Recommend();
    Task<List<Hotel>> RecommendByArea(string area);
    Task<List<Hotel>> RecommendByRating(int rating);
    Task<List<Hotel>> RecommendByWeather(string weather);
}