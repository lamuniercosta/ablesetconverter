using AbleSet_Converter.Models.AbleSet;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AbleSet_Converter.Services
{
    public class SetListGenerator
    {
        public Task<string> GenerateSetList(AbleSetSetlist setlist)
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            return Task.FromResult(JsonConvert.SerializeObject(setlist.Songs, new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            }));
        }
    }
}
