using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Bookify.Domain.Reviews;
using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");

            builder.HasKey(review => review.Id);

            builder.Property(review => review.Rating)
                .HasConversion(rating => rating.Value, value => Rating.Create(value).Value);

            builder.Property(review => review.Comment)
                .HasMaxLength(200)
                .HasConversion(comment => comment.Value, value => new Comment(value));

            builder.HasOne<Apartment>()
                .WithMany()
                .HasForeignKey(review => review.ApartmentId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne<Booking>()
                .WithMany()
                .HasForeignKey(review => review.BookingId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(review => review.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

        }
    }
}