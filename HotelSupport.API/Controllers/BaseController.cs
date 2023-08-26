using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BaseController : Controller
{
    // GET
    protected async Task<IActionResult> HandleRequest<T>(Func<Task<T>> func, int successStatusCode, int? totalRecords = null) where T : class
        {
            if (func is null) throw new ArgumentNullException(nameof(func));

            try
            {
                var result = await func();
                
                return StatusCode(successStatusCode, result);
            }
            catch (KeyNotFoundException ex)
            {
                return StatusCode( (int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                return StatusCode( (int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (ArgumentException ex)
            {
                return StatusCode( (int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
}