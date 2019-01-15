namespace TwoMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
        }
    }
}
