namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_piping1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PipingSpecStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.PipingMaterialsClassDatas", "Responsibility", c => c.String());
            AddColumn("dbo.PipingMaterialsClassDatas", "LastModifiedOn", c => c.DateTime());
            AddColumn("dbo.PipingMaterialsClassDatas", "PipingSpecStatus_ID", c => c.Int());
            CreateIndex("dbo.PipingMaterialsClassDatas", "PipingSpecStatus_ID");
            AddForeignKey("dbo.PipingMaterialsClassDatas", "PipingSpecStatus_ID", "dbo.PipingSpecStatus", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PipingMaterialsClassDatas", "PipingSpecStatus_ID", "dbo.PipingSpecStatus");
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "PipingSpecStatus_ID" });
            DropColumn("dbo.PipingMaterialsClassDatas", "PipingSpecStatus_ID");
            DropColumn("dbo.PipingMaterialsClassDatas", "LastModifiedOn");
            DropColumn("dbo.PipingMaterialsClassDatas", "Responsibility");
            DropTable("dbo.PipingSpecStatus");
        }
    }
}
