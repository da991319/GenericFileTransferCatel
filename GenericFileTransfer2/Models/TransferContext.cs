using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GenericFileTransfer2.Models
{
    public class TransferContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }
        public DbSet<Column> Columns { get; set; }
    }
}
