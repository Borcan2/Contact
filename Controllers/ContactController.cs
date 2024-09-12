using Contact.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    [HttpPost]
    public IActionResult SubmitForm([FromBody] ContactForm form)
    {
        // Here you can handle the form submission, e.g., save to database or send an email
        if (ModelState.IsValid)
        {
            // For now, let's just return a success message
            return Ok(new { message = "Form submitted successfully!" });
        }
        return BadRequest(ModelState);
    }
}
