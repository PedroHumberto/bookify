using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Application.Abstractions.Clock;

namespace Bookify.Infrastructure.Clock
{
    internal sealed class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}