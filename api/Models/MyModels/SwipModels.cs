using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    [BsonIgnoreExtraElements]
    public class SwipModels
    {
        [BsonElement("url")]
        public string url { get; set; }
        [BsonElement("img")]
        public string img { get; set; }
    }
}