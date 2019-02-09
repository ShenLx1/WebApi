using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
    public class NewsDetail
    {
        [BsonElement("date")]
        public string date { get; set; }
        [BsonElement("category")]
        public string category { get; set; }
        [BsonElement("author_name")]
        public string author_name { get; set; }
        [BsonElement("url")]
        public string url { get; set; }
        [BsonElement("image1")]
        public string image1 { get; set; }
        [BsonElement("image2")]
        public string image2 { get; set; }
        [BsonElement("image3")]
        public string image3 { get; set; }
        [BsonElement("content")]
        public string content { get; set; }
    }
}