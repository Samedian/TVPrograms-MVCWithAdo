using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallengeThird.Models
{
    public class TVChannelManager
    {

        public  bool AddTVChannel(TVChannelModel tVChannelModel)
        {
            bool result;

            TVChannel tVChannel = new TVChannel();
            tVChannel.TVChannelName = tVChannelModel.TVChannelName;
            tVChannel.TVChanneltype = tVChannelModel.TVChanneltype;
            tVChannel.Description = tVChannelModel.Description;

            TVChannelBL tVChannelBL = new TVChannelBL();
            result = tVChannelBL.AddTVChannel(tVChannel);

            return result;
        }

        public List<TVChannelModel> tvChannel()
        {

            TVChannelBL tVChannelBL = new TVChannelBL();

            List<TVChannel> tvChannel = tVChannelBL.GetTVChannel();

            List<TVChannelModel> tvChannelModel = new List<TVChannelModel>();

            foreach (var item in tvChannel)
            {
                TVChannelModel tVChannelModel = new TVChannelModel();
                tVChannelModel.TVChannelId = item.TVChannelId;
                tVChannelModel.TVChannelName = item.TVChannelName;
                tVChannelModel.TVChanneltype = item.TVChanneltype;
                tVChannelModel.Description = item.Description;
                tvChannelModel.Add(tVChannelModel);
            }

            return tvChannelModel;
        }

    }
}