using CSharp.Basics.Samples.Constructors;
using CSharp.Basics.Samples.FunctionDrivenClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Basics.Samples.Async
{
    public class DogAdoptionService
    {
        public async Task<List<AdoptableDog>> GetAdoptableDogsAsync()
        {
            var dogJson = await new HttpClient().GetStringAsync("http://someurl.com");
            return JsonConvert.DeserializeObject<List<AdoptableDog>>(dogJson);
        }

        void BackgroundGet()
        {
            List<AdoptableDog> dogs;
            Task.Run(async () => dogs = await GetAdoptableDogsAsync());
        }
    }
}
