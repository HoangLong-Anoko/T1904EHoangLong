using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_News.Models
{
    class New
    {
        public NewsCategory Category { get; set; }
        public string Tile { get; set; }
        public string ImageFile { get; set; }
        public New(NewsCategory category, string tile)
        {
            Category = category;
            Tile = tile;
            ImageFile = String.Format("/Assets/Contents/{0}/{1}.png", category,tile);
        }
    }

    enum NewsCategory
    {
        Politics,
        Weather,
        Technology,
        Entertainment
    }
}
