using CodingChallengeThird.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingChallengeThird.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult AddTVChannel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTVChannel(TVChannelModel tVChannelModel,string Save)
        {
            ViewBag.Message = null;
            try
            {
                if(ModelState.IsValid && !string.IsNullOrEmpty(Save))
                {
                    TVChannelManager tVChannelManager = new TVChannelManager();
                    if(tVChannelManager.AddTVChannel(tVChannelModel))
                    {
                        ViewBag.Message = "TVChannel Added Successfully";
                    }

                }
                return View();
            }catch
            {
                return View("Index");
            }
        }

        public ActionResult AddTVProgram()
        {
            TVChannelManager tVChannelManager = new TVChannelManager();
            List<TVChannelModel> tVChannelModels = tVChannelManager.tvChannel();
            ViewBag.Channel = tVChannelModels;
            return View();
        }
        [HttpPost]
        public ActionResult AddTVProgram(TVProgramModel tVProgramModel, string Save)
        {
            try
            {
                if(ModelState.IsValid && !string.IsNullOrEmpty(Save))
                {
                    TVProgramManager tVProgramManager = new TVProgramManager();
                    if(tVProgramManager.AddTVProgram(tVProgramModel))
                    {
                        ViewBag.Message = "TV Program Added Successfully";
                    }

                }
                return View("Index");

            }
            catch
            {
                return View("Index");
            }
        }

        public ActionResult TVProgramByChanelType()
        {

            TVChannelManager tVChannelManager = new TVChannelManager();
            List<TVChannelModel> tVChannelModels = tVChannelManager.tvChannel();
            ViewBag.Channel = tVChannelModels.Select(x=>x.TVChanneltype).Distinct().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult TVProgramByChanelType(string TVChanneltype)
        {

            TVProgramManager tVProgramManager = new TVProgramManager();
            List<TVProgramModel> tVProgramModels = tVProgramManager.DisplayTVProgByChannelType(TVChanneltype);
            TempData["tVProgramModels"] = tVProgramModels;
            return RedirectToAction("Display");
        }
        public ActionResult Display()
        {
            ViewBag.tVProgramModels = TempData["tVProgramModels"];
            return View();
        }
    }
}