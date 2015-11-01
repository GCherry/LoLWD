namespace LoLWD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterContactReqiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "Name", c => c.String(maxLength: 200));
            AlterColumn("dbo.Contact", "Comment", c => c.String(nullable: false, maxLength: 700));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "Comment", c => c.String(maxLength: 700));
            AlterColumn("dbo.Contact", "Name", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
