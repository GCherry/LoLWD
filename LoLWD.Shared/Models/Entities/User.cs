using System;

namespace LoLWD.Shared.Models.Entities
{
    public class User : Entity
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string SummonerName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        #endregion
    }
}