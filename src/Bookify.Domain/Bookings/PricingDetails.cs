using Bookify.Domain.Shared;

namespace Bookify.Domain.Bookings
{
    public record PricingDetails(
        Money priceForPeriod,
        Money cleaningFee, 
        Money amenitiesUpCharge, 
        Money totalPrice);
}