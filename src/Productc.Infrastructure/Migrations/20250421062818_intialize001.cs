using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Productc.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intialize001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "IsDeleted", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0a85214b-196b-4606-ba95-940aef53a229"), "Entertainment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4K streaming media player", "/images/streamingstick.jpg", false, "Streaming Stick", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d6b49cf-1bbf-4bac-96ef-7d468d76db4a"), "Tools", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnetic precision screwdriver set", "/images/screwdrivers.jpg", false, "Screwdriver Set", 24.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1005d4ee-73cd-4b2a-a485-8b18e7fffe21"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-function rice cooker", "/images/ricecooker.jpg", false, "Rice Cooker", 69.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1247b855-0ade-4b0c-beb4-fe86c2486a80"), "Tools", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rechargeable LED flashlight", "/images/flashlight.jpg", false, "Flashlight", 19.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1344017d-fbdc-4007-bf26-d9b29b00ee52"), "Smart Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wi-Fi home security camera", "/images/securitycam.jpg", false, "Security Camera", 79.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14b23867-0427-479f-be37-d2c43ea58ad5"), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Powerful laptop with 16GB RAM", "/images/laptop.jpg", false, "Laptop", 1200.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b49186f-9fce-4c53-acc3-f737f80dc5e1"), "Office", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "All-in-one inkjet printer", "/images/printer.jpg", false, "Printer", 149.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28d93672-89dd-4042-8e05-b6d0bd7ef87c"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-speed blender", "/images/blender.jpg", false, "Blender", 59.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c8da045-9a52-49e5-8184-5c31850c5a4e"), "Entertainment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portable mini projector", "/images/projector.jpg", false, "Projector", 229.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32f648e7-302a-4f28-a61a-6b815cc91d9f"), "Wearables", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fitness and health tracking", "/images/smartwatch.jpg", false, "Smartwatch", 159.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39e258a5-4f19-4cf7-aec6-79b8e5598a34"), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10-inch Android tablet", "/images/tablet.jpg", false, "Tablet", 299.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47bcc66f-1d6c-4f8b-8f5c-25ab13285071"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast USB-C charger", "/images/charger.jpg", false, "Charger", 29.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b7d6da3-ca01-44ca-b072-5f4be3b969e6"), "Audio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portable waterproof speaker", "/images/speaker.jpg", false, "Bluetooth Speaker", 79.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5216746d-47cf-4f87-b45d-77b375fe69df"), "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cordless stick vacuum", "/images/vacuum.jpg", false, "Vacuum Cleaner", 189.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52b919a6-c75d-4cc4-b4f3-4de0aa5f2079"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic mesh office chair", "/images/chair.jpg", false, "Office Chair", 199.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54791ee7-2b13-4ba6-bfd1-51ee525e66f1"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mechanical keyboard with RGB", "/images/keyboard.jpg", false, "Keyboard", 89.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d247699-e967-4402-aae7-7684067fc639"), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latest model smartphone", "/images/smartphone.jpg", false, "Smartphone", 899.50m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("625c08e9-6566-4022-96bd-1af13da67833"), "Storage", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "500GB NVMe SSD", "/images/ssd.jpg", false, "SSD", 89.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6594ffaf-cd8c-4507-a80a-8083c9d0b3d0"), "Entertainment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smart 55-inch 4K TV", "/images/tv.jpg", false, "TV", 599.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("708fc674-82da-4a30-9ae9-9f55e0bed9ae"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portable tripod for cameras", "/images/tripod.jpg", false, "Tripod", 34.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ada0ae4-1c87-47b6-bec4-6fba1fe4982d"), "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscillating pedestal fan", "/images/fan.jpg", false, "Fan", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7afec4a5-9c77-4168-bee5-20556a1719d7"), "Appliances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steam iron with anti-drip", "/images/iron.jpg", false, "Iron", 39.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ddca6aa-5abb-47b9-b28e-e2794844db98"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.7L cordless kettle", "/images/kettle.jpg", false, "Electric Kettle", 39.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83fe2da9-1fa6-4ec7-88eb-a66aa6f0963e"), "Smart Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color-changing smart bulb", "/images/smartlight.jpg", false, "Smart Light", 19.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d09021f-0e52-4f31-b70e-4db07a7a5d06"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2-slice toaster with browning control", "/images/toaster.jpg", false, "Toaster", 34.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e555136-60d5-4c83-a561-54a34a39f50c"), "Storage", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1TB USB 3.0 drive", "/images/hdd.jpg", false, "External Hard Drive", 69.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90db36e2-4dbb-496c-b49b-22476c81bacf"), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DSLR camera with lens kit", "/images/camera.jpg", false, "Camera", 599.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9551696b-4e79-4d2e-8744-1934b7878777"), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27-inch 4K UHD monitor", "/images/monitor.jpg", false, "Monitor", 349.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bcab733-d2ae-4748-9596-2f01358318d4"), "Tools", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Household tool set", "/images/toolkit.jpg", false, "Tool Kit", 59.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c723bb4-3c0d-4114-b0fa-f5439cae3490"), "Wearables", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tracks steps and heart rate", "/images/tracker.jpg", false, "Fitness Tracker", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6af424d-f0e7-4c39-852e-5560fccc2a25"), "Personal Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rechargeable electric shaver", "/images/shaver.jpg", false, "Electric Shaver", 59.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a795d5cc-fac4-47ac-a2a1-a1bc3d809549"), "Home Office", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LED lamp with adjustable brightness", "/images/lamp.jpg", false, "Desk Lamp", 39.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af9fce44-a892-4fdc-8446-bcd98ae2cf72"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compact 700W microwave", "/images/microwave.jpg", false, "Microwave Oven", 119.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b742d2f0-55ba-40ad-b080-f3181d50150b"), "Networking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wi-Fi 6 dual-band router", "/images/router.jpg", false, "Router", 129.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba393abb-d394-4598-9e80-320a57b830df"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waterproof tech backpack", "/images/backpack.jpg", false, "Backpack", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c37f358a-9cb1-4279-8ee5-e03aa3485edc"), "Appliances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professional hair dryer", "/images/hairdryer.jpg", false, "Hair Dryer", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3fc2c37-e2a6-474a-bf4f-cfbea7a42e42"), "Gadgets", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mini drone with camera", "/images/drone.jpg", false, "Drone", 129.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c86a40f1-47e7-4083-9cb5-bcf62927e641"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1080p HD webcam for streaming", "/images/webcam.jpg", false, "Webcam", 59.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8cbdfd5-2bfc-40e1-bdf5-16cc3afe9338"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic RGB gaming mouse", "/images/mouse.jpg", false, "Gaming Mouse", 49.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc4e9278-2e29-4447-b322-c3c34de5040a"), "Appliances", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programmable coffee maker", "/images/coffeemaker.jpg", false, "Coffee Maker", 89.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb05e902-890d-40ce-b8b7-b7d2b7e5fcba"), "Personal Care", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric toothbrush with timer", "/images/toothbrush.jpg", false, "Toothbrush", 29.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef0fed9f-c7eb-4bb9-be16-3ffee170ee6d"), "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HEPA filter air purifier", "/images/purifier.jpg", false, "Air Purifier", 149.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f08947ac-d588-4182-8d5c-bbb41306b952"), "Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noise-cancelling headphones", "/images/headphones.jpg", false, "Headphones", 199.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7919d34-98fb-4ac6-9f1b-83b4058f3a0b"), "Accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "10000mAh portable charger", "/images/powerbank.jpg", false, "Power Bank", 29.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f94b53ee-e1b4-4ec0-9236-17fd60f48df8"), "Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric space heater", "/images/heater.jpg", false, "Heater", 79.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
