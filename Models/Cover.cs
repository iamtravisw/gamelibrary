using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gamelibrary.Models
{
    public class Cover
    {
        public string url { get; set; } = null;

        public string LargeImageUrl()
        {
            if (url == null)
            {
                // return custom image URL if there is no image URL over at IGDB

                return "https://i.imgur.com/W1TFJFQ.png";
            }
            else
            {
                // images are retrieved with the following URL: "//images.igdb.com/igdb/image/upload/t_thumb/wfypvgs43l3h19cby28j.jpg"
                // we want to replace the "thumb" with "cover_big" using the following naming convention: https://images.igdb.com/igdb/image/upload/t_cover_big/co1hio.jpg 

                var newUrl = this.url.Replace("t_thumb", "t_cover_big");
                return newUrl;
            }
        }
    }
}
