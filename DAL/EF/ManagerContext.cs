using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ManagerContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<SrviceProvider> SrviceProviders { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<BookingNotification> BookingsNotifications { get; set; }
        public DbSet<IssueNotification> IssueNotifications { get; set; }
        public DbSet<PaymentNotification> PaymentNotifications { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingNotification>()
                .HasRequired(bn => bn.Client)
                .WithMany()
                .HasForeignKey(bn => bn.IdOfClient)
                .WillCascadeOnDelete(false);

        }
    }
}
