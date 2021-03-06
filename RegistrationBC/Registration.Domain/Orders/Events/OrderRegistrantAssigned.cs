﻿using System;
using ENode.Eventing;

namespace Registration.Orders
{
    [Serializable]
    public class OrderRegistrantAssigned : DomainEvent<Guid>
    {
        public Guid ConferenceId { get; private set; }
        public Registrant Registrant { get; private set; }

        public OrderRegistrantAssigned() { }
        public OrderRegistrantAssigned(Order order, Guid conferenceId, Registrant registrant) : base(order)
        {
            ConferenceId = conferenceId;
            Registrant = registrant;
        }
    }
}
