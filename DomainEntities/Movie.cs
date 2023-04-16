using System;
using System.Collections.Generic;

namespace TestingEF6CodeFirst.DomainEntities
{
    public class Movie
    {
        public int Id { get; set; }

        public string MovieTitle { get; set; }

        public string MovieCategory { get; set; }

        public DateTime? MovieRelaesedDate { get; set; }

        public DateTime? MovieDuration { get; set; }


        #region Navigation Property

        public virtual ICollection<Producer> Producer { get; set; }

        #endregion
    }
}
