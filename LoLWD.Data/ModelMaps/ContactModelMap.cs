using LoLWD.Shared.Models.Entities;

namespace LoLWD.Data.ModelMaps
{
    public class ContactModelMap : BaseEnityModelMap<Contact>
    {
        #region Constructors

        public ContactModelMap()
        {
            Property(x => x.Name).IsOptional().HasMaxLength(200);
            Property(x => x.Email).IsRequired().HasMaxLength(200);
            Property(x => x.Comment).IsRequired().HasMaxLength(700);

            ToTable("Contact");
        }

        #endregion

    }
}
