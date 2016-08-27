using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Wangkanai.Extensions.Browser.Platforms
{
    internal class WapBrowser : DeviceBrowser
    {
        public override bool IsValid(HttpRequest request)
        {
            // accept-header base detection
            if (request.Headers["Accept"].All(accept => accept.ToLowerInvariant() != "wap")) return false;

            // user agent prof detection
            if (!request.Headers.ContainsKey("x-wap-profile") || !request.Headers.ContainsKey("Profile")) return false;

            DeviceInfo = DeviceBuilder.Mobile();
            return true;
        }
    }
}