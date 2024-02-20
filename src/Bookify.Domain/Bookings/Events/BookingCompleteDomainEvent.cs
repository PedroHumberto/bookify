using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings
{
    public sealed record BookingCompleteDomainEvent(Guid bookingId) : IDomainEvent;
}