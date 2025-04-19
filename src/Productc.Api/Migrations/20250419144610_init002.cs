using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Productc.Api.Migrations
{
    /// <inheritdoc />
    public partial class init002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00dc9ea1-de59-4367-8f19-d93aa43976fb"), "Accessories", "1080p HD webcam for streaming", "/images/webcam.jpg", "Webcam", 59.99m },
                    { new Guid("088c129f-3590-4c9e-a0c1-35066b92806f"), "Accessories", "Fast USB-C charger", "/images/charger.jpg", "Charger", 29.99m },
                    { new Guid("0c69b913-1eb5-42b9-b7ce-256d858f7bfa"), "Kitchen", "Multi-function rice cooker", "/images/ricecooker.jpg", "Rice Cooker", 69.99m },
                    { new Guid("1223d05d-1025-4a43-a016-cdcacbca26f3"), "Home Office", "LED lamp with adjustable brightness", "/images/lamp.jpg", "Desk Lamp", 39.99m },
                    { new Guid("14fe2f8a-496a-4c05-8cb4-16192b1f7fe8"), "Home", "Cordless stick vacuum", "/images/vacuum.jpg", "Vacuum Cleaner", 189.99m },
                    { new Guid("15f6d37e-35a3-4926-a8ed-8ecdc4f4cb74"), "Accessories", "Ergonomic RGB gaming mouse", "/images/mouse.jpg", "Gaming Mouse", 49.99m },
                    { new Guid("17b8340c-2cac-4116-970c-5da3e4c0c9ce"), "Audio", "Portable waterproof speaker", "/images/speaker.jpg", "Bluetooth Speaker", 79.99m },
                    { new Guid("2b7dcd55-3657-44fc-9cc5-ea3ea847e9b3"), "Accessories", "10000mAh portable charger", "/images/powerbank.jpg", "Power Bank", 29.99m },
                    { new Guid("2fecc3d8-037e-4b51-a121-fad081ca2296"), "Appliances", "Steam iron with anti-drip", "/images/iron.jpg", "Iron", 39.99m },
                    { new Guid("309baed5-2e2e-43f5-baa1-d6a2b7dae002"), "Storage", "1TB USB 3.0 drive", "/images/hdd.jpg", "External Hard Drive", 69.99m },
                    { new Guid("35b86b13-5ba2-4612-91d9-c63809d03079"), "Electronics", "Noise-cancelling headphones", "/images/headphones.jpg", "Headphones", 199.99m },
                    { new Guid("43e9b598-7060-48bb-8895-e6055df457e0"), "Accessories", "Mechanical keyboard with RGB", "/images/keyboard.jpg", "Keyboard", 89.99m },
                    { new Guid("43f1887e-a0b2-4132-b587-7ccf5a3a6197"), "Wearables", "Fitness and health tracking", "/images/smartwatch.jpg", "Smartwatch", 159.99m },
                    { new Guid("4575d5ad-2379-4abb-81df-8c1e9a2d1eee"), "Electronics", "Powerful laptop with 16GB RAM", "/images/laptop.jpg", "Laptop", 1200.99m },
                    { new Guid("457698b2-ac8c-44bc-adc2-7aec139b0490"), "Entertainment", "4K streaming media player", "/images/streamingstick.jpg", "Streaming Stick", 49.99m },
                    { new Guid("4fcec8bf-4574-4384-a468-43d94ddf0761"), "Smart Home", "Color-changing smart bulb", "/images/smartlight.jpg", "Smart Light", 19.99m },
                    { new Guid("525d9950-d43b-49a6-a870-2b9cef86910e"), "Accessories", "Portable tripod for cameras", "/images/tripod.jpg", "Tripod", 34.99m },
                    { new Guid("5272cdea-51a8-4355-b622-172d9d7874d7"), "Gadgets", "Mini drone with camera", "/images/drone.jpg", "Drone", 129.99m },
                    { new Guid("58310f55-2555-4f96-b6fa-1e7b91ce5818"), "Photography", "DSLR camera with lens kit", "/images/camera.jpg", "Camera", 599.99m },
                    { new Guid("5da81ded-36d4-49b0-8278-e2e3856a3bc5"), "Personal Care", "Electric toothbrush with timer", "/images/toothbrush.jpg", "Toothbrush", 29.99m },
                    { new Guid("5ea21a07-e6c0-4013-a4af-c4f638e47b4e"), "Furniture", "Ergonomic mesh office chair", "/images/chair.jpg", "Office Chair", 199.99m },
                    { new Guid("6491570f-e6db-4e75-874d-94a6c932b168"), "Appliances", "Programmable coffee maker", "/images/coffeemaker.jpg", "Coffee Maker", 89.99m },
                    { new Guid("68d9cddd-872f-4427-bde2-6147e6ed0e08"), "Kitchen", "Compact 700W microwave", "/images/microwave.jpg", "Microwave Oven", 119.99m },
                    { new Guid("7620436d-23a3-446e-9fbd-30075f8b3f30"), "Personal Care", "Rechargeable electric shaver", "/images/shaver.jpg", "Electric Shaver", 59.99m },
                    { new Guid("7984158e-5e4d-4b08-a99a-f52a67aa78da"), "Kitchen", "1.7L cordless kettle", "/images/kettle.jpg", "Electric Kettle", 39.99m },
                    { new Guid("83330713-fe2b-4c7a-a1ad-600d3044b4e5"), "Tools", "Magnetic precision screwdriver set", "/images/screwdrivers.jpg", "Screwdriver Set", 24.99m },
                    { new Guid("83c1b0b7-b62d-4966-a710-258c7a7e9c17"), "Electronics", "10-inch Android tablet", "/images/tablet.jpg", "Tablet", 299.99m },
                    { new Guid("83f4d044-f848-4f4d-9f8d-1cb93afd3b4e"), "Kitchen", "2-slice toaster with browning control", "/images/toaster.jpg", "Toaster", 34.99m },
                    { new Guid("93d94e2b-708f-484b-80fa-a027140df751"), "Accessories", "Waterproof tech backpack", "/images/backpack.jpg", "Backpack", 49.99m },
                    { new Guid("95fd2a84-cb0c-4fa9-b228-228492d2b022"), "Kitchen", "High-speed blender", "/images/blender.jpg", "Blender", 59.99m },
                    { new Guid("99769a89-7114-499f-8326-e1abdbbcf65a"), "Entertainment", "Portable mini projector", "/images/projector.jpg", "Projector", 229.99m },
                    { new Guid("9a352eec-d8f0-4ce6-ad19-0ca378d5ed06"), "Appliances", "Professional hair dryer", "/images/hairdryer.jpg", "Hair Dryer", 49.99m },
                    { new Guid("9b271f98-55c8-4382-9423-ca15dd1a2056"), "Networking", "Wi-Fi 6 dual-band router", "/images/router.jpg", "Router", 129.99m },
                    { new Guid("9fc1b483-6940-4678-ba8d-09d6bd53b190"), "Electronics", "27-inch 4K UHD monitor", "/images/monitor.jpg", "Monitor", 349.99m },
                    { new Guid("a1682c07-e367-46e7-aaec-2682025048ac"), "Wearables", "Tracks steps and heart rate", "/images/tracker.jpg", "Fitness Tracker", 49.99m },
                    { new Guid("a1a17ce4-5190-44a0-bcd2-917360573112"), "Electronics", "Latest model smartphone", "/images/smartphone.jpg", "Smartphone", 899.50m },
                    { new Guid("a82a9924-3e25-4e9c-86bb-e3e76c323863"), "Storage", "500GB NVMe SSD", "/images/ssd.jpg", "SSD", 89.99m },
                    { new Guid("c61ae7ba-a860-49f3-8716-7f59e305376b"), "Smart Home", "Wi-Fi home security camera", "/images/securitycam.jpg", "Security Camera", 79.99m },
                    { new Guid("cb3ceb2b-d0b9-439f-b22d-c703050c1812"), "Office", "All-in-one inkjet printer", "/images/printer.jpg", "Printer", 149.99m },
                    { new Guid("d1d3336c-8ae5-4637-ac6b-f0aad2133780"), "Home", "HEPA filter air purifier", "/images/purifier.jpg", "Air Purifier", 149.99m },
                    { new Guid("ec4cca39-c6bd-433b-b1fd-8445d9df1d9b"), "Entertainment", "Smart 55-inch 4K TV", "/images/tv.jpg", "TV", 599.99m },
                    { new Guid("f072ff63-680e-459f-890c-ed89077bf791"), "Tools", "Household tool set", "/images/toolkit.jpg", "Tool Kit", 59.99m },
                    { new Guid("fb75f465-080c-488e-a9ea-fba224531d90"), "Home", "Electric space heater", "/images/heater.jpg", "Heater", 79.99m },
                    { new Guid("fd02223c-19ea-49f5-9a90-5a3e1ad2897f"), "Home", "Oscillating pedestal fan", "/images/fan.jpg", "Fan", 49.99m },
                    { new Guid("fd241b22-d84b-4aec-b784-9bac9052d593"), "Tools", "Rechargeable LED flashlight", "/images/flashlight.jpg", "Flashlight", 19.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00dc9ea1-de59-4367-8f19-d93aa43976fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("088c129f-3590-4c9e-a0c1-35066b92806f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c69b913-1eb5-42b9-b7ce-256d858f7bfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1223d05d-1025-4a43-a016-cdcacbca26f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("14fe2f8a-496a-4c05-8cb4-16192b1f7fe8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15f6d37e-35a3-4926-a8ed-8ecdc4f4cb74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17b8340c-2cac-4116-970c-5da3e4c0c9ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b7dcd55-3657-44fc-9cc5-ea3ea847e9b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fecc3d8-037e-4b51-a121-fad081ca2296"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("309baed5-2e2e-43f5-baa1-d6a2b7dae002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35b86b13-5ba2-4612-91d9-c63809d03079"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43e9b598-7060-48bb-8895-e6055df457e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43f1887e-a0b2-4132-b587-7ccf5a3a6197"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4575d5ad-2379-4abb-81df-8c1e9a2d1eee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("457698b2-ac8c-44bc-adc2-7aec139b0490"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4fcec8bf-4574-4384-a468-43d94ddf0761"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("525d9950-d43b-49a6-a870-2b9cef86910e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5272cdea-51a8-4355-b622-172d9d7874d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58310f55-2555-4f96-b6fa-1e7b91ce5818"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5da81ded-36d4-49b0-8278-e2e3856a3bc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ea21a07-e6c0-4013-a4af-c4f638e47b4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6491570f-e6db-4e75-874d-94a6c932b168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68d9cddd-872f-4427-bde2-6147e6ed0e08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7620436d-23a3-446e-9fbd-30075f8b3f30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7984158e-5e4d-4b08-a99a-f52a67aa78da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83330713-fe2b-4c7a-a1ad-600d3044b4e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83c1b0b7-b62d-4966-a710-258c7a7e9c17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83f4d044-f848-4f4d-9f8d-1cb93afd3b4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93d94e2b-708f-484b-80fa-a027140df751"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95fd2a84-cb0c-4fa9-b228-228492d2b022"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99769a89-7114-499f-8326-e1abdbbcf65a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a352eec-d8f0-4ce6-ad19-0ca378d5ed06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b271f98-55c8-4382-9423-ca15dd1a2056"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fc1b483-6940-4678-ba8d-09d6bd53b190"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1682c07-e367-46e7-aaec-2682025048ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1a17ce4-5190-44a0-bcd2-917360573112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a82a9924-3e25-4e9c-86bb-e3e76c323863"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c61ae7ba-a860-49f3-8716-7f59e305376b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb3ceb2b-d0b9-439f-b22d-c703050c1812"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1d3336c-8ae5-4637-ac6b-f0aad2133780"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec4cca39-c6bd-433b-b1fd-8445d9df1d9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f072ff63-680e-459f-890c-ed89077bf791"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb75f465-080c-488e-a9ea-fba224531d90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd02223c-19ea-49f5-9a90-5a3e1ad2897f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd241b22-d84b-4aec-b784-9bac9052d593"));
        }
    }
}
