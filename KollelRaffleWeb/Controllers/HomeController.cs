using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KollelRaffleWeb.Data;
using KollelRaffleWeb.Models;

namespace KollelRaffleWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Enter()
        {
            var iv = new IndexViewer();

            if (Session["entered"] != null)
            {
                iv.Total = (int)Session["entered"];
            }
            return View(iv);
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInfo(Entry e)
        {
            var manager = new Dbmanager(Properties.Settings.Default.ConStr);
            e.Total = manager.GetTotal(e.Sheitel, e.Cash, e.SheitelBulk, e.CashBulk);
            manager.AddEntry(e);       
            Session["entered"] = e.Total ;
            return Redirect($"/home/message?payment={e.Payment}&amount={e.Total}&id={e.Id}");
            
        }
        public ActionResult Trial()
        {
            return View();
        }
        public ActionResult Message(Payment payment, int amount, int id)
        {            MessageViewer mv = new MessageViewer
            {
                Payment = payment,
                total = amount
            };

         return View(mv);
        }
        public ActionResult Admin()
        {
            var db = new Dbmanager(Properties.Settings.Default.ConStr);
            IEnumerable<Entry> entries = db.GetEntries();
            return View(entries);
        }
        public ActionResult Details(int id)
        {
            var db = new Dbmanager(Properties.Settings.Default.ConStr);
            return View(db.GetEntryForId(id));
        }
    }
}