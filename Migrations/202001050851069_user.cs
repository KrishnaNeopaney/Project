namespace Krish.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'18079238-e97e-4e80-b526-620966e58b5b', N'lisa@ucsm.com', 0, N'AI6uSyUQZ0sGfmDT19T6Ve8Vkp/k7CxlHcj60IvcL0c/AQbgjrf+fA4omxC7d7Rd5A==', N'dc7914ba-bac3-4664-8c90-0568c6bf22ab', NULL, 0, 0, NULL, 1, 0, N'lisa@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36e5c65d-3c16-4aff-863d-1810b4aaa3c4', N'kelvin@ucsm.com', 0, N'AOw+LXpVQ/z7Y/LfXgpJQ70kXSFhL5K5zkHAkjkOev0UXm3Z0YzpKqf2O5Z1b2745A==', N'd708f364-dea4-497a-a851-767281cbb089', NULL, 0, 0, NULL, 1, 0, N'kelvin@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5fd1c5f3-d372-44f7-bf9b-1bb8a776b1e3', N'parakash@ucsm.com', 0, N'AKtXGZb6tzhq7njDQTO4HTB97a9A9Nx/0su4qJ8/RyI5JkANWwFtMpEhArmNmpgB7g==', N'3884fcc6-bd93-47a5-89e9-53c3e355b400', NULL, 0, 0, NULL, 1, 0, N'parakash@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'661f2a65-dc52-4783-aa50-3f161b1d15a1', N'kenny@ucsm.com', 0, N'AOl9noQd++9SXv0i1LwzyutWuLHnEkdfnBY0X2rHXvHUXB+pxy0zXv7vmr+c+1bwtg==', N'd6edf849-6dee-48fb-a30a-0b5ad519e737', NULL, 0, 0, NULL, 1, 0, N'kenny@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'809bfc23-97fe-45a1-ba1c-3a189f32a7c8', N'json@ucsm.com', 0, N'APkmASJLDdjKKwN/uznRCHPWPkDu9bQRLsX0cyreMjbLo3KOOzfiZe1W663w/M7G3A==', N'b0f86c13-2339-4991-9d16-2c1a1c4b85b4', NULL, 0, 0, NULL, 1, 0, N'json@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'834bd69b-37c8-4de9-b301-de6b44f6ac74', N'sean@ucsm.com', 0, N'ACdh1uoXO+nX+G/IWlaRRMWI3wgttWMdWNj0OTQ+fNhYLDcS/g76NBvDNiQkElJsTA==', N'04e1c81e-5f7f-4d4b-a0c2-caddb44b8bc4', NULL, 0, 0, NULL, 1, 0, N'sean@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'882fc760-3ef0-40f3-9573-a1db52422aac', N'hein@ucsm.com', 0, N'ABjteD3fUkzumty2CDLaXibXpgcOZW+12abADr1fY5PBbswLXtQEFjTcS3WBXFlHzQ==', N'9abd05d9-dec6-4fb9-afc4-b5f682cfd3cc', NULL, 0, 0, NULL, 1, 0, N'hein@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b86ffcc-597e-4a33-85eb-b23239d61eb6', N'carol@ucsm.com', 0, N'AE2ZLPjPRoCb9NR3NvBosUKwsZ/4awAoiYw7bM5rOXCUJFnkUC1p/08y6wFgxj8fBg==', N'915bd73e-af7a-4ccc-b24e-220fba1d7f00', NULL, 0, 0, NULL, 1, 0, N'carol@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ae471cff-fe77-44bf-9aa1-0258993e23b6', N'admin@ucsm.com', 0, N'AIOsNs5Kd1hqHSQY2NJXG2/uaw4QTgJe//bd2sAq9t0ebbvjE4Yc8c1wkYfuAKlKqQ==', N'c1736d10-9a58-4095-af0b-d4c2fc394911', NULL, 0, 0, NULL, 1, 0, N'admin@ucsm.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eef8b0e3-86cb-48ca-a8c8-d5c367c20dce', N'john@ucsm.com', 0, N'AAgEhPc8eBWWOq05SFQdc4RoKKfl0xrzwUHftDKge9H9ueTwDapFQE8feePoBT4e3g==', N'd86b5ee9-bcc6-4923-bfd8-30bed4f6c740', NULL, 0, 0, NULL, 1, 0, N'john@ucsm.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b8551e68-3dde-40c4-a4f3-4d6e49ada316', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ae471cff-fe77-44bf-9aa1-0258993e23b6', N'b8551e68-3dde-40c4-a4f3-4d6e49ada316')



");
        }
        
        public override void Down()
        {
        }
    }
}
