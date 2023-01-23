namespace Job_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditJobModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Jobs", "UserID");
            AddForeignKey("dbo.Jobs", "UserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Jobs", new[] { "UserID" });
            DropColumn("dbo.Jobs", "UserID");
        }
    }
}
