using Proyecto.Domain.Entities.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.Entities.Product
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BookingEntity> Bookings { get; set; }


    }
}
