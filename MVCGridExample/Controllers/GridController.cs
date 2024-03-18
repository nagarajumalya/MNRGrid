using MVCGridExample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Newtonsoft.Json;

namespace MVCGridExample.Controllers
{
    public class GridController : Controller
    {
        // GET: Grid
        public ActionResult Index()
        {
            string jsonString = @"{
            ""status"":""success"",
            ""count"": 3,
            ""metadata"":{
            ""confidenceScore"": 0.8
            },
            ""results"":
            [
            {
            ""id"": 1,
            ""score"": 0.8,
            ""path"": ""1.pdf""
            },
            {
            ""id"": 2,
            ""score"": 0.75,
            ""path"": ""2.pdf""
            },
            {
            ""id"": 3,
            ""score"": 0.66,
            ""path"": ""3.pdf""
            }
            ]}";
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
            ResultGridModelList glm = new ResultGridModelList();
            List<ResultGridModel> gl = new List<ResultGridModel>();
           
            foreach (var item in myDeserializedClass.results)
            {
                ResultGridModel gm = new ResultGridModel();
                gm.id = item.id;
                gm.path = item.path;
                gm.score = item.score;
                gl.Add(gm);
            }
            glm.ResultGridData = gl;

            ViewData["selectedResumeViewer"] = "active";
            return View("~/Views/Grid/GridView.cshtml", glm);
        }
    }
}