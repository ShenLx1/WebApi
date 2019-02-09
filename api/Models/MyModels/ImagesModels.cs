using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
    [BsonIgnoreExtraElements]
    public class ImagesModels
    {
        [BsonElement("category")]
        public string category { get; set; }
        [BsonElement("groupid")]
        public int groupid { get; set; }
        [BsonElement("Images")]
        public List<ImagesList> Images { get; set; }
    }

    public class ImagesList
    {
        [BsonElement("pid")]
        public int pid { get; set; }
        [BsonElement("url")]
        public string url { get; set; }
        [BsonElement("title")]
        public string title { get; set; }

        public ImagesDetail Detail { get; set; }
    }

    public class ImagesDetail
    {
        [BsonElement("pic")]
        public List<pic> pic { get; set; }
       
        [BsonElement("title")]
        public string title { get; set; }

        [BsonElement("text")]
        public string text { get; set; }
        [BsonElement("Comment")]
        public List<NewsComment> Comment { get; set; }
    }

    public class pic {
        [BsonElement("src")]
        public string src { get; set; }
        [BsonElement("msrc")]
        public string msrc { get; set; }
        [BsonElement("alt")]
        public string alt { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
    }
}