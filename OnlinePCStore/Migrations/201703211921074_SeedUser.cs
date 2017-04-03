namespace OnlinePCStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1c415aef-2eee-489e-9ed1-19f3956d0ac2', N'guest@pc.com', 0, N'AM0iIYlJSdTwuybAWhbny4sWWRvBvk+VDVi32uAeN9+1Y6aC1I7Sl7V+j/6CoUr82Q==', N'84f37517-cdba-4a82-9fff-bbf4f45e72b6', NULL, 0, 0, NULL, 1, 0, N'guest@pc.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1fa177ca-0739-44dd-bf14-b1d824a3d993', N'admin@pc.com', 0, N'AAVcDHdyfrSa9ABG1ZwiXQGWeFcXTRwOrYz4PXhiHqlkzZtF5Bi27HAZJHA8zpnniQ==', N'37995227-b934-46ab-913e-57172512665c', NULL, 0, 0, NULL, 1, 0, N'admin@pc.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f68fd77d-9a56-4d00-b152-b9c459b99a83', N'CanManageProduct')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1fa177ca-0739-44dd-bf14-b1d824a3d993', N'f68fd77d-9a56-4d00-b152-b9c459b99a83')
");
        }
        
        public override void Down()
        {
        }
    }
}
