namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BoltSelectionFilters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.GasketSelectionFilters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.NutSelectionFilters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.WasherSelectionFilters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameIndex(table: "dbo.BoltSelectionFilters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            RenameIndex(table: "dbo.GasketSelectionFilters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            RenameIndex(table: "dbo.NutSelectionFilters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            RenameIndex(table: "dbo.WasherSelectionFilters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            AddColumn("dbo.BoltSelectionFilters", "ContractorCommodityCode_ID", c => c.Int());
            AddColumn("dbo.GasketSelectionFilters", "ContractorCommodityCode_ID", c => c.Int());
            AddColumn("dbo.NutSelectionFilters", "ContractorCommodityCode_ID", c => c.Int());
            AddColumn("dbo.WasherSelectionFilters", "ContractorCommodityCode_ID", c => c.Int());
            CreateIndex("dbo.BoltSelectionFilters", "ContractorCommodityCode_ID");
            CreateIndex("dbo.GasketSelectionFilters", "ContractorCommodityCode_ID");
            CreateIndex("dbo.NutSelectionFilters", "ContractorCommodityCode_ID");
            CreateIndex("dbo.WasherSelectionFilters", "ContractorCommodityCode_ID");
            AddForeignKey("dbo.BoltSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
            AddForeignKey("dbo.GasketSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
            AddForeignKey("dbo.NutSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
            AddForeignKey("dbo.WasherSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas", "ID");
            DropColumn("dbo.BoltSelectionFilters", "ContractorCommodityCode");
            DropColumn("dbo.GasketSelectionFilters", "ContractorCommodityCode");
            DropColumn("dbo.NutSelectionFilters", "ContractorCommodityCode");
            DropColumn("dbo.WasherSelectionFilters", "ContractorCommodityCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WasherSelectionFilters", "ContractorCommodityCode", c => c.String());
            AddColumn("dbo.NutSelectionFilters", "ContractorCommodityCode", c => c.String());
            AddColumn("dbo.GasketSelectionFilters", "ContractorCommodityCode", c => c.String());
            AddColumn("dbo.BoltSelectionFilters", "ContractorCommodityCode", c => c.String());
            DropForeignKey("dbo.WasherSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas");
            DropForeignKey("dbo.NutSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas");
            DropForeignKey("dbo.GasketSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas");
            DropForeignKey("dbo.BoltSelectionFilters", "ContractorCommodityCode_ID", "dbo.PipingCommodityMatlControlDatas");
            DropIndex("dbo.WasherSelectionFilters", new[] { "ContractorCommodityCode_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "ContractorCommodityCode_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "ContractorCommodityCode_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "ContractorCommodityCode_ID" });
            DropColumn("dbo.WasherSelectionFilters", "ContractorCommodityCode_ID");
            DropColumn("dbo.NutSelectionFilters", "ContractorCommodityCode_ID");
            DropColumn("dbo.GasketSelectionFilters", "ContractorCommodityCode_ID");
            DropColumn("dbo.BoltSelectionFilters", "ContractorCommodityCode_ID");
            RenameIndex(table: "dbo.WasherSelectionFilters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameIndex(table: "dbo.NutSelectionFilters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameIndex(table: "dbo.GasketSelectionFilters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameIndex(table: "dbo.BoltSelectionFilters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.WasherSelectionFilters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.NutSelectionFilters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.GasketSelectionFilters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.BoltSelectionFilters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
        }
    }
}
