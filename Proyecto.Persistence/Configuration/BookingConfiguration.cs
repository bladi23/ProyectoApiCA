﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Persistence.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<BookingEntity>entityBuilder) {
            entityBuilder.HasKey(x => x.BookingId);
            entityBuilder.Property(x => x.RegisterDate).IsRequired();
            entityBuilder.Property(x => x.Code).IsRequired();
            entityBuilder.Property(x => x.Type).IsRequired();
            entityBuilder.Property(x => x.CustomerId).IsRequired();
            entityBuilder.Property(x => x.UserId).IsRequired();
            entityBuilder.Property(x => x.ProductId).IsRequired();

            entityBuilder.HasOne(x => x.Users)
                .WithMany(x => x.Bookings)
                .HasForeignKey(x => x.UserId);

            entityBuilder.HasOne(x => x.Customers)
                .WithMany(x => x.Bookings)
                .HasForeignKey(x => x.CustomerId);

            entityBuilder.HasOne(x => x.Products)
            .WithMany(x => x.Bookings)
            .HasForeignKey(x => x.ProductId);

        }
    }
}
