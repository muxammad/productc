using Microsoft.EntityFrameworkCore;
using Productc.Application.Abstractions;
using Productc.Domain.Entities.Products;
using Productc.Domain.Entities.Users;

namespace Productc.Infrastructure.Persistense
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options), IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Laptop", Description = "Powerful laptop with 16GB RAM", Price = 1200.99m, ImageUrl = "/images/laptop.jpg", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Smartphone", Description = "Latest model smartphone", Price = 899.50m, ImageUrl = "/images/smartphone.jpg", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Headphones", Description = "Noise-cancelling headphones", Price = 199.99m, ImageUrl = "/images/headphones.jpg", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Gaming Mouse", Description = "Ergonomic RGB gaming mouse", Price = 49.99m, ImageUrl = "/images/mouse.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Keyboard", Description = "Mechanical keyboard with RGB", Price = 89.99m, ImageUrl = "/images/keyboard.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Monitor", Description = "27-inch 4K UHD monitor", Price = 349.99m, ImageUrl = "/images/monitor.jpg", Category = "Electronics" },
                new Product { Id = Guid.NewGuid(), Name = "Smartwatch", Description = "Fitness and health tracking", Price = 159.99m, ImageUrl = "/images/smartwatch.jpg", Category = "Wearables" },
                new Product { Id = Guid.NewGuid(), Name = "Bluetooth Speaker", Description = "Portable waterproof speaker", Price = 79.99m, ImageUrl = "/images/speaker.jpg", Category = "Audio" },
                new Product { Id = Guid.NewGuid(), Name = "Webcam", Description = "1080p HD webcam for streaming", Price = 59.99m, ImageUrl = "/images/webcam.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Tablet", Description = "10-inch Android tablet", Price = 299.99m, ImageUrl = "/images/tablet.jpg", Category = "Electronics" },

                // 10 more
                new Product { Id = Guid.NewGuid(), Name = "External Hard Drive", Description = "1TB USB 3.0 drive", Price = 69.99m, ImageUrl = "/images/hdd.jpg", Category = "Storage" },
                new Product { Id = Guid.NewGuid(), Name = "SSD", Description = "500GB NVMe SSD", Price = 89.99m, ImageUrl = "/images/ssd.jpg", Category = "Storage" },
                new Product { Id = Guid.NewGuid(), Name = "Charger", Description = "Fast USB-C charger", Price = 29.99m, ImageUrl = "/images/charger.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Router", Description = "Wi-Fi 6 dual-band router", Price = 129.99m, ImageUrl = "/images/router.jpg", Category = "Networking" },
                new Product { Id = Guid.NewGuid(), Name = "Printer", Description = "All-in-one inkjet printer", Price = 149.99m, ImageUrl = "/images/printer.jpg", Category = "Office" },
                new Product { Id = Guid.NewGuid(), Name = "Desk Lamp", Description = "LED lamp with adjustable brightness", Price = 39.99m, ImageUrl = "/images/lamp.jpg", Category = "Home Office" },
                new Product { Id = Guid.NewGuid(), Name = "Office Chair", Description = "Ergonomic mesh office chair", Price = 199.99m, ImageUrl = "/images/chair.jpg", Category = "Furniture" },
                new Product { Id = Guid.NewGuid(), Name = "Backpack", Description = "Waterproof tech backpack", Price = 49.99m, ImageUrl = "/images/backpack.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Drone", Description = "Mini drone with camera", Price = 129.99m, ImageUrl = "/images/drone.jpg", Category = "Gadgets" },
                new Product { Id = Guid.NewGuid(), Name = "Tripod", Description = "Portable tripod for cameras", Price = 34.99m, ImageUrl = "/images/tripod.jpg", Category = "Accessories" },

                // 30 more generated to reach 50
                new Product { Id = Guid.NewGuid(), Name = "Camera", Description = "DSLR camera with lens kit", Price = 599.99m, ImageUrl = "/images/camera.jpg", Category = "Photography" },
                new Product { Id = Guid.NewGuid(), Name = "Coffee Maker", Description = "Programmable coffee maker", Price = 89.99m, ImageUrl = "/images/coffeemaker.jpg", Category = "Appliances" },
                new Product { Id = Guid.NewGuid(), Name = "Electric Kettle", Description = "1.7L cordless kettle", Price = 39.99m, ImageUrl = "/images/kettle.jpg", Category = "Kitchen" },
                new Product { Id = Guid.NewGuid(), Name = "Microwave Oven", Description = "Compact 700W microwave", Price = 119.99m, ImageUrl = "/images/microwave.jpg", Category = "Kitchen" },
                new Product { Id = Guid.NewGuid(), Name = "Blender", Description = "High-speed blender", Price = 59.99m, ImageUrl = "/images/blender.jpg", Category = "Kitchen" },
                new Product { Id = Guid.NewGuid(), Name = "Fitness Tracker", Description = "Tracks steps and heart rate", Price = 49.99m, ImageUrl = "/images/tracker.jpg", Category = "Wearables" },
                new Product { Id = Guid.NewGuid(), Name = "Projector", Description = "Portable mini projector", Price = 229.99m, ImageUrl = "/images/projector.jpg", Category = "Entertainment" },
                new Product { Id = Guid.NewGuid(), Name = "TV", Description = "Smart 55-inch 4K TV", Price = 599.99m, ImageUrl = "/images/tv.jpg", Category = "Entertainment" },
                new Product { Id = Guid.NewGuid(), Name = "Power Bank", Description = "10000mAh portable charger", Price = 29.99m, ImageUrl = "/images/powerbank.jpg", Category = "Accessories" },
                new Product { Id = Guid.NewGuid(), Name = "Fan", Description = "Oscillating pedestal fan", Price = 49.99m, ImageUrl = "/images/fan.jpg", Category = "Home" },

                new Product { Id = Guid.NewGuid(), Name = "Heater", Description = "Electric space heater", Price = 79.99m, ImageUrl = "/images/heater.jpg", Category = "Home" },
                new Product { Id = Guid.NewGuid(), Name = "Tool Kit", Description = "Household tool set", Price = 59.99m, ImageUrl = "/images/toolkit.jpg", Category = "Tools" },
                new Product { Id = Guid.NewGuid(), Name = "Screwdriver Set", Description = "Magnetic precision screwdriver set", Price = 24.99m, ImageUrl = "/images/screwdrivers.jpg", Category = "Tools" },
                new Product { Id = Guid.NewGuid(), Name = "Flashlight", Description = "Rechargeable LED flashlight", Price = 19.99m, ImageUrl = "/images/flashlight.jpg", Category = "Tools" },
                new Product { Id = Guid.NewGuid(), Name = "Air Purifier", Description = "HEPA filter air purifier", Price = 149.99m, ImageUrl = "/images/purifier.jpg", Category = "Home" },
                new Product { Id = Guid.NewGuid(), Name = "Vacuum Cleaner", Description = "Cordless stick vacuum", Price = 189.99m, ImageUrl = "/images/vacuum.jpg", Category = "Home" },
                new Product { Id = Guid.NewGuid(), Name = "Toaster", Description = "2-slice toaster with browning control", Price = 34.99m, ImageUrl = "/images/toaster.jpg", Category = "Kitchen" },
                new Product { Id = Guid.NewGuid(), Name = "Rice Cooker", Description = "Multi-function rice cooker", Price = 69.99m, ImageUrl = "/images/ricecooker.jpg", Category = "Kitchen" },
                new Product { Id = Guid.NewGuid(), Name = "Iron", Description = "Steam iron with anti-drip", Price = 39.99m, ImageUrl = "/images/iron.jpg", Category = "Appliances" },
                new Product { Id = Guid.NewGuid(), Name = "Hair Dryer", Description = "Professional hair dryer", Price = 49.99m, ImageUrl = "/images/hairdryer.jpg", Category = "Appliances" },

                new Product { Id = Guid.NewGuid(), Name = "Smart Light", Description = "Color-changing smart bulb", Price = 19.99m, ImageUrl = "/images/smartlight.jpg", Category = "Smart Home" },
                new Product { Id = Guid.NewGuid(), Name = "Security Camera", Description = "Wi-Fi home security camera", Price = 79.99m, ImageUrl = "/images/securitycam.jpg", Category = "Smart Home" },
                new Product { Id = Guid.NewGuid(), Name = "Streaming Stick", Description = "4K streaming media player", Price = 49.99m, ImageUrl = "/images/streamingstick.jpg", Category = "Entertainment" },
                new Product { Id = Guid.NewGuid(), Name = "Electric Shaver", Description = "Rechargeable electric shaver", Price = 59.99m, ImageUrl = "/images/shaver.jpg", Category = "Personal Care" },
                new Product { Id = Guid.NewGuid(), Name = "Toothbrush", Description = "Electric toothbrush with timer", Price = 29.99m, ImageUrl = "/images/toothbrush.jpg", Category = "Personal Care" }
            );
        }
    }
}
