using Entities;
using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TVProgramBL
    {
        public bool AddTVProgram(TVProgram tVProgram)
        {
            bool result;
            TVProgramDAL tVChannelDAL = new TVProgramDAL();
            result = tVChannelDAL.AddProgram(tVProgram);
            return result;
        }

        public List<TVProgram> DisplayTVProgByChannelType(string channelType)
        {
            TVProgramDAL tVChannelDAL = new TVProgramDAL();

            List<TVProgram> tVPrograms = tVChannelDAL.DisplayTVProgByChannelType(channelType);
            return tVPrograms;
        }
    }
}
