using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    [BsonIgnoreExtraElements]
    public class ProductModels
    {
        [BsonElement("itemid")]
        public string itemid { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("text")]
        public string text { get; set; }
        [BsonElement("img_url")]
        public string img_url { get; set; }
        [BsonElement("price")]
        public string price { get; set; }
        [BsonElement("market_price")]
        public string market_price { get; set; }
        [BsonElement("comment")]
        public string comment { get; set; }
        [BsonElement("time")]
        public string time { get; set; }
    }
}