using System;

namespace OtrippleS.Portal.Web.Brokers.DateTime
{
    public interface IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime();
    }
}
