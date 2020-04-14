using System;
using Enumeração_e_Composição.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Enumeração_e_Composição.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
