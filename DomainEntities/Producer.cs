using System.Collections.Generic;

namespace TestingEF6CodeFirst.DomainEntities
{
    public class Producer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Category { get; set; }


        #region Navigation Property

        public virtual ProducerAddress Adress { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        #endregion
    }
}
