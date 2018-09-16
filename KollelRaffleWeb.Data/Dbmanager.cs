using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KollelRaffleWeb.Data
{
    public class Dbmanager
    {
        private string _connectionString;
        public Dbmanager(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddEntry(Entry e)
        {
            using (var context = new EntryDataContext(_connectionString))
            {
                context.Entries.InsertOnSubmit(e);
                context.SubmitChanges();
            }
        }
       
        public IEnumerable<Entry> GetEntries()
        {
            using (var context = new EntryDataContext(_connectionString))
            {
                return context.Entries.ToList();
            }
        }
        public Entry GetEntryForId(int id)
        {
            using (var context = new EntryDataContext(_connectionString))
            {
                return context.Entries.FirstOrDefault(e => id == e.Id);
            }
        }
        public int GetTotal(int sheitel, int cash, int sheitelBulk, int cashBulk)
        {
            int totalSheitel = sheitel * 18;
            int totalCash = cash * 36;
            int totalSheitelBulk = sheitelBulk * 100;
            int totalCashBulk = cashBulk * 100;
            return totalCash + totalSheitel + totalCashBulk + totalSheitelBulk;
        }
    }
}
