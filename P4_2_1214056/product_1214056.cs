using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214056
{
    public class product_1214056
    {
        private string episodeCount;
        private string myTitle;

        public product_1214056()
        {

        }
        public product_1214056(string episode, string title)
        {
            this.EpisodeCount = episode;
            this.MyTitle = title;
        }

        public string EpisodeCount
        {
            get
            {
                return episodeCount;
            }
            set
            {
                episodeCount = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
