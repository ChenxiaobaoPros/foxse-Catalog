namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class save1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", "dbo.PipingCommodityMatlControlDatas");
            DropIndex("dbo.PipingCommodityFilters", new[] { "PipingCommodityMatlControlData_ID" });
            AddColumn("dbo.PipingCommodityFilters", "CommodityCode", c => c.String());
            DropColumn("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", c => c.Int());
            DropColumn("dbo.PipingCommodityFilters", "CommodityCode");
            CreateIndex("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID");
            AddForeignKey("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
        }
    }
}
