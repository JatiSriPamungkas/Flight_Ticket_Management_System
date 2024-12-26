using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using Flight_Ticket_Management.Model.Entity;
using Flight_Ticket_Management.Model.Context;

namespace Flight_Ticket_Management.Model.Repository
{
    public class JadwalRepository
    {
        private SQLiteConnection _conn;

        public JadwalRepository(DbContext context)
        {
            _conn = context.Conn;
        }
    }
}
