namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_piping : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PipeBranches", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.PipeNominalDiameters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "PipingCommodityMatlControlData_ID", newName: "CommodityCode_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "PipingMaterialsClassData_ID", newName: "SpecName_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "ShortCodeHierarchyRule_ID", newName: "ShortCode_ID");
            RenameIndex(table: "dbo.PipeBranches", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            RenameIndex(table: "dbo.PipeNominalDiameters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_PipingCommodityMatlControlData_ID", newName: "IX_CommodityCode_ID");
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_ShortCodeHierarchyRule_ID", newName: "IX_ShortCode_ID");
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_PipingMaterialsClassData_ID", newName: "IX_SpecName_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_ShortCode_ID", newName: "IX_ShortCodeHierarchyRule_ID");
            RenameIndex(table: "dbo.PipingCommodityFilters", name: "IX_CommodityCode_ID", newName: "IX_PipingCommodityMatlControlData_ID");
            RenameIndex(table: "dbo.PipeNominalDiameters", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameIndex(table: "dbo.PipeBranches", name: "IX_SpecName_ID", newName: "IX_PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "ShortCode_ID", newName: "ShortCodeHierarchyRule_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.PipingCommodityFilters", name: "CommodityCode_ID", newName: "PipingCommodityMatlControlData_ID");
            RenameColumn(table: "dbo.PipeNominalDiameters", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
            RenameColumn(table: "dbo.PipeBranches", name: "SpecName_ID", newName: "PipingMaterialsClassData_ID");
        }
    }
}
