using System.Net;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Core;
using ChatBot.Controllers.BaseController;
using ChatBot.DTOs;

namespace ChatBot.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BookingController : BaseController
{
    private readonly IBookingService _bookingService;
    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }
    
    [HttpPost("send-email/{email}")]
    public async Task<IActionResult> SendEmail([FromBody] EmailData data)
    {
        return await HandleRequest(() => _bookingService.SendEmail(data), (int)HttpStatusCode.OK);
    }

    [HttpPost("schedule-call/{area}")]
    public async Task<IActionResult> ScheduleCall([FromBody] ScheduleData data)
    {
        return await HandleRequest(() => _bookingService.ScheduleCall(data), (int)HttpStatusCode.OK);
    }
}