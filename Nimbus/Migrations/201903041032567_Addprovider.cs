namespace Nimbus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Addprovider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderProviders",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Orders", "OrderProviderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "OrderProviderId");
            AddForeignKey("dbo.Orders", "OrderProviderId", "dbo.OrderProviders", "Id", cascadeDelete: false);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderProviderId", "dbo.OrderProviders");
            DropIndex("dbo.Orders", new[] { "OrderProviderId" });
            DropColumn("dbo.Orders", "OrderProviderId");
            DropTable("dbo.OrderProviders");
        }
    }
}
