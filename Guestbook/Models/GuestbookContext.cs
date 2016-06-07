using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Guestbook.Models
{
    public class GuestbookContext: DbContext
    {
        public GuestbookContext() : base("GuestbookContext")
        {

        }        

        public DbSet<GuestbookEntry> Entries { get; set; }
    }
}