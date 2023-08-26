using System.Net;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Core;
using ChatBot.Controllers.BaseController;

namespace ChatBot.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RecommenderController : BaseController
{
    private readonly IHotelService _hotelService;
    public RecommenderController(IHotelService hotelService)
    {
        _hotelService = hotelService;
    }
    
    [HttpPost("recommend")]
    public async Task<IActionResult> Recommend()
    {
        return await HandleRequest(() =>_hotelservice.Recommend(), (int)HttpStatusCode.OK);
    }
    
    [HttpPost("recommend/{area}")]
    public async Task<IActionResult> RecommendByArea(string area)
    {
        return await HandleRequest(() =>_hotelservice.Recommend(area), (int)HttpStatusCode.OK);
    }
    
    [HttpPost("recommend-by-area/{rating}")]
    public async Task<IActionResult> RecommendByRating(int rating)
    {
        return await HandleRequest(() =>_hotelservice.RecommendByRating(rating), (int)HttpStatusCode.OK);
    }
    
    [HttpPost("recommend-by-weather/{weather}")]
    public async Task<IActionResult> RecommendByWeather(string weather)
    {
        return await HandleRequest(() =>_hotelservice.RecommendByWeather(weather), (int)HttpStatusCode.OK);
    }
}