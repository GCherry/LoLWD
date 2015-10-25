using System;

namespace LoLWD.Core.Models.Entities
{
    public class BaseEnity
    {
        #region Properties

        public DateTime CreatedOn { get; set; }
        public int Id { get; set; }
        public DateTime ModifiedOn { get; set; }

        #endregion
    }
}