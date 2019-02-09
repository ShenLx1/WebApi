using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    [BsonIgnoreExtraElements]
    public class Product_DetailModels
    {
        [BsonElement("itemid")]
        public string itemid { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("text")]
        public string text { get; set; }
        [BsonElement("time")]
        public string time { get; set; }
        [BsonElement("word")]
        public string word { get; set; }
        [BsonElement("now_price")]
        public string now_price { get; set; }
        [BsonElement("old_price")]
        public string old_price { get; set; }
        [BsonElement("img_url_1")]
        public string img_url_1 { get; set; }
        [BsonElement("img_url_2")]
        public string img_url_2 { get; set; }
        [BsonElement("img_url_3")]
        public string img_url_3 { get; set; }
        [BsonElement("img_url_4")]
        public string img_url_4 { get; set; }
        [BsonElement("img_url_5")]
        public string img_url_5 { get; set; }
        [BsonElement("img_url_6")]
        public string img_url_6 { get; set; }
        [BsonElement("img_url_7")]
        public string img_url_7 { get; set; }
        [BsonElement("img_url_8")]
        public string img_url_8 { get; set; }
        [BsonElement("img_url_9")]
        public string img_url_9 { get; set; }
        [BsonElement("img_url_10")]
        public string img_url_10 { get; set; }
        
    }
}