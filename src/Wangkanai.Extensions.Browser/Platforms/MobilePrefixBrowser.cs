using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Wangkanai.Extensions.Browser.Platforms
{
    internal class MobilePrefixBrowser : DeviceBrowser
    {
        // reference 4 chare from http://www.webcab.de/wapua.htm
        private readonly string[] _prefixes = {
            "w3c ", "w3c-", "acs-", "alav", "alca", "amoi", "audi", "avan", "benq",
            "bird", "blac", "blaz", "brew", "cell", "cldc", "cmd-", "dang", "doco",
            "eric", "hipt", "htc_", "inno", "ipaq", "ipod", "jigs", "kddi", "keji",
            "leno", "lg-c", "lg-d", "lg-g", "lge-", "lg/u", "maui", "maxo", "midp",
            "mits", "mmef", "mobi", "mot-", "moto", "mwbp", "nec-", "newt", "noki",
            "palm", "pana", "pant", "phil", "play", "port", "prox", "qwap", "sage",
            "sams", "sany", "sch-", "sec-", "send", "seri", "sgh-", "shar", "sie-",
            "siem", "smal", "smar", "sony", "sph-", "symb", "t-mo", "teli", "tim-",
            "tosh", "tsm-", "upg1", "upsi", "vk-v", "voda", "wap-", "wapa", "wapi",
            "wapp", "wapr", "webc", "winw", "winw", "xda ", "xda-"
        };

        public override bool IsValid(HttpRequest request)
        {
            var agent = request.Headers["User-Agent"].FirstOrDefault()?.ToLowerInvariant();

            // user agent prefix detection
            if (!(agent?.Length >= 4) || !_prefixes.Any(prefix => agent.StartsWith(prefix))) return false;

            DeviceInfo = DeviceBuilder.Mobile();
            return true;
        }
    }
}