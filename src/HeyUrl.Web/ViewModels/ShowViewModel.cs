using HeyUrl_Challenge.Application.Dtos;
using System.Collections.Generic;

namespace hey_url_challenge_code_dotnet.ViewModels
{
    public class ShowViewModel
    {
        public UrlDto Url { get; set; }
        public Dictionary<string, int> DailyClicks { get; set; }
        public Dictionary<string, int> BrowseClicks { get; set; }
        public Dictionary<string, int> PlatformClicks { get; set; }
    }
}