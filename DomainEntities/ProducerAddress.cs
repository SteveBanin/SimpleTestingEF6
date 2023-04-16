using System.ComponentModel.DataAnnotations.Schema;

namespace TestingEF6CodeFirst.DomainEntities
{
    public class ProducerAddress
    {
        [ForeignKey("Producer")]
        public int ProducerAddressId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int Zipcode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public virtual Producer Producer { get; set; }
    }
}
