using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubReleaseViewer
{
    public class GitHub_Release
    {
        /*
         *     "url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/releases/4236171",
    "assets_url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/releases/4236171/assets",
    "upload_url": "https://uploads.github.com/repos/CaffeineAU/TTSAutomate/releases/4236171/assets{?name,label}",
    "html_url": "https://github.com/CaffeineAU/TTSAutomate/releases/tag/2.8.1.2",
    "id": 4236171,
    "tag_name": "2.8.1.2",
    "target_commitish": "master",
    "name": "Add support for code page 1250",
    "draft": false,
    "author": {
      "login": "CaffeineAU",
      "id": 14083423,
      "avatar_url": "https://avatars.githubusercontent.com/u/14083423?v=3",
      "gravatar_id": "",
      "url": "https://api.github.com/users/CaffeineAU",
      "html_url": "https://github.com/CaffeineAU",
      "followers_url": "https://api.github.com/users/CaffeineAU/followers",
      "following_url": "https://api.github.com/users/CaffeineAU/following{/other_user}",
      "gists_url": "https://api.github.com/users/CaffeineAU/gists{/gist_id}",
      "starred_url": "https://api.github.com/users/CaffeineAU/starred{/owner}{/repo}",
      "subscriptions_url": "https://api.github.com/users/CaffeineAU/subscriptions",
      "organizations_url": "https://api.github.com/users/CaffeineAU/orgs",
      "repos_url": "https://api.github.com/users/CaffeineAU/repos",
      "events_url": "https://api.github.com/users/CaffeineAU/events{/privacy}",
      "received_events_url": "https://api.github.com/users/CaffeineAU/received_events",
      "type": "User",
      "site_admin": false
    },
    "prerelease": false,
    "created_at": "2016-09-27T03:07:25Z",
    "published_at": "2016-09-27T03:16:38Z",
    "assets": [
      {
        "url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/releases/assets/2393801",
        "id": 2393801,
        "name": "TTSAutomate.2.8.1.2.Installer.zip",
        "label": null,
        "uploader": {
          "login": "CaffeineAU",
          "id": 14083423,
          "avatar_url": "https://avatars.githubusercontent.com/u/14083423?v=3",
          "gravatar_id": "",
          "url": "https://api.github.com/users/CaffeineAU",
          "html_url": "https://github.com/CaffeineAU",
          "followers_url": "https://api.github.com/users/CaffeineAU/followers",
          "following_url": "https://api.github.com/users/CaffeineAU/following{/other_user}",
          "gists_url": "https://api.github.com/users/CaffeineAU/gists{/gist_id}",
          "starred_url": "https://api.github.com/users/CaffeineAU/starred{/owner}{/repo}",
          "subscriptions_url": "https://api.github.com/users/CaffeineAU/subscriptions",
          "organizations_url": "https://api.github.com/users/CaffeineAU/orgs",
          "repos_url": "https://api.github.com/users/CaffeineAU/repos",
          "events_url": "https://api.github.com/users/CaffeineAU/events{/privacy}",
          "received_events_url": "https://api.github.com/users/CaffeineAU/received_events",
          "type": "User",
          "site_admin": false
        },
        "content_type": "application/x-zip-compressed",
        "state": "uploaded",
        "size": 2716841,
        "download_count": 0,
        "created_at": "2016-09-29T00:03:55Z",
        "updated_at": "2016-09-29T00:04:16Z",
        "browser_download_url": "https://github.com/CaffeineAU/TTSAutomate/releases/download/2.8.1.2/TTSAutomate.2.8.1.2.Installer.zip"
      },
      {
        "url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/releases/assets/2393802",
        "id": 2393802,
        "name": "TTSAutomate.2.8.1.2.Portable.zip",
        "label": null,
        "uploader": {
          "login": "CaffeineAU",
          "id": 14083423,
          "avatar_url": "https://avatars.githubusercontent.com/u/14083423?v=3",
          "gravatar_id": "",
          "url": "https://api.github.com/users/CaffeineAU",
          "html_url": "https://github.com/CaffeineAU",
          "followers_url": "https://api.github.com/users/CaffeineAU/followers",
          "following_url": "https://api.github.com/users/CaffeineAU/following{/other_user}",
          "gists_url": "https://api.github.com/users/CaffeineAU/gists{/gist_id}",
          "starred_url": "https://api.github.com/users/CaffeineAU/starred{/owner}{/repo}",
          "subscriptions_url": "https://api.github.com/users/CaffeineAU/subscriptions",
          "organizations_url": "https://api.github.com/users/CaffeineAU/orgs",
          "repos_url": "https://api.github.com/users/CaffeineAU/repos",
          "events_url": "https://api.github.com/users/CaffeineAU/events{/privacy}",
          "received_events_url": "https://api.github.com/users/CaffeineAU/received_events",
          "type": "User",
          "site_admin": false
        },
        "content_type": "application/x-zip-compressed",
        "state": "uploaded",
        "size": 2206302,
        "download_count": 0,
        "created_at": "2016-09-29T00:04:06Z",
        "updated_at": "2016-09-29T00:04:31Z",
        "browser_download_url": "https://github.com/CaffeineAU/TTSAutomate/releases/download/2.8.1.2/TTSAutomate.2.8.1.2.Portable.zip"
      }
    ],
    "tarball_url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/tarball/2.8.1.2",
    "zipball_url": "https://api.github.com/repos/CaffeineAU/TTSAutomate/zipball/2.8.1.2",
    "body": "Add 'Open as code page cp1250'\r\n\r\nUpdate Slovak translation (add missing ' t ' character, fix 'Hlavicka retazca' wording)"
  },
*/

        public Uri url { get; set; }
        public Uri assets_url { get; set; }
        public Uri upload_url { get; set; }
        public Uri html_url { get; set; }
        public string id { get; set; }
        public string tag_name { get; set; }
        public string target_commitish { get; set; }
        public string name { get; set; }
        public string draft { get; set; }
        public person author { get; set; }
        public asset[] assets { get; set; }
        public Uri tarball_url { get; set; } // "https://api.github.com/repos/CaffeineAU/TTSAutomate/tarball/2.8.1.2",
        public Uri zipball_url { get; set; } // "https://api.github.com/repos/CaffeineAU/TTSAutomate/zipball/2.8.1.2",
        public string body { get; set; } // "Add 'Open as code page cp1250'\r\n\r\nUpdate Slovak translation (add missing ' t ' character, fix 'Hlavicka retazca' wording)"

    }

    public class person
    {
        public string login { get; set; }
        public string id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public string site_admin { get; set; }
    }

    public class asset
    {
        public Uri url { get; set; } // "https://api.github.com/repos/CaffeineAU/TTSAutomate/releases/assets/2393801",
        public string id { get; set; } // 2393801,
        public string name { get; set; } // "TTSAutomate.2.8.1.2.Installer.zip",
        public string label { get; set; } // null,
        public person uploader { get; set; } // {
        public string content_type { get; set; } // "application/x-zip-compressed",
        public string state { get; set; } // "uploaded",
        public string size { get; set; } // 2716841,
        public string download_count { get; set; } // 0,
        public string created_at { get; set; } // "2016-09-29T00:03:55Z",
        public string updated_at { get; set; } // "2016-09-29T00:04:16Z",
        public Uri browser_download_url { get; set; } // "https://github.com/CaffeineAU/TTSAutomate/releases/download/2.8.1.2/TTSAutomate.2.8.1.2.Installer.zip"
    }
}
