using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZodiacApp.Models;

namespace ZodiacApp.Pages;

public class EventsModel : PageModel
{
    [BindProperty]
    public string ZodiacSign { get; set; }

    public List<ZodiacEvent> Events { get; private set; } = new List<ZodiacEvent>();

    public void OnPost()
    {
        ZodiacSign = ZodiacSign?.Trim().ToLowerInvariant();

        var zodiacEvents = new ZodiacEventStore();
        if (zodiacEvents.Events.ContainsKey(ZodiacSign))
        {
            Events = zodiacEvents.Events[ZodiacSign];
        }
    }
}
