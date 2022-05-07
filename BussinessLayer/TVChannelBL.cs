using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TVChannelBL
    {

        public bool AddTVChannel(TVChannel tVChannel)
        {
            bool result;
            TVChannelDAL tVChannelDAL = new TVChannelDAL();
            result = tVChannelDAL.AddChannel(tVChannel);
            return result;
        }

        public List<TVChannel> GetTVChannel()
        {
            TVChannelDAL tVChannelDAL = new TVChannelDAL();
            List<TVChannel> tvChannel = tVChannelDAL.GetChannel();
            return tvChannel;

        }
    }
}
