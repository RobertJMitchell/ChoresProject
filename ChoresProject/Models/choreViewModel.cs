using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoresProject.Models
{
    public class ChoreViewModel
    {
        public List<Models.Chores> KitchenChores;
        public List<Models.Chores> BedroomChores;
        public List<Chores> MyChores { get; set; }

        public List<Chores> Chores { get; set; }
    }
}