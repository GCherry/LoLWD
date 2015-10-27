using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LoLWD.Shared.Models.Entities;

namespace LoLWD.Data.ModelMaps
{
    public class BaseEnityModelMap<T> : EntityTypeConfiguration<T> where T : Entity
    {
        #region Constuctors

        public BaseEnityModelMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedOn).IsRequired();
            Property(x => x.ModifiedOn).IsRequired();
        }

        #endregion
    }
}