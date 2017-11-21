namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'052cb8e1-c561-4f19-b3a8-8ad5132086d0', N'admin@gmail.com', 0, N'AOlXlIu/4f1E+ppmiFUJRuAQuSu9npDO2iMOIOx5cCGeSihgyVLrU71g6E9opIGHwQ==', N'3672088e-2ba5-4f04-ab06-91e36619f523', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68bd31ad-beda-44fe-b03a-133099f25461', N'comum@gmail.com', 0, N'AEOqNPXBhhbT+dehvLaQpFuH5bLsOcVryOX3X122HxEuDQ+LYI4BvuyG4ZV9l0GpoA==', N'338f4a65-1346-4af9-9e20-af1b00c15b7f', NULL, 0, 0, NULL, 1, 0, N'comum@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'64394be0-f428-4a14-ae22-0498fe89f2b3', N'CanManageData')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'052cb8e1-c561-4f19-b3a8-8ad5132086d0', N'64394be0-f428-4a14-ae22-0498fe89f2b3')

");
        }
        
        public override void Down()
        {
        }
    }
}
