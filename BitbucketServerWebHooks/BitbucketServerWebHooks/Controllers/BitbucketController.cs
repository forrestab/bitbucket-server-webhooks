using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace GitHooksListener.Controllers
{
    public class BitbucketController : ControllerBase
    {
        [BitbucketWebHook(EventName = "pr:opened")]
        public async Task<IActionResult> PullRequestOpened(string id, string webHookId, JObject data)
        {
            return this.Ok();
        }
    }
}
