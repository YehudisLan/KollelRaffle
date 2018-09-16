using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KollelRaffleWeb.Data;

namespace KollelRaffleWeb.Models
{
    public class MessageViewer
    {
        public Payment Payment { get; set; }
        public int total { get; set; }
    }
}