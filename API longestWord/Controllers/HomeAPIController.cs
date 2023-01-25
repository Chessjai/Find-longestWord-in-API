using API_longestWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Configuration;
using System.Web.Http;

namespace API_longestWord.Controllers
{
    public class HomeAPIController : ApiController
    {
            LDBContext db = new LDBContext();
            L_Repo_Class s = new L_Repo_Class();
        CLongest cLongest = new CLongest();

        [HttpPost]
            [Route("~/api/HomeAPI/Create")]
            public IHttpActionResult Create(string cl)
            {
                Model ms = new Model();

                if (!ModelState.IsValid)
                    return BadRequest("Invalid Data ");
                //ms.longestLength();
                using (var ctx = new LDBContext())
                {
                    string str = cl;
                    ctx.LModels.Add(new CLongest()
                    {
                        Inputvalue = cl,
                        Outputvalue = ms.longestLength(str),
                    });
                    ctx.SaveChanges();
                }

                return Ok();
            }


            [HttpGet]
            [Route("~/api/HomeAPI/GetbyId")]
            public IHttpActionResult GetbyId(long id)
            {
                //var s = db.LModels.Find(id);
                var a = s.GetbyId(id);
                return Ok(a);
            }
        [HttpGet]
        [Route("~/api/HomeAPI/GetAll")]
        public IEnumerable<CLongest> GetAll()
        {
            IList<CLongest> userList = new List<CLongest>();
            var query = from user in db.LModels
                        select user;
            var users = query.ToList();
            foreach (var userData in users)
            {
                userList.Add(new CLongest()
                {
                    Id = userData.Id,
                    Inputvalue = userData.Inputvalue,
                    Outputvalue = userData.Outputvalue
                
                });
            }
            return userList;
        }


    }
    }

