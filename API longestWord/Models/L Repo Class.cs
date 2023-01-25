using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_longestWord.Models
{
    public class L_Repo_Class
    {
        LDBContext db = new LDBContext();
        Model ms = new Model();

        public bool Create(CLongest cl)
        {
            db.LModels.Add(new CLongest()
            {
                Inputvalue = cl.Inputvalue,
                Outputvalue = cl.Outputvalue
            });
            return true;
        }


        public CLongest GetbyId(long id)
        {
            var s = db.LModels.Find(id);
            db.SaveChanges();
            return s;
        }
       


    }
}