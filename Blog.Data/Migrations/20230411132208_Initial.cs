using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"), "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2224), null, null, false, null, null, "ASP.Net Core" },
                    { new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"), "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2227), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"), "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2372), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"), "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2375), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6a713dd8-393d-4033-80c6-041b5823c0ec"), new Guid("ca10cfa7-cf30-4053-9720-9cfa4f360729"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim nulla aliquet porttitor lacus luctus accumsan tortor posuere. Integer quis auctor elit sed vulputate mi sit. Mi quis hendrerit dolor magna eget. Sed blandit libero volutpat sed cras ornare arcu. Ut etiam sit amet nisl purus in. Egestas sed tempus urna et. Diam maecenas sed enim ut sem viverra. Id consectetur purus ut faucibus pulvinar elementum. Nunc sed id semper risus in hendrerit gravida rutrum. Neque volutpat ac tincidunt vitae semper. Amet cursus sit amet dictum sit amet justo. Suscipit adipiscing bibendum est ultricies integer. Id nibh tortor id aliquet. Amet aliquam id diam maecenas. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper. Ipsum consequat nisl vel pretium lectus. Nunc sed id semper risus in hendrerit gravida rutrum. Quam viverra orci sagittis eu volutpat odio. Libero id faucibus nisl tincidunt eget nullam non.\r\n\r\nElementum nibh tellus molestie nunc non blandit massa enim nec. In fermentum posuere urna nec tincidunt praesent. Nunc sed augue lacus viverra vitae congue eu consequat. Tempus quam pellentesque nec nam aliquam sem et. Est ultricies integer quis auctor elit sed. Lacus luctus accumsan tortor posuere ac ut consequat semper viverra. Sapien pellentesque habitant morbi tristique senectus et netus. Et magnis dis parturient montes. Enim eu turpis egestas pretium aenean. Nisl purus in mollis nunc sed id semper. Arcu non odio euismod lacinia at quis risus sed vulputate. In est ante in nibh mauris cursus.", "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2033), null, null, new Guid("3eb17bea-7000-4de8-baa9-e40916f61fa9"), false, null, null, "Visual Studio Deneme Makalesi", 15 },
                    { new Guid("f7166286-1e73-4152-8945-1d9953e5ec2d"), new Guid("1adf36f5-41a5-46f9-9852-a871b8471de2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nisl tincidunt eget nullam non nisi est sit. Sagittis id consectetur purus ut faucibus pulvinar elementum integer. Varius morbi enim nunc faucibus a pellentesque sit amet. Vulputate eu scelerisque felis imperdiet proin. Sed vulputate odio ut enim blandit. In massa tempor nec feugiat nisl pretium fusce id. In arcu cursus euismod quis. Sed turpis tincidunt id aliquet risus feugiat in ante metus. Et netus et malesuada fames ac turpis. Nec feugiat in fermentum posuere urna nec tincidunt praesent. Justo laoreet sit amet cursus sit amet dictum sit amet. Nunc aliquet bibendum enim facilisis gravida neque convallis. Ipsum consequat nisl vel pretium lectus quam id leo in. Imperdiet proin fermentum leo vel orci porta non pulvinar.\r\n\r\nSit amet luctus venenatis lectus magna fringilla. Odio morbi quis commodo odio aenean sed adipiscing. Congue quisque egestas diam in arcu cursus euismod quis. Porta nibh venenatis cras sed felis. Vel pretium lectus quam id leo in vitae turpis. Cum sociis natoque penatibus et magnis dis. Malesuada bibendum arcu vitae elementum curabitur vitae nunc sed velit. Pulvinar proin gravida hendrerit lectus a. Varius duis at consectetur lorem donec massa sapien faucibus et. Pretium lectus quam id leo in vitae turpis massa. Mauris sit amet massa vitae. Eget lorem dolor sed viverra ipsum. Mattis pellentesque id nibh tortor id. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Sit amet luctus venenatis lectus magna fringilla urna. Nibh ipsum consequat nisl vel pretium lectus. Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. In fermentum et sollicitudin ac orci phasellus. Mi tempus imperdiet nulla malesuada pellentesque elit. Tellus at urna condimentum mattis pellentesque id nibh.", "Admin Test", new DateTime(2023, 4, 11, 16, 22, 8, 537, DateTimeKind.Local).AddTicks(2020), null, null, new Guid("25467e98-6eb6-4021-b9c8-a59fafcf8d4e"), false, null, null, "ASP.Net Core Deneme Makalesi", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
