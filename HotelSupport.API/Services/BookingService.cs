using ChatBot.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Services;

public class BookingService : IBookingService
{
    public Task<IActionResult> SendEmail(EmailData data)
    {
        //Use SMTP client
        throw new NotImplementedException();
    }

    public Task<IActionResult> ScheduleCall(ScheduleData data)
    {
        //Use SMTP client to send email to our business requesting call 
        throw new NotImplementedException();
    }
}