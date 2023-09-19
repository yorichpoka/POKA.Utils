﻿using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace POKA.Utils.Infrastructure.MongoDb
{
    internal class Constants
    {
        public static readonly JsonSerializerSettings DefaultJsonSerializerSettings = new()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.None,
            MaxDepth = 3
        };
    }
}
