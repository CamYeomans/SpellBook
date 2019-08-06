using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spellbook
{
    /// <summary>
    /// Used for making Api calls for the spellbook app
    /// </summary>
    class ApiManager
    {
        private string baseurl;
        
        public ApiManager()
        {
            baseurl = "http://dnd5eapi.co/api/";
        }

        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {

            }
        }
    }
}
