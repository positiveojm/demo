namespace Scheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "UserName", null);
            DropColumn("dbo.Tasks", "UserId", null);
        }
    }
}
