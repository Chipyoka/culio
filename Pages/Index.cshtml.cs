using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace culio.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Day { get; set; }

    [BindProperty]
    public int Month { get; set; }

    [BindProperty]
    public string Sign { get; set; }
    [BindProperty]
    public string Desc { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        Day = 1;
        if (Day > 0 && Month > 0)
        {
            var (zodiac, description) = GetZodiacSign(Day, Month);
            Sign = zodiac;
            Desc = description;
        }
        else
        {
            Sign = "Invalid input";
            Desc = "Please enter a valid date";

        }
         RedirectToPage();
    }

    private (string, string) GetZodiacSign(int day, int month)
    {
        if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            return ("Aquarius", "Independent, creative, and intellectual.");
        if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            return ("Pisces", "Compassionate, intuitive, and artistic.");
        if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            return ("Aries", "Energetic, brave, and confident.");
        if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            return ("Taurus", "Reliable, patient, and practical.");
        if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            return ("Gemini", "Adaptable, outgoing, and curious.");
        if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            return ("Cancer", "Nurturing, protective, and intuitive.");
        if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            return ("Leo", "Generous, charismatic, and natural leaders.");
        if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            return ("Virgo", "Detail-oriented, analytical, and reliable.");
        if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            return ("Libra", "Diplomatic, charming, and fair-minded.");
        if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            return ("Scorpio", "Passionate, resourceful, and determined.");
        if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            return ("Sagittarius", "Adventurous, optimistic, and philosophical.");
        if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            return ("Capricorn", "Ambitious, disciplined, and practical.");

        return ("Invalid Date", "Please enter a valid day and month.");
    }
}
