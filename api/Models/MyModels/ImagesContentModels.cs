using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
    public class ImagesContentModels
    {
        [BsonElement("url")]
        public string url { get; set; }
        [BsonElement("text")]
        public string text { get; set; }

        public ImagesDetail detail { get; set; }
    }

    public class ImagesDetail
    {
        [BsonElement("img1")]
        public string img1 { get; set; }
        [BsonElement("img2")]
        public string img2 { get; set; }
        [BsonElement("img3")]
        public string img3 { get; set; }
        [BsonElement("img4")]
        public string img4 { get; set; }
    }
}