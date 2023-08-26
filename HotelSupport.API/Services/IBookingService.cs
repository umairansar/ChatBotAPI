using ChatBot.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Services;

public interface IBookingService
{
    Task<IActionResult> SendEmail(EmailData data);
    Task<IActionResult> ScheduleCall(ScheduleData data);
}