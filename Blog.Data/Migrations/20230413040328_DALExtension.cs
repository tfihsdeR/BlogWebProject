using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6a713dd8-393d-4033-80c6-041b5823c0ec"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f7166286-1e73-4152-8945-1d9953e5ec2d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1beecc67-c0ae-4cae-b6c5-92460383787e"), new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nisl tincidunt eget nullam non nisi est sit. Sagittis id consectetur purus ut faucibus pulvinar elementum integer. Varius morbi enim nunc faucibus a pellentesque sit amet. Vulputate eu scelerisque felis imperdiet proin. Sed vulputate odio ut enim blandit. In massa tempor nec feugiat nisl pretium fusce id. In arcu cursus euismod quis. Sed turpis tincidunt id aliquet risus feugiat in ante metus. Et netus et malesuada fames ac turpis. Nec feugiat in fermentum posuere urna nec tincidunt praesent. Justo laoreet sit amet cursus sit amet dictum sit amet. Nunc aliquet bibendum enim facilisis gravida neque convallis. Ipsum consequat nisl vel pretium lectus quam id leo in. Imperdiet proin fermentum leo vel orci porta non pulvinar.\r\n\r\nSit amet luctus venenatis lectus magna fringilla. Odio morbi quis commodo odio aenean sed adipiscing. Congue quisque egestas diam in arcu cursus euismod quis. Porta nibh venenatis cras sed felis. Vel pretium lectus quam id leo in vitae turpis. Cum sociis natoque penatibus et magnis dis. Malesuada bibendum arcu vitae elementum curabitur vitae nunc sed velit. Pulvinar proin gravida hendrerit lectus a. Varius duis at consectetur lorem donec massa sapien faucibus et. Pretium lectus quam id leo in vitae turpis massa. Mauris sit amet massa vitae. Eget lorem dolor sed viverra ipsum. Mattis pellentesque id nibh tortor id. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Sit amet luctus venenatis lectus magna fringilla urna. Nibh ipsum consequat nisl vel pretium lectus. Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. In fermentum et sollicitudin ac orci phasellus. Mi tempus imperdiet nulla malesuada pellentesque elit. Tellus at urna condimentum mattis pellentesque id nibh.", "Admin Test", new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3279), null, null, new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"), false, null, null, "ASP.Net Core Deneme Makalesi", 15 },
                    { new Guid("a8241525-6679-4eba-a930-c73c8af7c58d"), new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim nulla aliquet porttitor lacus luctus accumsan tortor posuere. Integer quis auctor elit sed vulputate mi sit. Mi quis hendrerit dolor magna eget. Sed blandit libero volutpat sed cras ornare arcu. Ut etiam sit amet nisl purus in. Egestas sed tempus urna et. Diam maecenas sed enim ut sem viverra. Id consectetur purus ut faucibus pulvinar elementum. Nunc sed id semper risus in hendrerit gravida rutrum. Neque volutpat ac tincidunt vitae semper. Amet cursus sit amet dictum sit amet justo. Suscipit adipiscing bibendum est ultricies integer. Id nibh tortor id aliquet. Amet aliquam id diam maecenas. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper. Ipsum consequat nisl vel pretium lectus. Nunc sed id semper risus in hendrerit gravida rutrum. Quam viverra orci sagittis eu volutpat odio. Libero id faucibus nisl tincidunt eget nullam non.\r\n\r\nElementum nibh tellus molestie nunc non blandit massa enim nec. In fermentum posuere urna nec tincidunt praesent. Nunc sed augue lacus viverra vitae congue eu consequat. Tempus quam pellentesque nec nam aliquam sem et. Est ultricies integer quis auctor elit sed. Lacus luctus accumsan tortor posuere ac ut consequat semper viverra. Sapien pellentesque habitant morbi tristique senectus et netus. Et magnis dis parturient montes. Enim eu turpis egestas pretium aenean. Nisl purus in mollis nunc sed id semper. Arcu non odio euismod lacinia at quis risus sed vulputate. In est ante in nibh mauris cursus.", "Admin Test", new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3303), null, null, new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 13, 7, 3, 27, 992, DateTimeKind.Local).AddTicks(3632));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1beecc67-c0ae-4cae-b6c5-92460383787e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a8241525-6679-4eba-a930-c73c8af7c58d"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6a713dd8-393d-4033-80c6-041b5823c0ec"), new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim nulla aliquet porttitor lacus luctus accumsan tortor posuere. Integer quis auctor elit sed vulputate mi sit. Mi quis hendrerit dolor magna eget. Sed blandit libero volutpat sed cras ornare arcu. Ut etiam sit amet nisl purus in. Egestas sed tempus urna et. Diam maecenas sed enim ut sem viverra. Id consectetur purus ut faucibus pulvinar elementum. Nunc sed id semper risus in hendrerit gravida rutrum. Neque volutpat ac tincidunt vitae semper. Amet cursus sit amet dictum sit amet justo. Suscipit adipiscing bibendum est ultricies integer. Id nibh tortor id aliquet. Amet aliquam id diam maecenas. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper. Ipsum consequat nisl vel pretium lectus. Nunc sed id semper risus in hendrerit gravida rutrum. Quam viverra orci sagittis eu volutpat odio. Libero id faucibus nisl tincidunt eget nullam non.\r\n\r\nElementum nibh tellus molestie nunc non blandit massa enim nec. In fermentum posuere urna nec tincidunt praesent. Nunc sed augue lacus viverra vitae congue eu consequat. Tempus quam pellentesque nec nam aliquam sem et. Est ultricies integer quis auctor elit sed. Lacus luctus accumsan tortor posuere ac ut consequat semper viverra. Sapien pellentesque habitant morbi tristique senectus et netus. Et magnis dis parturient montes. Enim eu turpis egestas pretium aenean. Nisl purus in mollis nunc sed id semper. Arcu non odio euismod lacinia at quis risus sed vulputate. In est ante in nibh mauris cursus.", "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2033), null, null, new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"), false, null, null, "Visual Studio Deneme Makalesi", 15 },
                    { new Guid("f7166286-1e73-4152-8945-1d9953e5ec2d"), new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nisl tincidunt eget nullam non nisi est sit. Sagittis id consectetur purus ut faucibus pulvinar elementum integer. Varius morbi enim nunc faucibus a pellentesque sit amet. Vulputate eu scelerisque felis imperdiet proin. Sed vulputate odio ut enim blandit. In massa tempor nec feugiat nisl pretium fusce id. In arcu cursus euismod quis. Sed turpis tincidunt id aliquet risus feugiat in ante metus. Et netus et malesuada fames ac turpis. Nec feugiat in fermentum posuere urna nec tincidunt praesent. Justo laoreet sit amet cursus sit amet dictum sit amet. Nunc aliquet bibendum enim facilisis gravida neque convallis. Ipsum consequat nisl vel pretium lectus quam id leo in. Imperdiet proin fermentum leo vel orci porta non pulvinar.\r\n\r\nSit amet luctus venenatis lectus magna fringilla. Odio morbi quis commodo odio aenean sed adipiscing. Congue quisque egestas diam in arcu cursus euismod quis. Porta nibh venenatis cras sed felis. Vel pretium lectus quam id leo in vitae turpis. Cum sociis natoque penatibus et magnis dis. Malesuada bibendum arcu vitae elementum curabitur vitae nunc sed velit. Pulvinar proin gravida hendrerit lectus a. Varius duis at consectetur lorem donec massa sapien faucibus et. Pretium lectus quam id leo in vitae turpis massa. Mauris sit amet massa vitae. Eget lorem dolor sed viverra ipsum. Mattis pellentesque id nibh tortor id. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Sit amet luctus venenatis lectus magna fringilla urna. Nibh ipsum consequat nisl vel pretium lectus. Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. In fermentum et sollicitudin ac orci phasellus. Mi tempus imperdiet nulla malesuada pellentesque elit. Tellus at urna condimentum mattis pellentesque id nibh.", "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2020), null, null, new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"), false, null, null, "ASP.Net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2375));
        }
    }
}
