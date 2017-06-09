namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class save : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PipingMaterialsClassDatas", "ApprovalDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PipingMaterialsClassDatas", "ApprovalDate", c => c.DateTime(nullable: false));
        }
    }
}
