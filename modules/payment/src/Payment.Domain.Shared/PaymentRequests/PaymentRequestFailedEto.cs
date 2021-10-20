﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Events.Distributed;

namespace Payment.PaymentRequests
{
    [Serializable]
    public class PaymentRequestFailedEto : EtoBase, IHasExtraProperties
    {
        public Guid PaymentRequestId { get; set; }

        public string FailReason { get; set; }

        public ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}
