using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "ASP.Net Core Deneme Makalesi",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Nisl tincidunt eget nullam non nisi est sit. Sagittis id consectetur purus ut faucibus pulvinar elementum integer. Varius morbi enim nunc faucibus a pellentesque sit amet. Vulputate eu scelerisque felis imperdiet proin. Sed vulputate odio ut enim blandit. In massa tempor nec feugiat nisl pretium fusce id. In arcu cursus euismod quis. Sed turpis tincidunt id aliquet risus feugiat in ante metus. Et netus et malesuada fames ac turpis. Nec feugiat in fermentum posuere urna nec tincidunt praesent. Justo laoreet sit amet cursus sit amet dictum sit amet. Nunc aliquet bibendum enim facilisis gravida neque convallis. Ipsum consequat nisl vel pretium lectus quam id leo in. Imperdiet proin fermentum leo vel orci porta non pulvinar.\r\n\r\nSit amet luctus venenatis lectus magna fringilla. Odio morbi quis commodo odio aenean sed adipiscing. Congue quisque egestas diam in arcu cursus euismod quis. Porta nibh venenatis cras sed felis. Vel pretium lectus quam id leo in vitae turpis. Cum sociis natoque penatibus et magnis dis. Malesuada bibendum arcu vitae elementum curabitur vitae nunc sed velit. Pulvinar proin gravida hendrerit lectus a. Varius duis at consectetur lorem donec massa sapien faucibus et. Pretium lectus quam id leo in vitae turpis massa. Mauris sit amet massa vitae. Eget lorem dolor sed viverra ipsum. Mattis pellentesque id nibh tortor id. Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Sit amet luctus venenatis lectus magna fringilla urna. Nibh ipsum consequat nisl vel pretium lectus. Maecenas volutpat blandit aliquam etiam erat velit scelerisque in dictum. In fermentum et sollicitudin ac orci phasellus. Mi tempus imperdiet nulla malesuada pellentesque elit. Tellus at urna condimentum mattis pellentesque id nibh.",
                ViewCount = 15,
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = Guid.Parse("1ADF36F5-41A5-46F9-9852-A871B8471DE2"),
                ImageId = Guid.Parse("25467E98-6EB6-4021-B9C8-A59FAFCF8D4E")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim nulla aliquet porttitor lacus luctus accumsan tortor posuere. Integer quis auctor elit sed vulputate mi sit. Mi quis hendrerit dolor magna eget. Sed blandit libero volutpat sed cras ornare arcu. Ut etiam sit amet nisl purus in. Egestas sed tempus urna et. Diam maecenas sed enim ut sem viverra. Id consectetur purus ut faucibus pulvinar elementum. Nunc sed id semper risus in hendrerit gravida rutrum. Neque volutpat ac tincidunt vitae semper. Amet cursus sit amet dictum sit amet justo. Suscipit adipiscing bibendum est ultricies integer. Id nibh tortor id aliquet. Amet aliquam id diam maecenas. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper. Ipsum consequat nisl vel pretium lectus. Nunc sed id semper risus in hendrerit gravida rutrum. Quam viverra orci sagittis eu volutpat odio. Libero id faucibus nisl tincidunt eget nullam non.\r\n\r\nElementum nibh tellus molestie nunc non blandit massa enim nec. In fermentum posuere urna nec tincidunt praesent. Nunc sed augue lacus viverra vitae congue eu consequat. Tempus quam pellentesque nec nam aliquam sem et. Est ultricies integer quis auctor elit sed. Lacus luctus accumsan tortor posuere ac ut consequat semper viverra. Sapien pellentesque habitant morbi tristique senectus et netus. Et magnis dis parturient montes. Enim eu turpis egestas pretium aenean. Nisl purus in mollis nunc sed id semper. Arcu non odio euismod lacinia at quis risus sed vulputate. In est ante in nibh mauris cursus.",
                ViewCount = 15,
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = Guid.Parse("CA10CFA7-CF30-4053-9720-9CFA4F360729"),
                ImageId = Guid.Parse("3EB17BEA-7000-4DE8-BAA9-E40916F61FA9")
            });
        }
    }
}
