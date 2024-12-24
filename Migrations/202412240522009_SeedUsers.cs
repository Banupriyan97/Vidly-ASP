namespace Vidly_ASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'61ce9541-0a1d-4ef4-b156-3c960b4de94a', N'admin@vidly.com', 0, N'AE7r1G34XbwX7qD8INRRUjEn/o9vK6RSvr/lGDAfl5SoVjAoTta1t9PtuhrvrzOyaQ==', N'c33525e2-8f0a-4d7f-9ee2-b079dfdaad0d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'baebd85a-f0da-4aaf-b23a-e04b9e8b9829', N'guest@vidly.com', 0, N'AP25jKHb/Zeq1faeQqN4A0qQJSKo3FmbAdxblObHLK+faB9vNxTvSZhv5jhoxxJM2w==', N'216ce59f-809c-4dce-9739-bd4badca7d21', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9e82d264-4753-447b-a581-254722cd7052', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'61ce9541-0a1d-4ef4-b156-3c960b4de94a', N'9e82d264-4753-447b-a581-254722cd7052')

");
        }
        
        public override void Down()
        {
        }
    }
}
