namespace LoLWD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        LastName = c.String(nullable: false, maxLength: 200),
                        MiddleName = c.String(maxLength: 200),
                        Birthday = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 200),
                        SummonerName = c.String(maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        UserName = c.String(nullable: false, maxLength: 200),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
