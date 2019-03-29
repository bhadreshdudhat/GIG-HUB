namespace GIG_HUB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotification1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserNotifications", "userId", "dbo.AspNetUsers");
            AddForeignKey("dbo.UserNotifications", "userId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserNotifications", "userId", "dbo.AspNetUsers");
            AddForeignKey("dbo.UserNotifications", "userId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
