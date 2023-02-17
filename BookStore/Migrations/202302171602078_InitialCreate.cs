namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BookName = c.String(nullable: false),
                        Reserved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationEvents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BookId = c.String(nullable: false),
                        BookName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReservationEvents");
            DropTable("dbo.Book");
        }
    }
}
