using Entities;
using System;
using BussinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallengeThird.Models
{
    public class TVProgramManager
    {
        public bool AddTVProgram(TVProgramModel tVProgramModel)
        {
            TVProgram tVProgram = new TVProgram();

            tVProgram.TVProgramName = tVProgramModel.TVProgramName;
            tVProgram.TVProgramCategory = tVProgramModel.TVProgramCategory;
            tVProgram.TVProgramChannelName = tVProgramModel.TVProgramChannelName;
            tVProgram.TVProgramDesc = tVProgramModel.TVProgramDesc;
            tVProgram.TVProgramDuration = tVProgramModel.TVProgramDuration;

            TVProgramBL tVProgramBL = new TVProgramBL();
            bool result = tVProgramBL.AddTVProgram(tVProgram);

            return result;
        }

        public List<TVProgramModel> DisplayTVProgByChannelType(string channelType)
        {
            TVProgramBL tVProgramBL = new TVProgramBL();
            List<TVProgram> tVPrograms = tVProgramBL.DisplayTVProgByChannelType(channelType);

            List<TVProgramModel> tVProgramModels = new List<TVProgramModel>();

            foreach (var item in tVPrograms)
            {
                TVProgramModel tvProg = new TVProgramModel();
                tvProg.TVProgramId = item.TVProgramId;
                tvProg.TVProgramName = item.TVProgramName;
                tvProg.TVProgramCategory = item.TVProgramCategory;
                tvProg.TVProgramChannelName = item.TVProgramChannelName;
                tvProg.TVProgramDesc = item.TVProgramDesc;
                tvProg.TVProgramDuration = item.TVProgramDuration;

                tVProgramModels.Add(tvProg);
            }

            return tVProgramModels;
        }
    }
}