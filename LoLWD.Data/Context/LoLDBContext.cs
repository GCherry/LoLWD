using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LoLWD.Data.ModelMaps;
using LoLWD.Shared.Models.Entities;

namespace LoLWD.Data.Context
{
    public class LoLDBContext : DbContext
    {
        #region Constructors

        public LoLDBContext() : base(ConnectionStringName)
        {
        }

        static LoLDBContext()
        {
            ConnectionStringName = "LoLConnection";
        }

        #endregion

        #region Properties

        public static string ConnectionStringName { get; set; }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Contact> Contacts { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserModelMap());
            modelBuilder.Configurations.Add(new ContactModelMap());
        }

        #endregion


    }
}