using LoLWD.Shared.Models.Entities;

namespace LoLWD.Data.ModelMaps
{
    public class UserModelMap : BaseEnityModelMap<User>
    {
        #region Constructors

        public UserModelMap()
        {
            Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            Property(x => x.LastName).IsRequired().HasMaxLength(200);
            Property(x => x.MiddleName).IsOptional().HasMaxLength(200);
            Property(x => x.Birthday).IsRequired();
            Property(x => x.Email).IsRequired().HasMaxLength(200);
            Property(x => x.SummonerName).IsOptional().HasMaxLength(200);
            Property(x => x.Password).IsRequired().HasMaxLength(200);
            Property(x => x.UserName).IsRequired().HasMaxLength(200);

            ToTable("User");
        }

        #endregion
    }
}