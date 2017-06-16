namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class save2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", c => c.Int());
            CreateIndex("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID");
            AddForeignKey("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
            DropColumn("dbo.PipingCommodityFilters", "CommodityCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PipingCommodityFilters", "CommodityCode", c => c.String());
            DropForeignKey("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", "dbo.PipingCommodityMatlControlDatas");
            DropIndex("dbo.PipingCommodityFilters", new[] { "PipingCommodityMatlControlData_ID" });
            DropColumn("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID");
        }
    }
}
