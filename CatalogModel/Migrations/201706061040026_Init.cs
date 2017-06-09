namespace CatalogModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AutomatedFlangeSelectionOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BallValves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        Face1toCenter = c.Single(nullable: false),
                        OffsetFrmValCen = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        Face1toCenterUnitType_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        HeightUnitType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        OffsetFrmValCenUnitType_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                        WidthUnitType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face1toCenterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HeightUnitType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValCenUnitType_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WidthUnitType_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.Face1toCenterUnitType_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.HeightUnitType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.OffsetFrmValCenUnitType_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID)
                .Index(t => t.WidthUnitType_ID);
            
            CreateTable(
                "dbo.UnitTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        UnitClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitClasses", t => t.UnitClass_ID)
                .Index(t => t.UnitClass_ID);
            
            CreateTable(
                "dbo.PipingCommodityTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        PipingCommoditySubClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PipingCommoditySubClasses", t => t.PipingCommoditySubClass_ID)
                .Index(t => t.PipingCommoditySubClass_ID);
            
            CreateTable(
                "dbo.PipingCommoditySubClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        PipingCommodityClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PipingCommodityClasses", t => t.PipingCommodityClass_ID)
                .Index(t => t.PipingCommodityClass_ID);
            
            CreateTable(
                "dbo.PipingCommodityClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EndPreparations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        TerminationSubClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TerminationSubClasses", t => t.TerminationSubClass_ID)
                .Index(t => t.TerminationSubClass_ID);
            
            CreateTable(
                "dbo.TerminationSubClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        TerminationClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TerminationClasses", t => t.TerminationClass_ID)
                .Index(t => t.TerminationClass_ID);
            
            CreateTable(
                "dbo.TerminationClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FlangeFaceSurfaceFinishes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FlowDirections",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GeometricIndustryStandards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        GeometricIndustryPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GeometricIndustryPractices", t => t.GeometricIndustryPractice_ID)
                .Index(t => t.GeometricIndustryPractice_ID);
            
            CreateTable(
                "dbo.GeometricIndustryPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GeometryTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LiningMaterials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        LiningRequirements_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LiningRequirements", t => t.LiningRequirements_ID)
                .Index(t => t.LiningRequirements_ID);
            
            CreateTable(
                "dbo.LiningRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ManufacturingMethods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MaterialsGrades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        MaterialsCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MaterialsCategories", t => t.MaterialsCategory_ID)
                .Index(t => t.MaterialsCategory_ID);
            
            CreateTable(
                "dbo.MaterialsCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        MaterialsGradePractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MaterialsGradePractices", t => t.MaterialsGradePractice_ID)
                .Index(t => t.MaterialsGradePractice_ID);
            
            CreateTable(
                "dbo.MaterialsGradePractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MirrorBehaviorOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MiscRequisitionClassifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        MiscRequisitionComponentType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MiscRequisitionComponentTypes", t => t.MiscRequisitionComponentType_ID)
                .Index(t => t.MiscRequisitionComponentType_ID);
            
            CreateTable(
                "dbo.MiscRequisitionComponentTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PartDataBasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PressureRatings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        RatingPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RatingPractices", t => t.RatingPractice_ID)
                .Index(t => t.RatingPractice_ID);
            
            CreateTable(
                "dbo.RatingPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ScheduleThicknesses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ScheduleThicknessPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ScheduleThicknessPractices", t => t.ScheduleThicknessPractice_ID)
                .Index(t => t.ScheduleThicknessPractice_ID);
            
            CreateTable(
                "dbo.ScheduleThicknessPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SurfacePreparations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValveManufacturers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ValveManufacturerIndPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ValveManufacturerIndPractices", t => t.ValveManufacturerIndPractice_ID)
                .Index(t => t.ValveManufacturerIndPractice_ID);
            
            CreateTable(
                "dbo.ValveManufacturerIndPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValveModelNumbers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .Index(t => t.ValveManufacturer_ID);
            
            CreateTable(
                "dbo.ValveTrims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        SortOrder = c.Int(),
                        LongDescription = c.String(),
                        ValveTrimPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ValveTrimPractices", t => t.ValveTrimPractice_ID)
                .Index(t => t.ValveTrimPractice_ID);
            
            CreateTable(
                "dbo.ValveTrimPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BendAngles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Npd = c.Int(nullable: false),
                        BendAngle = c.Single(nullable: false),
                        BendAngleUnitType_ID = c.Int(),
                        NpdUnitType_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendAngleUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .Index(t => t.BendAngleUnitType_ID)
                .Index(t => t.NpdUnitType_ID)
                .Index(t => t.PipingMaterialsClassData_ID);
            
            CreateTable(
                "dbo.PipingMaterialsClassDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SpecName = c.String(),
                        MaterialsDescription = c.String(),
                        FluidService = c.String(),
                        Comments = c.String(),
                        RevisionNumber = c.String(),
                        ApprovedBy = c.String(),
                        ApprovalDate = c.DateTime(nullable: false),
                        JacketMatOfConstructionClass = c.String(),
                        JumperMatOfConstructionClass = c.String(),
                        JacketMaterialsDescription = c.String(),
                        JumperMaterialsDescription = c.String(),
                        JacketAndJumperFluidService = c.String(),
                        HyperlinkToHumanSpec = c.String(),
                        PipingNote1 = c.String(),
                        WeldingProcedureSpecification = c.String(),
                        AutomatedFlangeSelectionOption_ID = c.Int(),
                        DesignStandard_ID = c.Int(),
                        Examination_ID = c.Int(),
                        GasketRequirementOverride_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        MaterialsGroup_ID = c.Int(),
                        MaterialsOfConstructionClass_ID = c.Int(),
                        MaterialsType_ID = c.Int(),
                        PipingCommodityOverrideOption_ID = c.Int(),
                        StressRelief_ID = c.Int(),
                        StressReliefRequirement_ID = c.Int(),
                        WasherCreationOption_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AutomatedFlangeSelectionOptions", t => t.AutomatedFlangeSelectionOption_ID)
                .ForeignKey("dbo.DesignStandards", t => t.DesignStandard_ID)
                .ForeignKey("dbo.Examinations", t => t.Examination_ID)
                .ForeignKey("dbo.GasketRequirementOverrides", t => t.GasketRequirementOverride_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.MaterialsGroups", t => t.MaterialsGroup_ID)
                .ForeignKey("dbo.MaterialsOfConstructionClasses", t => t.MaterialsOfConstructionClass_ID)
                .ForeignKey("dbo.MaterialsTypes", t => t.MaterialsType_ID)
                .ForeignKey("dbo.PipingCommodityOverrideOptions", t => t.PipingCommodityOverrideOption_ID)
                .ForeignKey("dbo.StressReliefs", t => t.StressRelief_ID)
                .ForeignKey("dbo.StressReliefRequirements", t => t.StressReliefRequirement_ID)
                .ForeignKey("dbo.WasherCreationOptions", t => t.WasherCreationOption_ID)
                .Index(t => t.AutomatedFlangeSelectionOption_ID)
                .Index(t => t.DesignStandard_ID)
                .Index(t => t.Examination_ID)
                .Index(t => t.GasketRequirementOverride_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.MaterialsGroup_ID)
                .Index(t => t.MaterialsOfConstructionClass_ID)
                .Index(t => t.MaterialsType_ID)
                .Index(t => t.PipingCommodityOverrideOption_ID)
                .Index(t => t.StressRelief_ID)
                .Index(t => t.StressReliefRequirement_ID)
                .Index(t => t.WasherCreationOption_ID);
            
            CreateTable(
                "dbo.DesignStandards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        DesignStandardPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DesignStandardPractices", t => t.DesignStandardPractice_ID)
                .Index(t => t.DesignStandardPractice_ID);
            
            CreateTable(
                "dbo.DesignStandardPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ExaminationPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExaminationPractices", t => t.ExaminationPractice_ID)
                .Index(t => t.ExaminationPractice_ID);
            
            CreateTable(
                "dbo.ExaminationPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketRequirementOverrides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MaterialsGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MaterialsTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        MaterialsGroup_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MaterialsGroups", t => t.MaterialsGroup_ID)
                .Index(t => t.MaterialsGroup_ID);
            
            CreateTable(
                "dbo.MaterialsOfConstructionClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PipingCommodityOverrideOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StressReliefs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        StressReliefPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.StressReliefPractices", t => t.StressReliefPractice_ID)
                .Index(t => t.StressReliefPractice_ID);
            
            CreateTable(
                "dbo.StressReliefPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StressReliefRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WasherCreationOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BlindFlanges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.BoltExtensionOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltExtensions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalPipingDiameter = c.Int(nullable: false),
                        StandardBoltExtensionForStuds = c.Int(nullable: false),
                        AltBoltExtensionForStuds2 = c.Int(nullable: false),
                        AltBoltExtensionForStuds3 = c.Int(nullable: false),
                        AltBoltExtensionForStuds4 = c.Int(nullable: false),
                        AltBoltExtensionForStuds5 = c.Int(nullable: false),
                        AltBoltExtensionForStuds6 = c.Int(nullable: false),
                        StandardBoltExtForMachBolts = c.Int(nullable: false),
                        AltBoltExtForMachBolts = c.Int(nullable: false),
                        AltBoltExtForMachBolts2 = c.Int(nullable: false),
                        AltBoltExtForMachBolts3 = c.Int(nullable: false),
                        AltBoltExtForMachBolts4 = c.Int(nullable: false),
                        AltBoltExtForMachBolts5 = c.Int(nullable: false),
                        AltBoltExtForMachBolts6 = c.Int(nullable: false),
                        EndPreparation_ID = c.Int(),
                        EndStandard_ID = c.Int(),
                        NominalPipingDiameterUnits_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        StandardBoltExtensionForStudsUnits_ID = c.Int(),
                        StandardBoltExtForMachBoltsUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NominalPipingDiameterUnits_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.UnitTypes", t => t.StandardBoltExtensionForStudsUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.StandardBoltExtForMachBoltsUnits_ID)
                .Index(t => t.EndPreparation_ID)
                .Index(t => t.EndStandard_ID)
                .Index(t => t.NominalPipingDiameterUnits_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.StandardBoltExtensionForStudsUnits_ID)
                .Index(t => t.StandardBoltExtForMachBoltsUnits_ID);
            
            CreateTable(
                "dbo.EndStandards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        EndPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndPractices", t => t.EndPractice_ID)
                .Index(t => t.EndPractice_ID);
            
            CreateTable(
                "dbo.EndPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltingRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltLubricationRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltPartDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        BoltType_ID = c.Int(),
                        CoatingType_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        MaterialsGrade_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BoltTypes", t => t.BoltType_ID)
                .ForeignKey("dbo.CoatingTypes", t => t.CoatingType_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .Index(t => t.BoltType_ID)
                .Index(t => t.CoatingType_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.MaterialsGrade_ID);
            
            CreateTable(
                "dbo.BoltTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CoatingTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        CoatingRequirement_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CoatingRequirements", t => t.CoatingRequirement_ID)
                .Index(t => t.CoatingRequirement_ID);
            
            CreateTable(
                "dbo.CoatingRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BoltSelectionFilters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalDiameterFrom = c.Int(nullable: false),
                        NominalDiameterTo = c.Int(nullable: false),
                        MaximumTemperature = c.Single(nullable: false),
                        ContractorCommodityCode = c.String(),
                        Priority = c.Int(nullable: false),
                        Comments = c.String(),
                        PipingNote1 = c.String(),
                        AlternateEndPreparation_ID = c.Int(),
                        AlternateEndStandard_ID = c.Int(),
                        BoltExtensionOption_ID = c.Int(),
                        BoltOption_ID = c.Int(),
                        EndPreparation_ID = c.Int(),
                        EndStandard_ID = c.Int(),
                        FabricationCategoryOverride_ID = c.Int(),
                        LubricationRequirements_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        NpdUnitType_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        SupplyResponsibilityOverride_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndPreparations", t => t.AlternateEndPreparation_ID)
                .ForeignKey("dbo.PressureRatings", t => t.AlternateEndStandard_ID)
                .ForeignKey("dbo.BoltExtensionOptions", t => t.BoltExtensionOption_ID)
                .ForeignKey("dbo.BoltOptions", t => t.BoltOption_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard_ID)
                .ForeignKey("dbo.FabricationTypes", t => t.FabricationCategoryOverride_ID)
                .ForeignKey("dbo.BoltLubricationRequirements", t => t.LubricationRequirements_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.SupplyResponsibilities", t => t.SupplyResponsibilityOverride_ID)
                .Index(t => t.AlternateEndPreparation_ID)
                .Index(t => t.AlternateEndStandard_ID)
                .Index(t => t.BoltExtensionOption_ID)
                .Index(t => t.BoltOption_ID)
                .Index(t => t.EndPreparation_ID)
                .Index(t => t.EndStandard_ID)
                .Index(t => t.FabricationCategoryOverride_ID)
                .Index(t => t.LubricationRequirements_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.NpdUnitType_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.SupplyResponsibilityOverride_ID);
            
            CreateTable(
                "dbo.FabricationTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        FabricationRequirement_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FabricationRequirements", t => t.FabricationRequirement_ID)
                .Index(t => t.FabricationRequirement_ID);
            
            CreateTable(
                "dbo.FabricationRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupplyResponsibilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ButterflyValves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        A = c.Single(nullable: false),
                        B = c.Single(nullable: false),
                        C = c.Single(nullable: false),
                        OffsetFrmValCen = c.Single(nullable: false),
                        OffsetFrmValBotm = c.Single(),
                        Width = c.Single(),
                        Face2toCenter = c.Single(),
                        AUnitType_ID = c.Int(),
                        BendRadiusUnits_ID = c.Int(),
                        BUnitType_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        CUnitType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        Face2toCenterUnitType_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        OffsetFrmValBotmUnitType_ID = c.Int(),
                        OffsetFrmValCenUnitType_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                        WidthUnitType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.AUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BUnitType_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.CUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face2toCenterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValBotmUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValCenUnitType_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WidthUnitType_ID)
                .Index(t => t.AUnitType_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.BUnitType_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.CUnitType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.Face2toCenterUnitType_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.OffsetFrmValBotmUnitType_ID)
                .Index(t => t.OffsetFrmValCenUnitType_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID)
                .Index(t => t.WidthUnitType_ID);
            
            CreateTable(
                "dbo.Caps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        FacetoEnd = c.Single(),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        FacetoEndUnits_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoEndUnits_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.FacetoEndUnits_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.CheckValves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        HeightFrmValCen = c.Single(nullable: false),
                        EqualizerClearance = c.Single(),
                        Diameter = c.Single(),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DiameterUnitType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        EqualizerClearanceUnitType_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        HeightFrmValCenUnitType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DiameterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.EqualizerClearanceUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HeightFrmValCenUnitType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DiameterUnitType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.EqualizerClearanceUnitType_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.HeightFrmValCenUnitType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.ClampRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CommodityOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        SortOrder = c.Int(),
                        LongDescription = c.String(),
                        OptionCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OptionCategories", t => t.OptionCategory_ID)
                .Index(t => t.OptionCategory_ID);
            
            CreateTable(
                "dbo.OptionCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ConcentricReducers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.DefaultChangeOfDirectionPerSpecs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BendAngleFrom = c.Single(nullable: false),
                        BendAngleTo = c.Single(nullable: false),
                        BendAngleFromUnitType_ID = c.Int(),
                        BendAngleToUnitType_ID = c.Int(),
                        FunctionalShortCode_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendAngleFromUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendAngleToUnitType_ID)
                .ForeignKey("dbo.ShortCodeHierarchyRules", t => t.FunctionalShortCode_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .Index(t => t.BendAngleFromUnitType_ID)
                .Index(t => t.BendAngleToUnitType_ID)
                .Index(t => t.FunctionalShortCode_ID)
                .Index(t => t.PipingMaterialsClassData_ID);
            
            CreateTable(
                "dbo.ShortCodeHierarchyRules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortCode = c.String(),
                        ShortCodeHierarchyType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShortCodeHierarchyTypes", t => t.ShortCodeHierarchyType_ID)
                .Index(t => t.ShortCodeHierarchyType_ID);
            
            CreateTable(
                "dbo.ShortCodeHierarchyTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ShortCodeHierarchyClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShortCodeHierarchyClasses", t => t.ShortCodeHierarchyClass_ID)
                .Index(t => t.ShortCodeHierarchyClass_ID);
            
            CreateTable(
                "dbo.ShortCodeHierarchyClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DrillingTemplatePatterns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EccentricReducers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.Elbows",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendAngle = c.Single(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoCenter = c.Single(nullable: false),
                        BendAngleUnits_ID = c.Int(),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoCenterUnits_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendAngleUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoCenterUnits_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendAngleUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoCenterUnits_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.FlangeFacings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FlangeInsulationKitTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FluidCodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        FluidSystem_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FluidSystems", t => t.FluidSystem_ID)
                .Index(t => t.FluidSystem_ID);
            
            CreateTable(
                "dbo.FluidSystems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        GasketCategory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GasketCategories", t => t.GasketCategory_ID)
                .Index(t => t.GasketCategory_ID);
            
            CreateTable(
                "dbo.GasketInsideDiameterBasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketOutsideDiameterBasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketPartDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        NominalDiameterFrom = c.Int(nullable: false),
                        NominalDiameterTo = c.Int(nullable: false),
                        NominalDiameter = c.Int(),
                        ThicknessFor3DModel = c.Single(nullable: false),
                        ProcurementThickness = c.Single(nullable: false),
                        GasketOutsideDiameter = c.Single(),
                        GasketInsideDiameter = c.Single(),
                        InsulatingWasherThickness = c.Single(),
                        MetallicElectroPlatedWasherThk = c.Single(),
                        MaintenanceFactor = c.Single(),
                        FlangePressure = c.Single(),
                        StressAtWhichSealIsInitiated = c.Boolean(),
                        TightnessCurveSlope = c.Single(),
                        IntersectionOfUnloadCurveWithVerticalAxis = c.Boolean(),
                        MinimumTightnessParameter = c.Int(),
                        MaximumTightnessParameter = c.Int(),
                        MaximumTemperature = c.Single(),
                        MaximumPressure = c.Single(),
                        StyleNumber = c.Int(),
                        FlangeFacing_ID = c.Int(),
                        FlangeInsulationKitType_ID = c.Int(),
                        FlangePressureUnits_ID = c.Int(),
                        GasketIndustryStandard_ID = c.Int(),
                        GasketInsideDiameterBasis_ID = c.Int(),
                        GasketInsideDiameterUnits_ID = c.Int(),
                        GasketOutsideDiameterBasis_ID = c.Int(),
                        GasketOutsideDiameterUnits_ID = c.Int(),
                        GasketType_ID = c.Int(),
                        InsulatingWasherThicknessUnits_ID = c.Int(),
                        MaterialsGrade_ID = c.Int(),
                        MaximumPressureUnits_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        MetallicElectroPlatedWasherThkUnits_ID = c.Int(),
                        NpdUnitType_ID = c.Int(),
                        ProcurementThicknessUnits_ID = c.Int(),
                        RingNumber_ID = c.Int(),
                        ThicknessFor3DModelUnits_ID = c.Int(),
                        TightnessCurveSlopeUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FlangeFacings", t => t.FlangeFacing_ID)
                .ForeignKey("dbo.FlangeInsulationKitTypes", t => t.FlangeInsulationKitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangePressureUnits_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GasketIndustryStandard_ID)
                .ForeignKey("dbo.GasketInsideDiameterBasis", t => t.GasketInsideDiameterBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GasketInsideDiameterUnits_ID)
                .ForeignKey("dbo.GasketOutsideDiameterBasis", t => t.GasketOutsideDiameterBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GasketOutsideDiameterUnits_ID)
                .ForeignKey("dbo.GasketTypes", t => t.GasketType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.InsulatingWasherThicknessUnits_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumPressureUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MetallicElectroPlatedWasherThkUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ProcurementThicknessUnits_ID)
                .ForeignKey("dbo.RingNumbers", t => t.RingNumber_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ThicknessFor3DModelUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.TightnessCurveSlopeUnits_ID)
                .Index(t => t.FlangeFacing_ID)
                .Index(t => t.FlangeInsulationKitType_ID)
                .Index(t => t.FlangePressureUnits_ID)
                .Index(t => t.GasketIndustryStandard_ID)
                .Index(t => t.GasketInsideDiameterBasis_ID)
                .Index(t => t.GasketInsideDiameterUnits_ID)
                .Index(t => t.GasketOutsideDiameterBasis_ID)
                .Index(t => t.GasketOutsideDiameterUnits_ID)
                .Index(t => t.GasketType_ID)
                .Index(t => t.InsulatingWasherThicknessUnits_ID)
                .Index(t => t.MaterialsGrade_ID)
                .Index(t => t.MaximumPressureUnits_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.MetallicElectroPlatedWasherThkUnits_ID)
                .Index(t => t.NpdUnitType_ID)
                .Index(t => t.ProcurementThicknessUnits_ID)
                .Index(t => t.RingNumber_ID)
                .Index(t => t.ThicknessFor3DModelUnits_ID)
                .Index(t => t.TightnessCurveSlopeUnits_ID);
            
            CreateTable(
                "dbo.RingNumbers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        RingNumberPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RingNumberPractices", t => t.RingNumberPractice_ID)
                .Index(t => t.RingNumberPractice_ID);
            
            CreateTable(
                "dbo.RingNumberPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GasketSelectionFilters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalDiameterFrom = c.Int(nullable: false),
                        NominalDiameterTo = c.Int(nullable: false),
                        MaximumTemperature = c.Single(nullable: false),
                        ContractorCommodityCode = c.String(),
                        Priority = c.Int(nullable: false),
                        Comments = c.String(),
                        QuantityOfAltReportableParts = c.Int(nullable: false),
                        AltReportableCommodityCode = c.String(),
                        QuantityOfReportableParts = c.Int(nullable: false),
                        ReportableCommodityCode = c.String(),
                        PipingNote1 = c.String(),
                        AlternateEndPreparation_ID = c.Int(),
                        AlternateEndStandard_ID = c.Int(),
                        AlternatePressureRating_ID = c.Int(),
                        EndPreparation_ID = c.Int(),
                        EndStandard_ID = c.Int(),
                        FabricationCategoryOverride_ID = c.Int(),
                        FluidCode_ID = c.Int(),
                        GasketOption_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        NpdUnitType_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        RingNumber_ID = c.Int(),
                        ScheduleThickness_ID = c.Int(),
                        SupplyResponsibilityOverride_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndPreparations", t => t.AlternateEndPreparation_ID)
                .ForeignKey("dbo.EndStandards", t => t.AlternateEndStandard_ID)
                .ForeignKey("dbo.PressureRatings", t => t.AlternatePressureRating_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard_ID)
                .ForeignKey("dbo.FabricationTypes", t => t.FabricationCategoryOverride_ID)
                .ForeignKey("dbo.FluidCodes", t => t.FluidCode_ID)
                .ForeignKey("dbo.GasketOptions", t => t.GasketOption_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.RingNumbers", t => t.RingNumber_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness_ID)
                .ForeignKey("dbo.SupplyResponsibilities", t => t.SupplyResponsibilityOverride_ID)
                .Index(t => t.AlternateEndPreparation_ID)
                .Index(t => t.AlternateEndStandard_ID)
                .Index(t => t.AlternatePressureRating_ID)
                .Index(t => t.EndPreparation_ID)
                .Index(t => t.EndStandard_ID)
                .Index(t => t.FabricationCategoryOverride_ID)
                .Index(t => t.FluidCode_ID)
                .Index(t => t.GasketOption_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.NpdUnitType_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.RingNumber_ID)
                .Index(t => t.ScheduleThickness_ID)
                .Index(t => t.SupplyResponsibilityOverride_ID);
            
            CreateTable(
                "dbo.GateValves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        OffsetFrmValCen = c.Single(nullable: false),
                        Diameter = c.Single(),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DiameterUnitType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        OffsetFrmValCenUnitType_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DiameterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValCenUnitType_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DiameterUnitType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.OffsetFrmValCenUnitType_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.GlobeValves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        FacetoCenter = c.Single(nullable: false),
                        Face1toCenter = c.Single(nullable: false),
                        Face2toCenter = c.Single(nullable: false),
                        OffsetFrmValCen = c.Single(nullable: false),
                        Diameter = c.Single(),
                        BonnetFlangeDia = c.Single(),
                        MountingFlangeDia = c.Single(),
                        BendRadiusUnits_ID = c.Int(),
                        BonnetFlangeDiaUnitType_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DiameterUnitType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        Face1toCenterUnitType_ID = c.Int(),
                        Face2toCenterUnitType_ID = c.Int(),
                        FacetoCenterUnitType_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        MountingFlangeDiaUnitType_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        OffsetFrmValCenUnitType_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BonnetFlangeDiaUnitType_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DiameterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face1toCenterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face2toCenterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoCenterUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MountingFlangeDiaUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValCenUnitType_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.BonnetFlangeDiaUnitType_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DiameterUnitType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.Face1toCenterUnitType_ID)
                .Index(t => t.Face2toCenterUnitType_ID)
                .Index(t => t.FacetoCenterUnitType_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.MountingFlangeDiaUnitType_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.OffsetFrmValCenUnitType_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.JacketedPipingBasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LooseMaterialRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ManufacturerIndustryPractices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        SortOrder = c.Int(),
                        LongDescription = c.String(),
                        ManufacturerIndustryPractice_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ManufacturerIndustryPractices", t => t.ManufacturerIndustryPractice_ID)
                .Index(t => t.ManufacturerIndustryPractice_ID);
            
            CreateTable(
                "dbo.MatingPorts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EndPrep1_ID = c.Int(),
                        EndPrep2_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPrep1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPrep2_ID)
                .Index(t => t.EndPrep1_ID)
                .Index(t => t.EndPrep2_ID);
            
            CreateTable(
                "dbo.MultiportValveOpReqs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NutOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NutPartDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        NutHeight = c.Single(nullable: false),
                        GeometricIndustryStandard_ID = c.Int(),
                        MaterialsGrade_ID = c.Int(),
                        NutHeightUnits_ID = c.Int(),
                        NutType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NutHeightUnits_ID)
                .ForeignKey("dbo.NutTypes", t => t.NutType_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.MaterialsGrade_ID)
                .Index(t => t.NutHeightUnits_ID)
                .Index(t => t.NutType_ID);
            
            CreateTable(
                "dbo.NutTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NutSelectionFilters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaximumTemperature = c.Single(nullable: false),
                        BoltDiameter = c.Single(nullable: false),
                        ContractorCommodityCode = c.String(),
                        SupplNutCntrCommodityCode = c.String(),
                        Comments = c.String(),
                        PipingNote1 = c.String(),
                        BoltDiameterUnits_ID = c.Int(),
                        BoltType_ID = c.Int(),
                        FabricationCategoryOverride_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        NutOption_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        SupplementaryNutOption_ID = c.Int(),
                        SupplyResponsibilityOverride_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterUnits_ID)
                .ForeignKey("dbo.BoltTypes", t => t.BoltType_ID)
                .ForeignKey("dbo.FabricationTypes", t => t.FabricationCategoryOverride_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.NutOptions", t => t.NutOption_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.SupplementaryNutRequirements", t => t.SupplementaryNutOption_ID)
                .ForeignKey("dbo.SupplyResponsibilities", t => t.SupplyResponsibilityOverride_ID)
                .Index(t => t.BoltDiameterUnits_ID)
                .Index(t => t.BoltType_ID)
                .Index(t => t.FabricationCategoryOverride_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.NutOption_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.SupplementaryNutOption_ID)
                .Index(t => t.SupplyResponsibilityOverride_ID);
            
            CreateTable(
                "dbo.SupplementaryNutRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Operator332",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ValveOperatorNumber = c.String(),
                        ValveSize = c.Int(nullable: false),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        GearDiameter = c.Single(),
                        GearRadius = c.Single(),
                        GearDepth = c.Single(),
                        HWDiameter = c.Single(),
                        HandWheelRadius = c.Single(),
                        HwXOffsetFrmOpStem = c.Single(),
                        HwZOffsetOpFrmStem = c.Single(),
                        HwYOffsetFrmGearBot = c.Single(),
                        ValCenToHWTop = c.Single(),
                        ValCenToHWCen = c.Single(),
                        ExStemLen = c.Single(),
                        ExStemLenFrmValCen = c.Single(),
                        ExStemDia = c.Single(),
                        DimensionalBasis_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        ExStemDiaUnits_ID = c.Int(),
                        ExStemLenFrmValCenUnits_ID = c.Int(),
                        ExStemLenUnits_ID = c.Int(),
                        GearDepthUnits_ID = c.Int(),
                        GearDiameterUnits_ID = c.Int(),
                        GearRadiusUnits_ID = c.Int(),
                        HandWheelRadiusUnits_ID = c.Int(),
                        HWDiameterUnits_ID = c.Int(),
                        HwXOffsetFrmOpStemUnits_ID = c.Int(),
                        HwYOffsetFrmGearBotUnits_ID = c.Int(),
                        HwZOffsetOpFrmStemUnits_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        ValCenToHWCenUnits_ID = c.Int(),
                        ValCenToHWTopUnits_ID = c.Int(),
                        ValveOperatorIsRotatable_ID = c.Int(),
                        ValveSizeUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PartDataBasis", t => t.DimensionalBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ExStemDiaUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ExStemLenFrmValCenUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ExStemLenUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GearDepthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GearDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GearRadiusUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HandWheelRadiusUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HWDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwXOffsetFrmOpStemUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwYOffsetFrmGearBotUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwZOffsetOpFrmStemUnits_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValCenToHWCenUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValCenToHWTopUnits_ID)
                .ForeignKey("dbo.ValveOperatorIsRotatables", t => t.ValveOperatorIsRotatable_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValveSizeUnits_ID)
                .Index(t => t.DimensionalBasis_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.ExStemDiaUnits_ID)
                .Index(t => t.ExStemLenFrmValCenUnits_ID)
                .Index(t => t.ExStemLenUnits_ID)
                .Index(t => t.GearDepthUnits_ID)
                .Index(t => t.GearDiameterUnits_ID)
                .Index(t => t.GearRadiusUnits_ID)
                .Index(t => t.HandWheelRadiusUnits_ID)
                .Index(t => t.HWDiameterUnits_ID)
                .Index(t => t.HwXOffsetFrmOpStemUnits_ID)
                .Index(t => t.HwYOffsetFrmGearBotUnits_ID)
                .Index(t => t.HwZOffsetOpFrmStemUnits_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.ValCenToHWCenUnits_ID)
                .Index(t => t.ValCenToHWTopUnits_ID)
                .Index(t => t.ValveOperatorIsRotatable_ID)
                .Index(t => t.ValveSizeUnits_ID);
            
            CreateTable(
                "dbo.ValveOperatorIsRotatables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Operator351",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ValveOperatorNumber = c.String(),
                        ValveSize = c.Int(nullable: false),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        HwXOffsetFrmOpStem = c.Single(),
                        HwZOffsetOpFrmStem = c.Single(),
                        HwOffsetFrmValCen = c.Single(),
                        OperatorHeight = c.Single(),
                        HWDiameter = c.Single(),
                        OffsetFrmValCen = c.Single(),
                        DimensionalBasis_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        HWDiameterUnits_ID = c.Int(),
                        HwOffsetFrmValCenUnits_ID = c.Int(),
                        HwXOffsetFrmOpStemUnits_ID = c.Int(),
                        HwZOffsetOpFrmStemUnits_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        OffsetFrmValCenUnits_ID = c.Int(),
                        OperatorHeightUnits_ID = c.Int(),
                        ValveOperatorIsRotatable_ID = c.Int(),
                        ValveSizeUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PartDataBasis", t => t.DimensionalBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HWDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwOffsetFrmValCenUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwXOffsetFrmOpStemUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HwZOffsetOpFrmStemUnits_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OffsetFrmValCenUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OperatorHeightUnits_ID)
                .ForeignKey("dbo.ValveOperatorIsRotatables", t => t.ValveOperatorIsRotatable_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValveSizeUnits_ID)
                .Index(t => t.DimensionalBasis_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.HWDiameterUnits_ID)
                .Index(t => t.HwOffsetFrmValCenUnits_ID)
                .Index(t => t.HwXOffsetFrmOpStemUnits_ID)
                .Index(t => t.HwZOffsetOpFrmStemUnits_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.OffsetFrmValCenUnits_ID)
                .Index(t => t.OperatorHeightUnits_ID)
                .Index(t => t.ValveOperatorIsRotatable_ID)
                .Index(t => t.ValveSizeUnits_ID);
            
            CreateTable(
                "dbo.Operator5",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ValveOperatorNumber = c.String(),
                        ValveSize = c.Int(nullable: false),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        OperatorHeight = c.Single(),
                        HandWheelDiameter = c.Single(),
                        DimensionalBasis_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        HandWheelDiameterUnits_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        OperatorHeightUnits_ID = c.Int(),
                        ValveOperatorIsRotatable_ID = c.Int(),
                        ValveSizeUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PartDataBasis", t => t.DimensionalBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HandWheelDiameterUnits_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.UnitTypes", t => t.OperatorHeightUnits_ID)
                .ForeignKey("dbo.ValveOperatorIsRotatables", t => t.ValveOperatorIsRotatable_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValveSizeUnits_ID)
                .Index(t => t.DimensionalBasis_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.HandWheelDiameterUnits_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.OperatorHeightUnits_ID)
                .Index(t => t.ValveOperatorIsRotatable_ID)
                .Index(t => t.ValveSizeUnits_ID);
            
            CreateTable(
                "dbo.Operator9",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ValveOperatorNumber = c.String(),
                        ValveSize = c.Int(nullable: false),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        Height = c.Single(),
                        HandleLength = c.Single(),
                        DimensionalBasis_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        HandleLengthUnits_ID = c.Int(),
                        HeightUnits_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        ValveOperatorIsRotatable_ID = c.Int(),
                        ValveSizeUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PartDataBasis", t => t.DimensionalBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HandleLengthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HeightUnits_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.ValveOperatorIsRotatables", t => t.ValveOperatorIsRotatable_ID)
                .ForeignKey("dbo.UnitTypes", t => t.ValveSizeUnits_ID)
                .Index(t => t.DimensionalBasis_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.HandleLengthUnits_ID)
                .Index(t => t.HeightUnits_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.ValveOperatorIsRotatable_ID)
                .Index(t => t.ValveSizeUnits_ID);
            
            CreateTable(
                "dbo.Paddles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        HandletoCenter = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        HandletoCenterUnitType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HandletoCenterUnitType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.HandletoCenterUnitType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.PartDataSources",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PipeBranches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HeaderSize = c.Int(nullable: false),
                        BranchSize = c.Int(nullable: false),
                        AngleLow = c.Single(nullable: false),
                        AngleHigh = c.Single(nullable: false),
                        AngleHighUnitType_ID = c.Int(),
                        AngleLowUnitType_ID = c.Int(),
                        BrSizeNPDUnitType_ID = c.Int(),
                        HdrSizeNPDUnitType_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        SecondaryShortCode_ID = c.Int(),
                        ShortCode_ID = c.Int(),
                        TertiaryShortCode_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.AngleHighUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.AngleLowUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BrSizeNPDUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HdrSizeNPDUnitType_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.ShortCodeHierarchyRules", t => t.SecondaryShortCode_ID)
                .ForeignKey("dbo.ShortCodeHierarchyRules", t => t.ShortCode_ID)
                .ForeignKey("dbo.ShortCodeHierarchyRules", t => t.TertiaryShortCode_ID)
                .Index(t => t.AngleHighUnitType_ID)
                .Index(t => t.AngleLowUnitType_ID)
                .Index(t => t.BrSizeNPDUnitType_ID)
                .Index(t => t.HdrSizeNPDUnitType_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.SecondaryShortCode_ID)
                .Index(t => t.ShortCode_ID)
                .Index(t => t.TertiaryShortCode_ID);
            
            CreateTable(
                "dbo.PipeNominalDiameters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Npd = c.Int(nullable: false),
                        NpdUnitType_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .Index(t => t.NpdUnitType_ID)
                .Index(t => t.PipingMaterialsClassData_ID);
            
            CreateTable(
                "dbo.PipeStocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        CommodityType = c.String(),
                        Density = c.Single(nullable: false),
                        GraphicalRepresentationOrNot = c.Boolean(nullable: false),
                        PurchaseLength = c.Single(nullable: false),
                        MinimumPipeLength = c.Single(nullable: false),
                        MaximumPipeLength = c.Single(nullable: false),
                        DryWeightForEnd1 = c.Single(nullable: false),
                        DryWeightForEnd2 = c.Single(nullable: false),
                        Npd1_Primary = c.Int(nullable: false),
                        Npd2_Secondary = c.Int(nullable: false),
                        WeightPerUnitLength = c.Single(nullable: false),
                        PipingNote1 = c.String(),
                        DensityUnits_ID = c.Int(),
                        DryWeightForEnd1Units_ID = c.Int(),
                        DryWeightForEnd2Units_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MaximumPipeLengthUnits_ID = c.Int(),
                        MinimumPipeLengthUnits_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        PurchaseLengthUnits_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        WeightPerUnitLengthUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.DensityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightForEnd1Units_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightForEnd2Units_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumPipeLengthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MinimumPipeLengthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.PurchaseLengthUnits_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WeightPerUnitLengthUnits_ID)
                .Index(t => t.DensityUnits_ID)
                .Index(t => t.DryWeightForEnd1Units_ID)
                .Index(t => t.DryWeightForEnd2Units_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MaximumPipeLengthUnits_ID)
                .Index(t => t.MinimumPipeLengthUnits_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.PurchaseLengthUnits_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.WeightPerUnitLengthUnits_ID);
            
            CreateTable(
                "dbo.PipingCommodityFilters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                        FirstSizeFrom = c.Int(nullable: false),
                        FirstSizeTo = c.Int(nullable: false),
                        SecondSizeFrom = c.Int(nullable: false),
                        SecondSizeTo = c.Int(nullable: false),
                        MultisizeOption = c.String(),
                        MaximumTemperature = c.Single(nullable: false),
                        MinimumTemperature = c.Single(nullable: false),
                        EngineeringTag = c.String(),
                        FabricationCategoryOverride = c.String(),
                        SupplyResponsibilityOverride = c.String(),
                        FirstSizeSchedule = c.String(),
                        SecondSizeSchedule = c.String(),
                        ReportableCommodityCode = c.String(),
                        QuantityOfReportableParts = c.Int(nullable: false),
                        AssociatedCommodityCode = c.String(),
                        BendRadiusMultiplier = c.Single(nullable: false),
                        BendRadius = c.Single(nullable: false),
                        NumberOfMiterCuts = c.Int(nullable: false),
                        PDSModifier = c.Int(nullable: false),
                        PreferredPipeLength = c.Single(nullable: false),
                        PipingNote1 = c.String(),
                        AltReportableCommodityCode = c.String(),
                        QuantityOfAltReportableParts = c.Int(nullable: false),
                        FirstSizeUnits_ID = c.Int(),
                        FirstSizeUOMBasisInCatalog_ID = c.Int(),
                        FluidCode_ID = c.Int(),
                        JacketedPipingBasis_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        MinimumTemperatureUnits_ID = c.Int(),
                        OptionCode_ID = c.Int(),
                        PipingCommodityMatlControlData_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        SecondSizeUnits_ID = c.Int(),
                        SecondSizeUOMBasisInCatalog_ID = c.Int(),
                        SelectionBasis_ID = c.Int(),
                        ShortCodeHierarchyRule_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.FirstSizeUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FirstSizeUOMBasisInCatalog_ID)
                .ForeignKey("dbo.FluidCodes", t => t.FluidCode_ID)
                .ForeignKey("dbo.JacketedPipingBasis", t => t.JacketedPipingBasis_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MinimumTemperatureUnits_ID)
                .ForeignKey("dbo.CommodityOptions", t => t.OptionCode_ID)
                .ForeignKey("dbo.PipingCommodityMatlControlDatas", t => t.PipingCommodityMatlControlData_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SecondSizeUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SecondSizeUOMBasisInCatalog_ID)
                .ForeignKey("dbo.SelectionBasis", t => t.SelectionBasis_ID)
                .ForeignKey("dbo.ShortCodeHierarchyRules", t => t.ShortCodeHierarchyRule_ID)
                .Index(t => t.FirstSizeUnits_ID)
                .Index(t => t.FirstSizeUOMBasisInCatalog_ID)
                .Index(t => t.FluidCode_ID)
                .Index(t => t.JacketedPipingBasis_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.MinimumTemperatureUnits_ID)
                .Index(t => t.OptionCode_ID)
                .Index(t => t.PipingCommodityMatlControlData_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.SecondSizeUnits_ID)
                .Index(t => t.SecondSizeUOMBasisInCatalog_ID)
                .Index(t => t.SelectionBasis_ID)
                .Index(t => t.ShortCodeHierarchyRule_ID);
            
            CreateTable(
                "dbo.PipingCommodityMatlControlDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContractorCommodityCode = c.String(),
                        ClientCommodityCode = c.String(),
                        CIMISCommodityCode = c.String(),
                        FirstSizeFrom = c.Int(nullable: false),
                        FirstSizeTo = c.Int(nullable: false),
                        SecondSizeFrom = c.Int(nullable: false),
                        SecondSizeTo = c.Int(nullable: false),
                        IndustryCommodityCode = c.String(),
                        ShortMaterialDescription = c.String(),
                        LongMaterialDescription = c.String(),
                        QuantityOfReportableParts = c.Int(nullable: false),
                        SubstCapScrewsQuantity = c.Int(nullable: false),
                        SubstCapScrewCntrCommodityCode = c.String(),
                        SubstCapScrewDiameter = c.Int(nullable: false),
                        TappedHoleDepth = c.Int(nullable: false),
                        TappedHoleDepth2 = c.Int(nullable: false),
                        CapScrewEngagementGap = c.Int(nullable: false),
                        ValveOperatorCatalogPartNumber = c.String(),
                        ReportableCommodityCode = c.String(),
                        AltOrientationCommodityCode = c.String(),
                        HyperlinkToElectronicVendor = c.String(),
                        HyperlinkToElectronicManuals = c.String(),
                        PipingNote1 = c.String(),
                        VendorPartNumber = c.String(),
                        ManufacturerPartNumber = c.String(),
                        AltReportableCommodityCode = c.String(),
                        QuantityOfAltReportableParts = c.Int(nullable: false),
                        eClasseProcurementCode = c.String(),
                        UNSPSCeProcurementCode = c.String(),
                        LegacyCommodityCode = c.String(),
                        BoltingRequirements_ID = c.Int(),
                        ClampRequirement_ID = c.Int(),
                        FabricationType_ID = c.Int(),
                        FirstSizeUnits_ID = c.Int(),
                        GasketRequirements_ID = c.Int(),
                        LooseMaterialRequirements_ID = c.Int(),
                        Manufacturer_ID = c.Int(),
                        MultiportValveOpReq_ID = c.Int(),
                        PartDataSource_ID = c.Int(),
                        ReportingType_ID = c.Int(),
                        SecondSizeUnits_ID = c.Int(),
                        SubstCapScrewDiameterUnits_ID = c.Int(),
                        SupplyResponsibility_ID = c.Int(),
                        ValveOperatorGeoIndStd_ID = c.Int(),
                        ValveOperatorType_ID = c.Int(),
                        Vendor_ID = c.Int(),
                        WeldingRequirement_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BoltingRequirements", t => t.BoltingRequirements_ID)
                .ForeignKey("dbo.ClampRequirements", t => t.ClampRequirement_ID)
                .ForeignKey("dbo.FabricationTypes", t => t.FabricationType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FirstSizeUnits_ID)
                .ForeignKey("dbo.GasketRequirements", t => t.GasketRequirements_ID)
                .ForeignKey("dbo.LooseMaterialRequirements", t => t.LooseMaterialRequirements_ID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ID)
                .ForeignKey("dbo.MultiportValveOpReqs", t => t.MultiportValveOpReq_ID)
                .ForeignKey("dbo.PartDataSources", t => t.PartDataSource_ID)
                .ForeignKey("dbo.ReportingTypes", t => t.ReportingType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SecondSizeUnits_ID)
                .ForeignKey("dbo.UnitClasses", t => t.SubstCapScrewDiameterUnits_ID)
                .ForeignKey("dbo.SupplyResponsibilities", t => t.SupplyResponsibility_ID)
                .ForeignKey("dbo.ValveOperatorGeometricIndStds", t => t.ValveOperatorGeoIndStd_ID)
                .ForeignKey("dbo.ValveOperatorTypes", t => t.ValveOperatorType_ID)
                .ForeignKey("dbo.Vendors", t => t.Vendor_ID)
                .ForeignKey("dbo.WeldingRequirements", t => t.WeldingRequirement_ID)
                .Index(t => t.BoltingRequirements_ID)
                .Index(t => t.ClampRequirement_ID)
                .Index(t => t.FabricationType_ID)
                .Index(t => t.FirstSizeUnits_ID)
                .Index(t => t.GasketRequirements_ID)
                .Index(t => t.LooseMaterialRequirements_ID)
                .Index(t => t.Manufacturer_ID)
                .Index(t => t.MultiportValveOpReq_ID)
                .Index(t => t.PartDataSource_ID)
                .Index(t => t.ReportingType_ID)
                .Index(t => t.SecondSizeUnits_ID)
                .Index(t => t.SubstCapScrewDiameterUnits_ID)
                .Index(t => t.SupplyResponsibility_ID)
                .Index(t => t.ValveOperatorGeoIndStd_ID)
                .Index(t => t.ValveOperatorType_ID)
                .Index(t => t.Vendor_ID)
                .Index(t => t.WeldingRequirement_ID);
            
            CreateTable(
                "dbo.ReportingTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ReportingRequirement_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ReportingRequirements", t => t.ReportingRequirement_ID)
                .Index(t => t.ReportingRequirement_ID);
            
            CreateTable(
                "dbo.ReportingRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UnitClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValveOperatorGeometricIndStds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ValveOperatorGeometricIndPract_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ValveOperatorGeometricIndPracts", t => t.ValveOperatorGeometricIndPract_ID)
                .Index(t => t.ValveOperatorGeometricIndPract_ID);
            
            CreateTable(
                "dbo.ValveOperatorGeometricIndPracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ValveOperatorTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        ValveOperatorClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ValveOperatorClasses", t => t.ValveOperatorClass_ID)
                .Index(t => t.ValveOperatorClass_ID);
            
            CreateTable(
                "dbo.ValveOperatorClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WeldingRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SelectionBasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PipingGenericDataBolteds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalPipingDiameter = c.Int(nullable: false),
                        FlangeOutsideDiameter = c.Single(nullable: false),
                        FlangeThickness = c.Single(nullable: false),
                        FlangeThicknessTolerance = c.Single(nullable: false),
                        FlangeFaceProjection = c.Single(nullable: false),
                        RaisedFaceDiameter = c.Single(nullable: false),
                        FlangeGrooveWidth = c.Single(nullable: false),
                        SeatingDepth = c.Single(nullable: false),
                        BoltCircleDiameter = c.Single(nullable: false),
                        QuantityOfBoltsRequired = c.Int(nullable: false),
                        BoltDiameter = c.Single(nullable: false),
                        BodyOutsideDiameter = c.Single(nullable: false),
                        BoltPatternLength = c.Single(nullable: false),
                        BoltPatternWidth = c.Single(nullable: false),
                        GroovePitchDiameter = c.Single(nullable: false),
                        LapThickness = c.Single(nullable: false),
                        CounterBoreDepth = c.Single(nullable: false),
                        BoltPatternOffset = c.Single(nullable: false),
                        BodyOutsideDiameterUnits_ID = c.Int(),
                        BoltCircleDiameterUnits_ID = c.Int(),
                        BoltDiameterUnits_ID = c.Int(),
                        BoltPatternLengthUnits_ID = c.Int(),
                        BoltPatternOffsetUnits_ID = c.Int(),
                        BoltPatternWidthUnits_ID = c.Int(),
                        CounterBoreDepthUnits_ID = c.Int(),
                        DrillingTemplatePattern_ID = c.Int(),
                        EndPreparation_ID = c.Int(),
                        EndStandard_ID = c.Int(),
                        FlangeFaceProjectionUnits_ID = c.Int(),
                        FlangeGrooveWidthUnits_ID = c.Int(),
                        FlangeOutsideDiameterUnits_ID = c.Int(),
                        FlangeThicknessToleranceUnits_ID = c.Int(),
                        FlangeThicknessUnits_ID = c.Int(),
                        GroovePitchDiameterUnits_ID = c.Int(),
                        LapThicknessUnits_ID = c.Int(),
                        NominalDiameterUnits_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        RaisedFaceDiameterUnits_ID = c.Int(),
                        SeatingDepthUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BodyOutsideDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltCircleDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltPatternLengthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltPatternOffsetUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltPatternWidthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.CounterBoreDepthUnits_ID)
                .ForeignKey("dbo.DrillingTemplatePatterns", t => t.DrillingTemplatePattern_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation_ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangeFaceProjectionUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangeGrooveWidthUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangeOutsideDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangeThicknessToleranceUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FlangeThicknessUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.GroovePitchDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.LapThicknessUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NominalDiameterUnits_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.UnitTypes", t => t.RaisedFaceDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SeatingDepthUnits_ID)
                .Index(t => t.BodyOutsideDiameterUnits_ID)
                .Index(t => t.BoltCircleDiameterUnits_ID)
                .Index(t => t.BoltDiameterUnits_ID)
                .Index(t => t.BoltPatternLengthUnits_ID)
                .Index(t => t.BoltPatternOffsetUnits_ID)
                .Index(t => t.BoltPatternWidthUnits_ID)
                .Index(t => t.CounterBoreDepthUnits_ID)
                .Index(t => t.DrillingTemplatePattern_ID)
                .Index(t => t.EndPreparation_ID)
                .Index(t => t.EndStandard_ID)
                .Index(t => t.FlangeFaceProjectionUnits_ID)
                .Index(t => t.FlangeGrooveWidthUnits_ID)
                .Index(t => t.FlangeOutsideDiameterUnits_ID)
                .Index(t => t.FlangeThicknessToleranceUnits_ID)
                .Index(t => t.FlangeThicknessUnits_ID)
                .Index(t => t.GroovePitchDiameterUnits_ID)
                .Index(t => t.LapThicknessUnits_ID)
                .Index(t => t.NominalDiameterUnits_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.RaisedFaceDiameterUnits_ID)
                .Index(t => t.SeatingDepthUnits_ID);
            
            CreateTable(
                "dbo.PlainPipingGenericDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalPipingDiameter = c.Int(nullable: false),
                        PipingOutsideDiameter = c.Single(nullable: false),
                        WallThickness = c.Single(nullable: false),
                        EndStandard_ID = c.Int(),
                        NominalDiameterUnits_ID = c.Int(),
                        PipingOutsideDiameterUnits_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        Schedule_ID = c.Int(),
                        WallThicknessUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EndStandards", t => t.EndStandard_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NominalDiameterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.PipingOutsideDiameterUnits_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.Schedule_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WallThicknessUnits_ID)
                .Index(t => t.EndStandard_ID)
                .Index(t => t.NominalDiameterUnits_ID)
                .Index(t => t.PipingOutsideDiameterUnits_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.Schedule_ID)
                .Index(t => t.WallThicknessUnits_ID);
            
            CreateTable(
                "dbo.PreferredStudBoltLengths",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BoltDiameterFrom = c.Int(nullable: false),
                        BoltDiameterTo = c.Int(nullable: false),
                        BoltDiameterIncrement = c.Int(nullable: false),
                        PreferredBoltLengthFrom = c.Single(nullable: false),
                        PreferredBoltLengthTo = c.Single(nullable: false),
                        PreferredBoltLengthIncrement = c.Single(nullable: false),
                        BoltDiameterFromUnits_ID = c.Int(),
                        BoltDiameterIncrementUnits_ID = c.Int(),
                        BoltDiameterToUnits_ID = c.Int(),
                        MaterialsGrade_ID = c.Int(),
                        PreferredBoltLengthFromUnits_ID = c.Int(),
                        PreferredBoltLengthIncrementUnits_ID = c.Int(),
                        PreferredBoltLengthToUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterFromUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterIncrementUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterToUnits_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.PreferredBoltLengthFromUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.PreferredBoltLengthIncrementUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.PreferredBoltLengthToUnits_ID)
                .Index(t => t.BoltDiameterFromUnits_ID)
                .Index(t => t.BoltDiameterIncrementUnits_ID)
                .Index(t => t.BoltDiameterToUnits_ID)
                .Index(t => t.MaterialsGrade_ID)
                .Index(t => t.PreferredBoltLengthFromUnits_ID)
                .Index(t => t.PreferredBoltLengthIncrementUnits_ID)
                .Index(t => t.PreferredBoltLengthToUnits_ID);
            
            CreateTable(
                "dbo.ReducingTees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingPointBasis3 = c.Int(),
                        Id3 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        Npd3 = c.Int(nullable: false),
                        Face1toCenter = c.Single(nullable: false),
                        Face3toCenter = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndPreparation3_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        EndStandard3_ID = c.Int(),
                        Face1toCenterUnits_ID = c.Int(),
                        Face3toCenterUnits_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        FlowDirection3_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        NpdUnitType3_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        PressureRating3_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        ScheduleThickness3_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation3_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard3_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face1toCenterUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.Face3toCenterUnits_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection3_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType3_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating3_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness3_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndPreparation3_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.EndStandard3_ID)
                .Index(t => t.Face1toCenterUnits_ID)
                .Index(t => t.Face3toCenterUnits_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.FlowDirection3_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.NpdUnitType3_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.PressureRating3_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.ScheduleThickness3_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.SpectacleBlinds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        CentertoCenter = c.Single(nullable: false),
                        WebWidth = c.Single(nullable: false),
                        WebThickness = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CentertoCenterUnitType_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                        WebThicknessUnitType_ID = c.Int(),
                        WebWidthUnitType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.CentertoCenterUnitType_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WebThicknessUnitType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WebWidthUnitType_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CentertoCenterUnitType_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID)
                .Index(t => t.WebThicknessUnitType_ID)
                .Index(t => t.WebWidthUnitType_ID);
            
            CreateTable(
                "dbo.SupplementaryWasherRequirements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Thredolets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFittingCrotch = c.Single(nullable: false),
                        MajorBodyDia = c.Single(nullable: false),
                        HoleDia = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFittingCrotchUnits_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        HoleDiaUnits_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        MajorBodyDiaUnits_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFittingCrotchUnits_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.HoleDiaUnits_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MajorBodyDiaUnits_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFittingCrotchUnits_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.HoleDiaUnits_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.MajorBodyDiaUnits_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
            CreateTable(
                "dbo.WasherOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WasherPartDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        WasherThickness = c.Single(nullable: false),
                        GeometricIndustryStandard_ID = c.Int(),
                        MaterialsGrade_ID = c.Int(),
                        WasherThicknessUnits_ID = c.Int(),
                        WasherType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WasherThicknessUnits_ID)
                .ForeignKey("dbo.WasherTypes", t => t.WasherType_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.MaterialsGrade_ID)
                .Index(t => t.WasherThicknessUnits_ID)
                .Index(t => t.WasherType_ID);
            
            CreateTable(
                "dbo.WasherTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(maxLength: 50),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WasherSelectionFilters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaximumTemperature = c.Single(nullable: false),
                        BoltDiameter = c.Single(nullable: false),
                        ContractorCommodityCode = c.String(),
                        SupplWasherCntrCommodityCode = c.String(),
                        Comments = c.String(),
                        PipingNote1 = c.String(),
                        BoltDiameterUnits_ID = c.Int(),
                        FabricationCategoryOverride_ID = c.Int(),
                        MaximumTemperatureUnits_ID = c.Int(),
                        PipingMaterialsClassData_ID = c.Int(),
                        PressureRating_ID = c.Int(),
                        SupplementaryWasherReqmt_ID = c.Int(),
                        SupplyResponsibilityOverride_ID = c.Int(),
                        WasherOption_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BoltDiameterUnits_ID)
                .ForeignKey("dbo.FabricationTypes", t => t.FabricationCategoryOverride_ID)
                .ForeignKey("dbo.UnitTypes", t => t.MaximumTemperatureUnits_ID)
                .ForeignKey("dbo.PipingMaterialsClassDatas", t => t.PipingMaterialsClassData_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating_ID)
                .ForeignKey("dbo.SupplementaryWasherRequirements", t => t.SupplementaryWasherReqmt_ID)
                .ForeignKey("dbo.SupplyResponsibilities", t => t.SupplyResponsibilityOverride_ID)
                .ForeignKey("dbo.WasherOptions", t => t.WasherOption_ID)
                .Index(t => t.BoltDiameterUnits_ID)
                .Index(t => t.FabricationCategoryOverride_ID)
                .Index(t => t.MaximumTemperatureUnits_ID)
                .Index(t => t.PipingMaterialsClassData_ID)
                .Index(t => t.PressureRating_ID)
                .Index(t => t.SupplementaryWasherReqmt_ID)
                .Index(t => t.SupplyResponsibilityOverride_ID)
                .Index(t => t.WasherOption_ID);
            
            CreateTable(
                "dbo.WeldClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WeldTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodelistNumber = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        SortOrder = c.Int(),
                        WeldClass_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WeldClasses", t => t.WeldClass_ID)
                .Index(t => t.WeldClass_ID);
            
            CreateTable(
                "dbo.WeldModelRepresentations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NominalPipingDiameterFrom = c.Int(nullable: false),
                        NominalPipingDiameterTo = c.Int(nullable: false),
                        WeldRadiusIncrease = c.Single(nullable: false),
                        WeldThickness = c.Single(nullable: false),
                        MaterialsGrade_ID = c.Int(),
                        NominalPipingDiameterUnits_ID = c.Int(),
                        WeldClass_ID = c.Int(),
                        WeldRadiusIncreaseUnits_ID = c.Int(),
                        WeldThicknessUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialsGrade_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NominalPipingDiameterUnits_ID)
                .ForeignKey("dbo.WeldClasses", t => t.WeldClass_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WeldRadiusIncreaseUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WeldThicknessUnits_ID)
                .Index(t => t.MaterialsGrade_ID)
                .Index(t => t.NominalPipingDiameterUnits_ID)
                .Index(t => t.WeldClass_ID)
                .Index(t => t.WeldRadiusIncreaseUnits_ID)
                .Index(t => t.WeldThicknessUnits_ID);
            
            CreateTable(
                "dbo.WeldNeckFlanges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndustryCommodityCode = c.String(),
                        GraphicalRepresentationOrNot = c.Boolean(),
                        SymbolDefinition = c.String(),
                        SymbolIcon = c.String(),
                        BendRadius = c.Single(),
                        BendRadiusMultiplier = c.Single(),
                        PipingPointBasis1 = c.Int(),
                        Id1 = c.Int(),
                        PipingPointBasis2 = c.Int(),
                        Id2 = c.Int(),
                        PipingNote1 = c.String(),
                        DryWeight = c.Single(),
                        DryCogX = c.Single(),
                        DryCogY = c.Single(),
                        DryCogZ = c.Single(),
                        WaterWeight = c.Single(),
                        WaterCogX = c.Single(),
                        WaterCogY = c.Single(),
                        WaterCogZ = c.Single(),
                        SurfaceArea = c.Single(),
                        VolumetricCapacity = c.Single(),
                        Npd1 = c.Int(nullable: false),
                        Npd2 = c.Int(nullable: false),
                        FacetoFace = c.Single(nullable: false),
                        BendRadiusUnits_ID = c.Int(),
                        CommodityType_ID = c.Int(),
                        DryCogXUnits_ID = c.Int(),
                        DryCogYUnits_ID = c.Int(),
                        DryCogZUnits_ID = c.Int(),
                        DryWeightUnits_ID = c.Int(),
                        EndPreparation1_ID = c.Int(),
                        EndPreparation2_ID = c.Int(),
                        EndStandard1_ID = c.Int(),
                        EndStandard2_ID = c.Int(),
                        FacetoFaceUnitType_ID = c.Int(),
                        FlangeFaceSurfaceFinish_ID = c.Int(),
                        FlowDirection1_ID = c.Int(),
                        FlowDirection2_ID = c.Int(),
                        GeometricIndustryStandard_ID = c.Int(),
                        GeometryType_ID = c.Int(),
                        LiningMaterial_ID = c.Int(),
                        ManufacturingMethod_ID = c.Int(),
                        MaterialGrade_ID = c.Int(),
                        MirrorBehaviorOption_ID = c.Int(),
                        MiscRequisitionClassification_ID = c.Int(),
                        NpdUnitType1_ID = c.Int(),
                        NpdUnitType2_ID = c.Int(),
                        PartDataBasis_ID = c.Int(),
                        PressureRating1_ID = c.Int(),
                        PressureRating2_ID = c.Int(),
                        ScheduleThickness1_ID = c.Int(),
                        ScheduleThickness2_ID = c.Int(),
                        SurfaceAreaUnits_ID = c.Int(),
                        SurfacePreparation_ID = c.Int(),
                        ValveManufacturer_ID = c.Int(),
                        ValveModelNumber_ID = c.Int(),
                        ValveTrim_ID = c.Int(),
                        VolumetricCapacityUnits_ID = c.Int(),
                        WaterCogXUnits_ID = c.Int(),
                        WaterCogYUnits_ID = c.Int(),
                        WaterCogZUnits_ID = c.Int(),
                        WaterWeightUnits_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UnitTypes", t => t.BendRadiusUnits_ID)
                .ForeignKey("dbo.PipingCommodityTypes", t => t.CommodityType_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.DryWeightUnits_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndPreparation2_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard1_ID)
                .ForeignKey("dbo.EndPreparations", t => t.EndStandard2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.FacetoFaceUnitType_ID)
                .ForeignKey("dbo.FlangeFaceSurfaceFinishes", t => t.FlangeFaceSurfaceFinish_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection1_ID)
                .ForeignKey("dbo.FlowDirections", t => t.FlowDirection2_ID)
                .ForeignKey("dbo.GeometricIndustryStandards", t => t.GeometricIndustryStandard_ID)
                .ForeignKey("dbo.GeometryTypes", t => t.GeometryType_ID)
                .ForeignKey("dbo.LiningMaterials", t => t.LiningMaterial_ID)
                .ForeignKey("dbo.ManufacturingMethods", t => t.ManufacturingMethod_ID)
                .ForeignKey("dbo.MaterialsGrades", t => t.MaterialGrade_ID)
                .ForeignKey("dbo.MirrorBehaviorOptions", t => t.MirrorBehaviorOption_ID)
                .ForeignKey("dbo.MiscRequisitionClassifications", t => t.MiscRequisitionClassification_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType1_ID)
                .ForeignKey("dbo.UnitTypes", t => t.NpdUnitType2_ID)
                .ForeignKey("dbo.PartDataBasis", t => t.PartDataBasis_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating1_ID)
                .ForeignKey("dbo.PressureRatings", t => t.PressureRating2_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness1_ID)
                .ForeignKey("dbo.ScheduleThicknesses", t => t.ScheduleThickness2_ID)
                .ForeignKey("dbo.UnitTypes", t => t.SurfaceAreaUnits_ID)
                .ForeignKey("dbo.SurfacePreparations", t => t.SurfacePreparation_ID)
                .ForeignKey("dbo.ValveManufacturers", t => t.ValveManufacturer_ID)
                .ForeignKey("dbo.ValveModelNumbers", t => t.ValveModelNumber_ID)
                .ForeignKey("dbo.ValveTrims", t => t.ValveTrim_ID)
                .ForeignKey("dbo.UnitTypes", t => t.VolumetricCapacityUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogXUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogYUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterCogZUnits_ID)
                .ForeignKey("dbo.UnitTypes", t => t.WaterWeightUnits_ID)
                .Index(t => t.BendRadiusUnits_ID)
                .Index(t => t.CommodityType_ID)
                .Index(t => t.DryCogXUnits_ID)
                .Index(t => t.DryCogYUnits_ID)
                .Index(t => t.DryCogZUnits_ID)
                .Index(t => t.DryWeightUnits_ID)
                .Index(t => t.EndPreparation1_ID)
                .Index(t => t.EndPreparation2_ID)
                .Index(t => t.EndStandard1_ID)
                .Index(t => t.EndStandard2_ID)
                .Index(t => t.FacetoFaceUnitType_ID)
                .Index(t => t.FlangeFaceSurfaceFinish_ID)
                .Index(t => t.FlowDirection1_ID)
                .Index(t => t.FlowDirection2_ID)
                .Index(t => t.GeometricIndustryStandard_ID)
                .Index(t => t.GeometryType_ID)
                .Index(t => t.LiningMaterial_ID)
                .Index(t => t.ManufacturingMethod_ID)
                .Index(t => t.MaterialGrade_ID)
                .Index(t => t.MirrorBehaviorOption_ID)
                .Index(t => t.MiscRequisitionClassification_ID)
                .Index(t => t.NpdUnitType1_ID)
                .Index(t => t.NpdUnitType2_ID)
                .Index(t => t.PartDataBasis_ID)
                .Index(t => t.PressureRating1_ID)
                .Index(t => t.PressureRating2_ID)
                .Index(t => t.ScheduleThickness1_ID)
                .Index(t => t.ScheduleThickness2_ID)
                .Index(t => t.SurfaceAreaUnits_ID)
                .Index(t => t.SurfacePreparation_ID)
                .Index(t => t.ValveManufacturer_ID)
                .Index(t => t.ValveModelNumber_ID)
                .Index(t => t.ValveTrim_ID)
                .Index(t => t.VolumetricCapacityUnits_ID)
                .Index(t => t.WaterCogXUnits_ID)
                .Index(t => t.WaterCogYUnits_ID)
                .Index(t => t.WaterCogZUnits_ID)
                .Index(t => t.WaterWeightUnits_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeldNeckFlanges", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.WeldNeckFlanges", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.WeldNeckFlanges", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.WeldNeckFlanges", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.WeldNeckFlanges", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.WeldNeckFlanges", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.WeldNeckFlanges", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.WeldNeckFlanges", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.WeldNeckFlanges", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.WeldNeckFlanges", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.WeldNeckFlanges", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.WeldNeckFlanges", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.WeldNeckFlanges", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.WeldNeckFlanges", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.WeldNeckFlanges", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.WeldNeckFlanges", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.WeldNeckFlanges", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.WeldNeckFlanges", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.WeldNeckFlanges", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.WeldNeckFlanges", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.WeldNeckFlanges", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.WeldNeckFlanges", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.WeldNeckFlanges", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.WeldNeckFlanges", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldModelRepresentations", "WeldThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldModelRepresentations", "WeldRadiusIncreaseUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldModelRepresentations", "WeldClass_ID", "dbo.WeldClasses");
            DropForeignKey("dbo.WeldModelRepresentations", "NominalPipingDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WeldModelRepresentations", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.WeldTypes", "WeldClass_ID", "dbo.WeldClasses");
            DropForeignKey("dbo.WasherSelectionFilters", "WasherOption_ID", "dbo.WasherOptions");
            DropForeignKey("dbo.WasherSelectionFilters", "SupplyResponsibilityOverride_ID", "dbo.SupplyResponsibilities");
            DropForeignKey("dbo.WasherSelectionFilters", "SupplementaryWasherReqmt_ID", "dbo.SupplementaryWasherRequirements");
            DropForeignKey("dbo.WasherSelectionFilters", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.WasherSelectionFilters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.WasherSelectionFilters", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WasherSelectionFilters", "FabricationCategoryOverride_ID", "dbo.FabricationTypes");
            DropForeignKey("dbo.WasherSelectionFilters", "BoltDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WasherPartDatas", "WasherType_ID", "dbo.WasherTypes");
            DropForeignKey("dbo.WasherPartDatas", "WasherThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.WasherPartDatas", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.WasherPartDatas", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.Thredolets", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.Thredolets", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Thredolets", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Thredolets", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Thredolets", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Thredolets", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Thredolets", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.Thredolets", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Thredolets", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.Thredolets", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.Thredolets", "MajorBodyDiaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.Thredolets", "HoleDiaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.Thredolets", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.Thredolets", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Thredolets", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Thredolets", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.Thredolets", "FacetoFittingCrotchUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Thredolets", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Thredolets", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Thredolets", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Thredolets", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Thredolets", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.Thredolets", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WebWidthUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WebThicknessUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.SpectacleBlinds", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.SpectacleBlinds", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.SpectacleBlinds", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.SpectacleBlinds", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.SpectacleBlinds", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.SpectacleBlinds", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.SpectacleBlinds", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.SpectacleBlinds", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.SpectacleBlinds", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.SpectacleBlinds", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.SpectacleBlinds", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.SpectacleBlinds", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.SpectacleBlinds", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.SpectacleBlinds", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.SpectacleBlinds", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.SpectacleBlinds", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.SpectacleBlinds", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.SpectacleBlinds", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.SpectacleBlinds", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.SpectacleBlinds", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.SpectacleBlinds", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.SpectacleBlinds", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.SpectacleBlinds", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.SpectacleBlinds", "CentertoCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.SpectacleBlinds", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.ReducingTees", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.ReducingTees", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.ReducingTees", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.ReducingTees", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "ScheduleThickness3_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ReducingTees", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ReducingTees", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ReducingTees", "PressureRating3_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ReducingTees", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ReducingTees", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ReducingTees", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.ReducingTees", "NpdUnitType3_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.ReducingTees", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.ReducingTees", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.ReducingTees", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.ReducingTees", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.ReducingTees", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.ReducingTees", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.ReducingTees", "FlowDirection3_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ReducingTees", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ReducingTees", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ReducingTees", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.ReducingTees", "Face3toCenterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "Face1toCenterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "EndStandard3_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "EndPreparation3_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ReducingTees", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ReducingTees", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.ReducingTees", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "PreferredBoltLengthToUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "PreferredBoltLengthIncrementUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "PreferredBoltLengthFromUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.PreferredStudBoltLengths", "BoltDiameterToUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "BoltDiameterIncrementUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PreferredStudBoltLengths", "BoltDiameterFromUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PlainPipingGenericDatas", "WallThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PlainPipingGenericDatas", "Schedule_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.PlainPipingGenericDatas", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.PlainPipingGenericDatas", "PipingOutsideDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PlainPipingGenericDatas", "NominalDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PlainPipingGenericDatas", "EndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.PipingGenericDataBolteds", "SeatingDepthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "RaisedFaceDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.PipingGenericDataBolteds", "NominalDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "LapThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "GroovePitchDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "FlangeThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "FlangeThicknessToleranceUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "FlangeOutsideDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "FlangeGrooveWidthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "FlangeFaceProjectionUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "EndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.PipingGenericDataBolteds", "EndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.PipingGenericDataBolteds", "DrillingTemplatePattern_ID", "dbo.DrillingTemplatePatterns");
            DropForeignKey("dbo.PipingGenericDataBolteds", "CounterBoreDepthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BoltPatternWidthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BoltPatternOffsetUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BoltPatternLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BoltDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BoltCircleDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingGenericDataBolteds", "BodyOutsideDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "ShortCodeHierarchyRule_ID", "dbo.ShortCodeHierarchyRules");
            DropForeignKey("dbo.PipingCommodityFilters", "SelectionBasis_ID", "dbo.SelectionBasis");
            DropForeignKey("dbo.PipingCommodityFilters", "SecondSizeUOMBasisInCatalog_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "SecondSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.PipingCommodityFilters", "PipingCommodityMatlControlData_ID", "dbo.PipingCommodityMatlControlDatas");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "WeldingRequirement_ID", "dbo.WeldingRequirements");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "Vendor_ID", "dbo.Vendors");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "ValveOperatorType_ID", "dbo.ValveOperatorTypes");
            DropForeignKey("dbo.ValveOperatorTypes", "ValveOperatorClass_ID", "dbo.ValveOperatorClasses");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "ValveOperatorGeoIndStd_ID", "dbo.ValveOperatorGeometricIndStds");
            DropForeignKey("dbo.ValveOperatorGeometricIndStds", "ValveOperatorGeometricIndPract_ID", "dbo.ValveOperatorGeometricIndPracts");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "SupplyResponsibility_ID", "dbo.SupplyResponsibilities");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "SubstCapScrewDiameterUnits_ID", "dbo.UnitClasses");
            DropForeignKey("dbo.UnitTypes", "UnitClass_ID", "dbo.UnitClasses");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "SecondSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "ReportingType_ID", "dbo.ReportingTypes");
            DropForeignKey("dbo.ReportingTypes", "ReportingRequirement_ID", "dbo.ReportingRequirements");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "PartDataSource_ID", "dbo.PartDataSources");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "MultiportValveOpReq_ID", "dbo.MultiportValveOpReqs");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "Manufacturer_ID", "dbo.Manufacturers");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "LooseMaterialRequirements_ID", "dbo.LooseMaterialRequirements");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "GasketRequirements_ID", "dbo.GasketRequirements");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "FirstSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "FabricationType_ID", "dbo.FabricationTypes");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "ClampRequirement_ID", "dbo.ClampRequirements");
            DropForeignKey("dbo.PipingCommodityMatlControlDatas", "BoltingRequirements_ID", "dbo.BoltingRequirements");
            DropForeignKey("dbo.PipingCommodityFilters", "OptionCode_ID", "dbo.CommodityOptions");
            DropForeignKey("dbo.PipingCommodityFilters", "MinimumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "JacketedPipingBasis_ID", "dbo.JacketedPipingBasis");
            DropForeignKey("dbo.PipingCommodityFilters", "FluidCode_ID", "dbo.FluidCodes");
            DropForeignKey("dbo.PipingCommodityFilters", "FirstSizeUOMBasisInCatalog_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipingCommodityFilters", "FirstSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "WeightPerUnitLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.PipeStocks", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.PipeStocks", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.PipeStocks", "PurchaseLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.PipeStocks", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.PipeStocks", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "MinimumPipeLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "MaximumPipeLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.PipeStocks", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.PipeStocks", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.PipeStocks", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.PipeStocks", "EndStandard2_ID", "dbo.EndStandards");
            DropForeignKey("dbo.PipeStocks", "EndStandard1_ID", "dbo.EndStandards");
            DropForeignKey("dbo.PipeStocks", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.PipeStocks", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.PipeStocks", "DryWeightForEnd2Units_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "DryWeightForEnd1Units_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeStocks", "DensityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeNominalDiameters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.PipeNominalDiameters", "NpdUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeBranches", "TertiaryShortCode_ID", "dbo.ShortCodeHierarchyRules");
            DropForeignKey("dbo.PipeBranches", "ShortCode_ID", "dbo.ShortCodeHierarchyRules");
            DropForeignKey("dbo.PipeBranches", "SecondaryShortCode_ID", "dbo.ShortCodeHierarchyRules");
            DropForeignKey("dbo.PipeBranches", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.PipeBranches", "HdrSizeNPDUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeBranches", "BrSizeNPDUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeBranches", "AngleLowUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.PipeBranches", "AngleHighUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.Paddles", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.Paddles", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.Paddles", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.Paddles", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Paddles", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Paddles", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Paddles", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Paddles", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Paddles", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.Paddles", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Paddles", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.Paddles", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.Paddles", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.Paddles", "HandletoCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.Paddles", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.Paddles", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Paddles", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Paddles", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.Paddles", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Paddles", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Paddles", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Paddles", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Paddles", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Paddles", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.Paddles", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "ValveSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "ValveOperatorIsRotatable_ID", "dbo.ValveOperatorIsRotatables");
            DropForeignKey("dbo.Operator9", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Operator9", "HeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "HandleLengthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator9", "DimensionalBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Operator5", "ValveSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "ValveOperatorIsRotatable_ID", "dbo.ValveOperatorIsRotatables");
            DropForeignKey("dbo.Operator5", "OperatorHeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Operator5", "HandWheelDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator5", "DimensionalBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Operator351", "ValveSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "ValveOperatorIsRotatable_ID", "dbo.ValveOperatorIsRotatables");
            DropForeignKey("dbo.Operator351", "OperatorHeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "OffsetFrmValCenUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Operator351", "HwZOffsetOpFrmStemUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "HwXOffsetFrmOpStemUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "HwOffsetFrmValCenUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "HWDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator351", "DimensionalBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Operator332", "ValveSizeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "ValveOperatorIsRotatable_ID", "dbo.ValveOperatorIsRotatables");
            DropForeignKey("dbo.Operator332", "ValCenToHWTopUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "ValCenToHWCenUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Operator332", "HwZOffsetOpFrmStemUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "HwYOffsetFrmGearBotUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "HwXOffsetFrmOpStemUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "HWDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "HandWheelRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "GearRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "GearDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "GearDepthUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "ExStemLenUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "ExStemLenFrmValCenUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "ExStemDiaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Operator332", "DimensionalBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.NutSelectionFilters", "SupplyResponsibilityOverride_ID", "dbo.SupplyResponsibilities");
            DropForeignKey("dbo.NutSelectionFilters", "SupplementaryNutOption_ID", "dbo.SupplementaryNutRequirements");
            DropForeignKey("dbo.NutSelectionFilters", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.NutSelectionFilters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.NutSelectionFilters", "NutOption_ID", "dbo.NutOptions");
            DropForeignKey("dbo.NutSelectionFilters", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.NutSelectionFilters", "FabricationCategoryOverride_ID", "dbo.FabricationTypes");
            DropForeignKey("dbo.NutSelectionFilters", "BoltType_ID", "dbo.BoltTypes");
            DropForeignKey("dbo.NutSelectionFilters", "BoltDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.NutPartDatas", "NutType_ID", "dbo.NutTypes");
            DropForeignKey("dbo.NutPartDatas", "NutHeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.NutPartDatas", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.NutPartDatas", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.MatingPorts", "EndPrep2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.MatingPorts", "EndPrep1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Manufacturers", "ManufacturerIndustryPractice_ID", "dbo.ManufacturerIndustryPractices");
            DropForeignKey("dbo.GlobeValves", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.GlobeValves", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.GlobeValves", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.GlobeValves", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.GlobeValves", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.GlobeValves", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.GlobeValves", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GlobeValves", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GlobeValves", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.GlobeValves", "OffsetFrmValCenUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "MountingFlangeDiaUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.GlobeValves", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.GlobeValves", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.GlobeValves", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.GlobeValves", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.GlobeValves", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.GlobeValves", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.GlobeValves", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.GlobeValves", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.GlobeValves", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.GlobeValves", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "FacetoCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "Face2toCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "Face1toCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GlobeValves", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GlobeValves", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GlobeValves", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GlobeValves", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "DiameterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.GlobeValves", "BonnetFlangeDiaUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GlobeValves", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.GateValves", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.GateValves", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.GateValves", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.GateValves", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.GateValves", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.GateValves", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GateValves", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GateValves", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.GateValves", "OffsetFrmValCenUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.GateValves", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.GateValves", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.GateValves", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.GateValves", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.GateValves", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.GateValves", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.GateValves", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.GateValves", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.GateValves", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.GateValves", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GateValves", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GateValves", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GateValves", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GateValves", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "DiameterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GateValves", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.GateValves", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketSelectionFilters", "SupplyResponsibilityOverride_ID", "dbo.SupplyResponsibilities");
            DropForeignKey("dbo.GasketSelectionFilters", "ScheduleThickness_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.GasketSelectionFilters", "RingNumber_ID", "dbo.RingNumbers");
            DropForeignKey("dbo.GasketSelectionFilters", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GasketSelectionFilters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.GasketSelectionFilters", "NpdUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketSelectionFilters", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketSelectionFilters", "GasketOption_ID", "dbo.GasketOptions");
            DropForeignKey("dbo.GasketSelectionFilters", "FluidCode_ID", "dbo.FluidCodes");
            DropForeignKey("dbo.GasketSelectionFilters", "FabricationCategoryOverride_ID", "dbo.FabricationTypes");
            DropForeignKey("dbo.GasketSelectionFilters", "EndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.GasketSelectionFilters", "EndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GasketSelectionFilters", "AlternatePressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.GasketSelectionFilters", "AlternateEndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.GasketSelectionFilters", "AlternateEndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.GasketPartDatas", "TightnessCurveSlopeUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "ThicknessFor3DModelUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "RingNumber_ID", "dbo.RingNumbers");
            DropForeignKey("dbo.RingNumbers", "RingNumberPractice_ID", "dbo.RingNumberPractices");
            DropForeignKey("dbo.GasketPartDatas", "ProcurementThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "NpdUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "MetallicElectroPlatedWasherThkUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "MaximumPressureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.GasketPartDatas", "InsulatingWasherThicknessUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "GasketType_ID", "dbo.GasketTypes");
            DropForeignKey("dbo.GasketPartDatas", "GasketOutsideDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "GasketOutsideDiameterBasis_ID", "dbo.GasketOutsideDiameterBasis");
            DropForeignKey("dbo.GasketPartDatas", "GasketInsideDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "GasketInsideDiameterBasis_ID", "dbo.GasketInsideDiameterBasis");
            DropForeignKey("dbo.GasketPartDatas", "GasketIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.GasketPartDatas", "FlangePressureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.GasketPartDatas", "FlangeInsulationKitType_ID", "dbo.FlangeInsulationKitTypes");
            DropForeignKey("dbo.GasketPartDatas", "FlangeFacing_ID", "dbo.FlangeFacings");
            DropForeignKey("dbo.GasketTypes", "GasketCategory_ID", "dbo.GasketCategories");
            DropForeignKey("dbo.FluidCodes", "FluidSystem_ID", "dbo.FluidSystems");
            DropForeignKey("dbo.Elbows", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.Elbows", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.Elbows", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.Elbows", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.Elbows", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Elbows", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Elbows", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Elbows", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Elbows", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Elbows", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.Elbows", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Elbows", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.Elbows", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.Elbows", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.Elbows", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.Elbows", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.Elbows", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Elbows", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Elbows", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.Elbows", "FacetoCenterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Elbows", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Elbows", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Elbows", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Elbows", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.Elbows", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Elbows", "BendAngleUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.EccentricReducers", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.EccentricReducers", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.EccentricReducers", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.EccentricReducers", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.EccentricReducers", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.EccentricReducers", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.EccentricReducers", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.EccentricReducers", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.EccentricReducers", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.EccentricReducers", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.EccentricReducers", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.EccentricReducers", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.EccentricReducers", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.EccentricReducers", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.EccentricReducers", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.EccentricReducers", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.EccentricReducers", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.EccentricReducers", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.EccentricReducers", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.EccentricReducers", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.EccentricReducers", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.EccentricReducers", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.EccentricReducers", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.EccentricReducers", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.EccentricReducers", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.DefaultChangeOfDirectionPerSpecs", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.DefaultChangeOfDirectionPerSpecs", "FunctionalShortCode_ID", "dbo.ShortCodeHierarchyRules");
            DropForeignKey("dbo.ShortCodeHierarchyRules", "ShortCodeHierarchyType_ID", "dbo.ShortCodeHierarchyTypes");
            DropForeignKey("dbo.ShortCodeHierarchyTypes", "ShortCodeHierarchyClass_ID", "dbo.ShortCodeHierarchyClasses");
            DropForeignKey("dbo.DefaultChangeOfDirectionPerSpecs", "BendAngleToUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.DefaultChangeOfDirectionPerSpecs", "BendAngleFromUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.ConcentricReducers", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.ConcentricReducers", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.ConcentricReducers", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.ConcentricReducers", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ConcentricReducers", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ConcentricReducers", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ConcentricReducers", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ConcentricReducers", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.ConcentricReducers", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.ConcentricReducers", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.ConcentricReducers", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.ConcentricReducers", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.ConcentricReducers", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.ConcentricReducers", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.ConcentricReducers", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.ConcentricReducers", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ConcentricReducers", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ConcentricReducers", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.ConcentricReducers", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ConcentricReducers", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ConcentricReducers", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ConcentricReducers", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ConcentricReducers", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ConcentricReducers", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.ConcentricReducers", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CommodityOptions", "OptionCategory_ID", "dbo.OptionCategories");
            DropForeignKey("dbo.CheckValves", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.CheckValves", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.CheckValves", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.CheckValves", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.CheckValves", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.CheckValves", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.CheckValves", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.CheckValves", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.CheckValves", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.CheckValves", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.CheckValves", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.CheckValves", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.CheckValves", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.CheckValves", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.CheckValves", "HeightFrmValCenUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.CheckValves", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.CheckValves", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.CheckValves", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.CheckValves", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.CheckValves", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "EqualizerClearanceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.CheckValves", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.CheckValves", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.CheckValves", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.CheckValves", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "DiameterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.CheckValves", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.CheckValves", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.Caps", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.Caps", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.Caps", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.Caps", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.Caps", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.Caps", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.Caps", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.Caps", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.Caps", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.Caps", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.Caps", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.Caps", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.Caps", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.Caps", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.Caps", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.Caps", "FacetoEndUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Caps", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.Caps", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.Caps", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.Caps", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "WidthUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ButterflyValves", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ButterflyValves", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ButterflyValves", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.ButterflyValves", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.ButterflyValves", "OffsetFrmValCenUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "OffsetFrmValBotmUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.ButterflyValves", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.ButterflyValves", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.ButterflyValves", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.ButterflyValves", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.ButterflyValves", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.ButterflyValves", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ButterflyValves", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.ButterflyValves", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "Face2toCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ButterflyValves", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ButterflyValves", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ButterflyValves", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.ButterflyValves", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "CUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.ButterflyValves", "BUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.ButterflyValves", "AUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltSelectionFilters", "SupplyResponsibilityOverride_ID", "dbo.SupplyResponsibilities");
            DropForeignKey("dbo.BoltSelectionFilters", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.BoltSelectionFilters", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.BoltSelectionFilters", "NpdUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltSelectionFilters", "MaximumTemperatureUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltSelectionFilters", "LubricationRequirements_ID", "dbo.BoltLubricationRequirements");
            DropForeignKey("dbo.BoltSelectionFilters", "FabricationCategoryOverride_ID", "dbo.FabricationTypes");
            DropForeignKey("dbo.FabricationTypes", "FabricationRequirement_ID", "dbo.FabricationRequirements");
            DropForeignKey("dbo.BoltSelectionFilters", "EndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.BoltSelectionFilters", "EndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BoltSelectionFilters", "BoltOption_ID", "dbo.BoltOptions");
            DropForeignKey("dbo.BoltSelectionFilters", "BoltExtensionOption_ID", "dbo.BoltExtensionOptions");
            DropForeignKey("dbo.BoltSelectionFilters", "AlternateEndStandard_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.BoltSelectionFilters", "AlternateEndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BoltPartDatas", "MaterialsGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.BoltPartDatas", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.BoltPartDatas", "CoatingType_ID", "dbo.CoatingTypes");
            DropForeignKey("dbo.CoatingTypes", "CoatingRequirement_ID", "dbo.CoatingRequirements");
            DropForeignKey("dbo.BoltPartDatas", "BoltType_ID", "dbo.BoltTypes");
            DropForeignKey("dbo.BoltExtensions", "StandardBoltExtForMachBoltsUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltExtensions", "StandardBoltExtensionForStudsUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltExtensions", "PressureRating_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.BoltExtensions", "NominalPipingDiameterUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BoltExtensions", "EndStandard_ID", "dbo.EndStandards");
            DropForeignKey("dbo.EndStandards", "EndPractice_ID", "dbo.EndPractices");
            DropForeignKey("dbo.BoltExtensions", "EndPreparation_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BlindFlanges", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.BlindFlanges", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.BlindFlanges", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.BlindFlanges", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.BlindFlanges", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.BlindFlanges", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.BlindFlanges", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.BlindFlanges", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.BlindFlanges", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.BlindFlanges", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.BlindFlanges", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.BlindFlanges", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.BlindFlanges", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.BlindFlanges", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.BlindFlanges", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.BlindFlanges", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.BlindFlanges", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BlindFlanges", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BlindFlanges", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BlindFlanges", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.BlindFlanges", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BendAngles", "PipingMaterialsClassData_ID", "dbo.PipingMaterialsClassDatas");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "WasherCreationOption_ID", "dbo.WasherCreationOptions");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "StressReliefRequirement_ID", "dbo.StressReliefRequirements");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "StressRelief_ID", "dbo.StressReliefs");
            DropForeignKey("dbo.StressReliefs", "StressReliefPractice_ID", "dbo.StressReliefPractices");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "PipingCommodityOverrideOption_ID", "dbo.PipingCommodityOverrideOptions");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "MaterialsType_ID", "dbo.MaterialsTypes");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "MaterialsOfConstructionClass_ID", "dbo.MaterialsOfConstructionClasses");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "MaterialsGroup_ID", "dbo.MaterialsGroups");
            DropForeignKey("dbo.MaterialsTypes", "MaterialsGroup_ID", "dbo.MaterialsGroups");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "GasketRequirementOverride_ID", "dbo.GasketRequirementOverrides");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "Examination_ID", "dbo.Examinations");
            DropForeignKey("dbo.Examinations", "ExaminationPractice_ID", "dbo.ExaminationPractices");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "DesignStandard_ID", "dbo.DesignStandards");
            DropForeignKey("dbo.DesignStandards", "DesignStandardPractice_ID", "dbo.DesignStandardPractices");
            DropForeignKey("dbo.PipingMaterialsClassDatas", "AutomatedFlangeSelectionOption_ID", "dbo.AutomatedFlangeSelectionOptions");
            DropForeignKey("dbo.BendAngles", "NpdUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BendAngles", "BendAngleUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "WidthUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "WaterWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "WaterCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "WaterCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "WaterCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "VolumetricCapacityUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "ValveTrim_ID", "dbo.ValveTrims");
            DropForeignKey("dbo.ValveTrims", "ValveTrimPractice_ID", "dbo.ValveTrimPractices");
            DropForeignKey("dbo.BallValves", "ValveModelNumber_ID", "dbo.ValveModelNumbers");
            DropForeignKey("dbo.BallValves", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.ValveModelNumbers", "ValveManufacturer_ID", "dbo.ValveManufacturers");
            DropForeignKey("dbo.ValveManufacturers", "ValveManufacturerIndPractice_ID", "dbo.ValveManufacturerIndPractices");
            DropForeignKey("dbo.BallValves", "SurfacePreparation_ID", "dbo.SurfacePreparations");
            DropForeignKey("dbo.BallValves", "SurfaceAreaUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "ScheduleThickness2_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.BallValves", "ScheduleThickness1_ID", "dbo.ScheduleThicknesses");
            DropForeignKey("dbo.ScheduleThicknesses", "ScheduleThicknessPractice_ID", "dbo.ScheduleThicknessPractices");
            DropForeignKey("dbo.BallValves", "PressureRating2_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.BallValves", "PressureRating1_ID", "dbo.PressureRatings");
            DropForeignKey("dbo.PressureRatings", "RatingPractice_ID", "dbo.RatingPractices");
            DropForeignKey("dbo.BallValves", "PartDataBasis_ID", "dbo.PartDataBasis");
            DropForeignKey("dbo.BallValves", "OffsetFrmValCenUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "NpdUnitType2_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "NpdUnitType1_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "MiscRequisitionClassification_ID", "dbo.MiscRequisitionClassifications");
            DropForeignKey("dbo.MiscRequisitionClassifications", "MiscRequisitionComponentType_ID", "dbo.MiscRequisitionComponentTypes");
            DropForeignKey("dbo.BallValves", "MirrorBehaviorOption_ID", "dbo.MirrorBehaviorOptions");
            DropForeignKey("dbo.BallValves", "MaterialGrade_ID", "dbo.MaterialsGrades");
            DropForeignKey("dbo.MaterialsGrades", "MaterialsCategory_ID", "dbo.MaterialsCategories");
            DropForeignKey("dbo.MaterialsCategories", "MaterialsGradePractice_ID", "dbo.MaterialsGradePractices");
            DropForeignKey("dbo.BallValves", "ManufacturingMethod_ID", "dbo.ManufacturingMethods");
            DropForeignKey("dbo.BallValves", "LiningMaterial_ID", "dbo.LiningMaterials");
            DropForeignKey("dbo.LiningMaterials", "LiningRequirements_ID", "dbo.LiningRequirements");
            DropForeignKey("dbo.BallValves", "HeightUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "GeometryType_ID", "dbo.GeometryTypes");
            DropForeignKey("dbo.BallValves", "GeometricIndustryStandard_ID", "dbo.GeometricIndustryStandards");
            DropForeignKey("dbo.GeometricIndustryStandards", "GeometricIndustryPractice_ID", "dbo.GeometricIndustryPractices");
            DropForeignKey("dbo.BallValves", "FlowDirection2_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.BallValves", "FlowDirection1_ID", "dbo.FlowDirections");
            DropForeignKey("dbo.BallValves", "FlangeFaceSurfaceFinish_ID", "dbo.FlangeFaceSurfaceFinishes");
            DropForeignKey("dbo.BallValves", "FacetoFaceUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "Face1toCenterUnitType_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "EndStandard2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BallValves", "EndStandard1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BallValves", "EndPreparation2_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.BallValves", "EndPreparation1_ID", "dbo.EndPreparations");
            DropForeignKey("dbo.TerminationSubClasses", "TerminationClass_ID", "dbo.TerminationClasses");
            DropForeignKey("dbo.EndPreparations", "TerminationSubClass_ID", "dbo.TerminationSubClasses");
            DropForeignKey("dbo.BallValves", "DryWeightUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "DryCogZUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "DryCogYUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "DryCogXUnits_ID", "dbo.UnitTypes");
            DropForeignKey("dbo.BallValves", "CommodityType_ID", "dbo.PipingCommodityTypes");
            DropForeignKey("dbo.PipingCommodityTypes", "PipingCommoditySubClass_ID", "dbo.PipingCommoditySubClasses");
            DropForeignKey("dbo.PipingCommoditySubClasses", "PipingCommodityClass_ID", "dbo.PipingCommodityClasses");
            DropForeignKey("dbo.BallValves", "BendRadiusUnits_ID", "dbo.UnitTypes");
            DropIndex("dbo.WeldNeckFlanges", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ValveTrim_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "PressureRating2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "PressureRating1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "GeometryType_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "EndStandard2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "EndStandard1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "CommodityType_ID" });
            DropIndex("dbo.WeldNeckFlanges", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.WeldModelRepresentations", new[] { "WeldThicknessUnits_ID" });
            DropIndex("dbo.WeldModelRepresentations", new[] { "WeldRadiusIncreaseUnits_ID" });
            DropIndex("dbo.WeldModelRepresentations", new[] { "WeldClass_ID" });
            DropIndex("dbo.WeldModelRepresentations", new[] { "NominalPipingDiameterUnits_ID" });
            DropIndex("dbo.WeldModelRepresentations", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.WeldTypes", new[] { "WeldClass_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "WasherOption_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "SupplyResponsibilityOverride_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "SupplementaryWasherReqmt_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "PressureRating_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "FabricationCategoryOverride_ID" });
            DropIndex("dbo.WasherSelectionFilters", new[] { "BoltDiameterUnits_ID" });
            DropIndex("dbo.WasherPartDatas", new[] { "WasherType_ID" });
            DropIndex("dbo.WasherPartDatas", new[] { "WasherThicknessUnits_ID" });
            DropIndex("dbo.WasherPartDatas", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.WasherPartDatas", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.Thredolets", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.Thredolets", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.Thredolets", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.Thredolets", new[] { "PressureRating2_ID" });
            DropIndex("dbo.Thredolets", new[] { "PressureRating1_ID" });
            DropIndex("dbo.Thredolets", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.Thredolets", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.Thredolets", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.Thredolets", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.Thredolets", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Thredolets", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.Thredolets", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.Thredolets", new[] { "MajorBodyDiaUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.Thredolets", new[] { "HoleDiaUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "GeometryType_ID" });
            DropIndex("dbo.Thredolets", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.Thredolets", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.Thredolets", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.Thredolets", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.Thredolets", new[] { "FacetoFittingCrotchUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "EndStandard2_ID" });
            DropIndex("dbo.Thredolets", new[] { "EndStandard1_ID" });
            DropIndex("dbo.Thredolets", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.Thredolets", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.Thredolets", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Thredolets", new[] { "CommodityType_ID" });
            DropIndex("dbo.Thredolets", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WebWidthUnitType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WebThicknessUnitType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ValveTrim_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "PressureRating2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "PressureRating1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "GeometryType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "EndStandard2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "EndStandard1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "CommodityType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "CentertoCenterUnitType_ID" });
            DropIndex("dbo.SpectacleBlinds", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ValveTrim_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.ReducingTees", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.ReducingTees", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ScheduleThickness3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "PressureRating3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "PressureRating2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "PressureRating1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.ReducingTees", new[] { "NpdUnitType3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.ReducingTees", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.ReducingTees", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.ReducingTees", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.ReducingTees", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.ReducingTees", new[] { "GeometryType_ID" });
            DropIndex("dbo.ReducingTees", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.ReducingTees", new[] { "FlowDirection3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.ReducingTees", new[] { "Face3toCenterUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "Face1toCenterUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndStandard3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndStandard2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndStandard1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndPreparation3_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.ReducingTees", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.ReducingTees", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.ReducingTees", new[] { "CommodityType_ID" });
            DropIndex("dbo.ReducingTees", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "PreferredBoltLengthToUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "PreferredBoltLengthIncrementUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "PreferredBoltLengthFromUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "BoltDiameterToUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "BoltDiameterIncrementUnits_ID" });
            DropIndex("dbo.PreferredStudBoltLengths", new[] { "BoltDiameterFromUnits_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "WallThicknessUnits_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "Schedule_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "PressureRating_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "PipingOutsideDiameterUnits_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "NominalDiameterUnits_ID" });
            DropIndex("dbo.PlainPipingGenericDatas", new[] { "EndStandard_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "SeatingDepthUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "RaisedFaceDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "PressureRating_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "NominalDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "LapThicknessUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "GroovePitchDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "FlangeThicknessUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "FlangeThicknessToleranceUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "FlangeOutsideDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "FlangeGrooveWidthUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "FlangeFaceProjectionUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "EndStandard_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "EndPreparation_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "DrillingTemplatePattern_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "CounterBoreDepthUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BoltPatternWidthUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BoltPatternOffsetUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BoltPatternLengthUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BoltDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BoltCircleDiameterUnits_ID" });
            DropIndex("dbo.PipingGenericDataBolteds", new[] { "BodyOutsideDiameterUnits_ID" });
            DropIndex("dbo.ValveOperatorTypes", new[] { "ValveOperatorClass_ID" });
            DropIndex("dbo.ValveOperatorGeometricIndStds", new[] { "ValveOperatorGeometricIndPract_ID" });
            DropIndex("dbo.ReportingTypes", new[] { "ReportingRequirement_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "WeldingRequirement_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "Vendor_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "ValveOperatorType_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "ValveOperatorGeoIndStd_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "SupplyResponsibility_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "SubstCapScrewDiameterUnits_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "SecondSizeUnits_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "ReportingType_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "PartDataSource_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "MultiportValveOpReq_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "Manufacturer_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "LooseMaterialRequirements_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "GasketRequirements_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "FirstSizeUnits_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "FabricationType_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "ClampRequirement_ID" });
            DropIndex("dbo.PipingCommodityMatlControlDatas", new[] { "BoltingRequirements_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "ShortCodeHierarchyRule_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "SelectionBasis_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "SecondSizeUOMBasisInCatalog_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "SecondSizeUnits_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "PipingCommodityMatlControlData_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "OptionCode_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "MinimumTemperatureUnits_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "JacketedPipingBasis_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "FluidCode_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "FirstSizeUOMBasisInCatalog_ID" });
            DropIndex("dbo.PipingCommodityFilters", new[] { "FirstSizeUnits_ID" });
            DropIndex("dbo.PipeStocks", new[] { "WeightPerUnitLengthUnits_ID" });
            DropIndex("dbo.PipeStocks", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.PipeStocks", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.PipeStocks", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.PipeStocks", new[] { "PurchaseLengthUnits_ID" });
            DropIndex("dbo.PipeStocks", new[] { "PressureRating2_ID" });
            DropIndex("dbo.PipeStocks", new[] { "PressureRating1_ID" });
            DropIndex("dbo.PipeStocks", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.PipeStocks", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.PipeStocks", new[] { "MinimumPipeLengthUnits_ID" });
            DropIndex("dbo.PipeStocks", new[] { "MaximumPipeLengthUnits_ID" });
            DropIndex("dbo.PipeStocks", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.PipeStocks", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.PipeStocks", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.PipeStocks", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.PipeStocks", new[] { "EndStandard2_ID" });
            DropIndex("dbo.PipeStocks", new[] { "EndStandard1_ID" });
            DropIndex("dbo.PipeStocks", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.PipeStocks", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.PipeStocks", new[] { "DryWeightForEnd2Units_ID" });
            DropIndex("dbo.PipeStocks", new[] { "DryWeightForEnd1Units_ID" });
            DropIndex("dbo.PipeStocks", new[] { "DensityUnits_ID" });
            DropIndex("dbo.PipeNominalDiameters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.PipeNominalDiameters", new[] { "NpdUnitType_ID" });
            DropIndex("dbo.PipeBranches", new[] { "TertiaryShortCode_ID" });
            DropIndex("dbo.PipeBranches", new[] { "ShortCode_ID" });
            DropIndex("dbo.PipeBranches", new[] { "SecondaryShortCode_ID" });
            DropIndex("dbo.PipeBranches", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.PipeBranches", new[] { "HdrSizeNPDUnitType_ID" });
            DropIndex("dbo.PipeBranches", new[] { "BrSizeNPDUnitType_ID" });
            DropIndex("dbo.PipeBranches", new[] { "AngleLowUnitType_ID" });
            DropIndex("dbo.PipeBranches", new[] { "AngleHighUnitType_ID" });
            DropIndex("dbo.Paddles", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "ValveTrim_ID" });
            DropIndex("dbo.Paddles", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.Paddles", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.Paddles", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.Paddles", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.Paddles", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.Paddles", new[] { "PressureRating2_ID" });
            DropIndex("dbo.Paddles", new[] { "PressureRating1_ID" });
            DropIndex("dbo.Paddles", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.Paddles", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.Paddles", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.Paddles", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.Paddles", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Paddles", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.Paddles", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.Paddles", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.Paddles", new[] { "HandletoCenterUnitType_ID" });
            DropIndex("dbo.Paddles", new[] { "GeometryType_ID" });
            DropIndex("dbo.Paddles", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.Paddles", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.Paddles", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.Paddles", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.Paddles", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.Paddles", new[] { "EndStandard2_ID" });
            DropIndex("dbo.Paddles", new[] { "EndStandard1_ID" });
            DropIndex("dbo.Paddles", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.Paddles", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.Paddles", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Paddles", new[] { "CommodityType_ID" });
            DropIndex("dbo.Paddles", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "ValveSizeUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "ValveOperatorIsRotatable_ID" });
            DropIndex("dbo.Operator9", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Operator9", new[] { "HeightUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "HandleLengthUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Operator9", new[] { "DimensionalBasis_ID" });
            DropIndex("dbo.Operator5", new[] { "ValveSizeUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "ValveOperatorIsRotatable_ID" });
            DropIndex("dbo.Operator5", new[] { "OperatorHeightUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Operator5", new[] { "HandWheelDiameterUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Operator5", new[] { "DimensionalBasis_ID" });
            DropIndex("dbo.Operator351", new[] { "ValveSizeUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "ValveOperatorIsRotatable_ID" });
            DropIndex("dbo.Operator351", new[] { "OperatorHeightUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "OffsetFrmValCenUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Operator351", new[] { "HwZOffsetOpFrmStemUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "HwXOffsetFrmOpStemUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "HwOffsetFrmValCenUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "HWDiameterUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Operator351", new[] { "DimensionalBasis_ID" });
            DropIndex("dbo.Operator332", new[] { "ValveSizeUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "ValveOperatorIsRotatable_ID" });
            DropIndex("dbo.Operator332", new[] { "ValCenToHWTopUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "ValCenToHWCenUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Operator332", new[] { "HwZOffsetOpFrmStemUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "HwYOffsetFrmGearBotUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "HwXOffsetFrmOpStemUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "HWDiameterUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "HandWheelRadiusUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "GearRadiusUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "GearDiameterUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "GearDepthUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "ExStemLenUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "ExStemLenFrmValCenUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "ExStemDiaUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Operator332", new[] { "DimensionalBasis_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "SupplyResponsibilityOverride_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "SupplementaryNutOption_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "PressureRating_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "NutOption_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "FabricationCategoryOverride_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "BoltType_ID" });
            DropIndex("dbo.NutSelectionFilters", new[] { "BoltDiameterUnits_ID" });
            DropIndex("dbo.NutPartDatas", new[] { "NutType_ID" });
            DropIndex("dbo.NutPartDatas", new[] { "NutHeightUnits_ID" });
            DropIndex("dbo.NutPartDatas", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.NutPartDatas", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.MatingPorts", new[] { "EndPrep2_ID" });
            DropIndex("dbo.MatingPorts", new[] { "EndPrep1_ID" });
            DropIndex("dbo.Manufacturers", new[] { "ManufacturerIndustryPractice_ID" });
            DropIndex("dbo.GlobeValves", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ValveTrim_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.GlobeValves", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.GlobeValves", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "PressureRating2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "PressureRating1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.GlobeValves", new[] { "OffsetFrmValCenUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "MountingFlangeDiaUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.GlobeValves", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.GlobeValves", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.GlobeValves", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.GlobeValves", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.GlobeValves", new[] { "GeometryType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.GlobeValves", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.GlobeValves", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "FacetoCenterUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "Face2toCenterUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "Face1toCenterUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "EndStandard2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "EndStandard1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.GlobeValves", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.GlobeValves", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.GlobeValves", new[] { "DiameterUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "CommodityType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "BonnetFlangeDiaUnitType_ID" });
            DropIndex("dbo.GlobeValves", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "ValveTrim_ID" });
            DropIndex("dbo.GateValves", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.GateValves", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.GateValves", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.GateValves", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.GateValves", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.GateValves", new[] { "PressureRating2_ID" });
            DropIndex("dbo.GateValves", new[] { "PressureRating1_ID" });
            DropIndex("dbo.GateValves", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.GateValves", new[] { "OffsetFrmValCenUnitType_ID" });
            DropIndex("dbo.GateValves", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.GateValves", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.GateValves", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.GateValves", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.GateValves", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.GateValves", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.GateValves", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.GateValves", new[] { "GeometryType_ID" });
            DropIndex("dbo.GateValves", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.GateValves", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.GateValves", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.GateValves", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.GateValves", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.GateValves", new[] { "EndStandard2_ID" });
            DropIndex("dbo.GateValves", new[] { "EndStandard1_ID" });
            DropIndex("dbo.GateValves", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.GateValves", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.GateValves", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.GateValves", new[] { "DiameterUnitType_ID" });
            DropIndex("dbo.GateValves", new[] { "CommodityType_ID" });
            DropIndex("dbo.GateValves", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "SupplyResponsibilityOverride_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "ScheduleThickness_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "RingNumber_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "PressureRating_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "NpdUnitType_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "GasketOption_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "FluidCode_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "FabricationCategoryOverride_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "EndStandard_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "EndPreparation_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "AlternatePressureRating_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "AlternateEndStandard_ID" });
            DropIndex("dbo.GasketSelectionFilters", new[] { "AlternateEndPreparation_ID" });
            DropIndex("dbo.RingNumbers", new[] { "RingNumberPractice_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "TightnessCurveSlopeUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "ThicknessFor3DModelUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "RingNumber_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "ProcurementThicknessUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "NpdUnitType_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "MetallicElectroPlatedWasherThkUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "MaximumPressureUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "InsulatingWasherThicknessUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketType_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketOutsideDiameterUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketOutsideDiameterBasis_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketInsideDiameterUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketInsideDiameterBasis_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "GasketIndustryStandard_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "FlangePressureUnits_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "FlangeInsulationKitType_ID" });
            DropIndex("dbo.GasketPartDatas", new[] { "FlangeFacing_ID" });
            DropIndex("dbo.GasketTypes", new[] { "GasketCategory_ID" });
            DropIndex("dbo.FluidCodes", new[] { "FluidSystem_ID" });
            DropIndex("dbo.Elbows", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "ValveTrim_ID" });
            DropIndex("dbo.Elbows", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.Elbows", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.Elbows", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.Elbows", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.Elbows", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.Elbows", new[] { "PressureRating2_ID" });
            DropIndex("dbo.Elbows", new[] { "PressureRating1_ID" });
            DropIndex("dbo.Elbows", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.Elbows", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.Elbows", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.Elbows", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.Elbows", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Elbows", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.Elbows", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.Elbows", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.Elbows", new[] { "GeometryType_ID" });
            DropIndex("dbo.Elbows", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.Elbows", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.Elbows", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.Elbows", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.Elbows", new[] { "FacetoCenterUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "EndStandard2_ID" });
            DropIndex("dbo.Elbows", new[] { "EndStandard1_ID" });
            DropIndex("dbo.Elbows", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.Elbows", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.Elbows", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "CommodityType_ID" });
            DropIndex("dbo.Elbows", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.Elbows", new[] { "BendAngleUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ValveTrim_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "PressureRating2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "PressureRating1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "GeometryType_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "EndStandard2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "EndStandard1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "CommodityType_ID" });
            DropIndex("dbo.EccentricReducers", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.ShortCodeHierarchyTypes", new[] { "ShortCodeHierarchyClass_ID" });
            DropIndex("dbo.ShortCodeHierarchyRules", new[] { "ShortCodeHierarchyType_ID" });
            DropIndex("dbo.DefaultChangeOfDirectionPerSpecs", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.DefaultChangeOfDirectionPerSpecs", new[] { "FunctionalShortCode_ID" });
            DropIndex("dbo.DefaultChangeOfDirectionPerSpecs", new[] { "BendAngleToUnitType_ID" });
            DropIndex("dbo.DefaultChangeOfDirectionPerSpecs", new[] { "BendAngleFromUnitType_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ValveTrim_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "PressureRating2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "PressureRating1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "GeometryType_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "EndStandard2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "EndStandard1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "CommodityType_ID" });
            DropIndex("dbo.ConcentricReducers", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.CommodityOptions", new[] { "OptionCategory_ID" });
            DropIndex("dbo.CheckValves", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "ValveTrim_ID" });
            DropIndex("dbo.CheckValves", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.CheckValves", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.CheckValves", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.CheckValves", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.CheckValves", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.CheckValves", new[] { "PressureRating2_ID" });
            DropIndex("dbo.CheckValves", new[] { "PressureRating1_ID" });
            DropIndex("dbo.CheckValves", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.CheckValves", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.CheckValves", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.CheckValves", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.CheckValves", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.CheckValves", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.CheckValves", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.CheckValves", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.CheckValves", new[] { "HeightFrmValCenUnitType_ID" });
            DropIndex("dbo.CheckValves", new[] { "GeometryType_ID" });
            DropIndex("dbo.CheckValves", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.CheckValves", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.CheckValves", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.CheckValves", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.CheckValves", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.CheckValves", new[] { "EqualizerClearanceUnitType_ID" });
            DropIndex("dbo.CheckValves", new[] { "EndStandard2_ID" });
            DropIndex("dbo.CheckValves", new[] { "EndStandard1_ID" });
            DropIndex("dbo.CheckValves", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.CheckValves", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.CheckValves", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.CheckValves", new[] { "DiameterUnitType_ID" });
            DropIndex("dbo.CheckValves", new[] { "CommodityType_ID" });
            DropIndex("dbo.CheckValves", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.Caps", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.Caps", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.Caps", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.Caps", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.Caps", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.Caps", new[] { "ValveTrim_ID" });
            DropIndex("dbo.Caps", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.Caps", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.Caps", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.Caps", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.Caps", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.Caps", new[] { "PressureRating1_ID" });
            DropIndex("dbo.Caps", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.Caps", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.Caps", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.Caps", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.Caps", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.Caps", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.Caps", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.Caps", new[] { "GeometryType_ID" });
            DropIndex("dbo.Caps", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.Caps", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.Caps", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.Caps", new[] { "FacetoEndUnits_ID" });
            DropIndex("dbo.Caps", new[] { "EndStandard1_ID" });
            DropIndex("dbo.Caps", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.Caps", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.Caps", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.Caps", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.Caps", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.Caps", new[] { "CommodityType_ID" });
            DropIndex("dbo.Caps", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "WidthUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "PressureRating2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "PressureRating1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "OffsetFrmValCenUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "OffsetFrmValBotmUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "GeometryType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "Face2toCenterUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "EndStandard2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "EndStandard1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "CUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "CommodityType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "BUnitType_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.ButterflyValves", new[] { "AUnitType_ID" });
            DropIndex("dbo.FabricationTypes", new[] { "FabricationRequirement_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "SupplyResponsibilityOverride_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "PressureRating_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "NpdUnitType_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "MaximumTemperatureUnits_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "LubricationRequirements_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "FabricationCategoryOverride_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "EndStandard_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "EndPreparation_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "BoltOption_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "BoltExtensionOption_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "AlternateEndStandard_ID" });
            DropIndex("dbo.BoltSelectionFilters", new[] { "AlternateEndPreparation_ID" });
            DropIndex("dbo.CoatingTypes", new[] { "CoatingRequirement_ID" });
            DropIndex("dbo.BoltPartDatas", new[] { "MaterialsGrade_ID" });
            DropIndex("dbo.BoltPartDatas", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.BoltPartDatas", new[] { "CoatingType_ID" });
            DropIndex("dbo.BoltPartDatas", new[] { "BoltType_ID" });
            DropIndex("dbo.EndStandards", new[] { "EndPractice_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "StandardBoltExtForMachBoltsUnits_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "StandardBoltExtensionForStudsUnits_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "PressureRating_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "NominalPipingDiameterUnits_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "EndStandard_ID" });
            DropIndex("dbo.BoltExtensions", new[] { "EndPreparation_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "ValveTrim_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "PressureRating1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "GeometryType_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "EndStandard1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "CommodityType_ID" });
            DropIndex("dbo.BlindFlanges", new[] { "BendRadiusUnits_ID" });
            DropIndex("dbo.StressReliefs", new[] { "StressReliefPractice_ID" });
            DropIndex("dbo.MaterialsTypes", new[] { "MaterialsGroup_ID" });
            DropIndex("dbo.Examinations", new[] { "ExaminationPractice_ID" });
            DropIndex("dbo.DesignStandards", new[] { "DesignStandardPractice_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "WasherCreationOption_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "StressReliefRequirement_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "StressRelief_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "PipingCommodityOverrideOption_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "MaterialsType_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "MaterialsOfConstructionClass_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "MaterialsGroup_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "GasketRequirementOverride_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "Examination_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "DesignStandard_ID" });
            DropIndex("dbo.PipingMaterialsClassDatas", new[] { "AutomatedFlangeSelectionOption_ID" });
            DropIndex("dbo.BendAngles", new[] { "PipingMaterialsClassData_ID" });
            DropIndex("dbo.BendAngles", new[] { "NpdUnitType_ID" });
            DropIndex("dbo.BendAngles", new[] { "BendAngleUnitType_ID" });
            DropIndex("dbo.ValveTrims", new[] { "ValveTrimPractice_ID" });
            DropIndex("dbo.ValveModelNumbers", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.ValveManufacturers", new[] { "ValveManufacturerIndPractice_ID" });
            DropIndex("dbo.ScheduleThicknesses", new[] { "ScheduleThicknessPractice_ID" });
            DropIndex("dbo.PressureRatings", new[] { "RatingPractice_ID" });
            DropIndex("dbo.MiscRequisitionClassifications", new[] { "MiscRequisitionComponentType_ID" });
            DropIndex("dbo.MaterialsCategories", new[] { "MaterialsGradePractice_ID" });
            DropIndex("dbo.MaterialsGrades", new[] { "MaterialsCategory_ID" });
            DropIndex("dbo.LiningMaterials", new[] { "LiningRequirements_ID" });
            DropIndex("dbo.GeometricIndustryStandards", new[] { "GeometricIndustryPractice_ID" });
            DropIndex("dbo.TerminationSubClasses", new[] { "TerminationClass_ID" });
            DropIndex("dbo.EndPreparations", new[] { "TerminationSubClass_ID" });
            DropIndex("dbo.PipingCommoditySubClasses", new[] { "PipingCommodityClass_ID" });
            DropIndex("dbo.PipingCommodityTypes", new[] { "PipingCommoditySubClass_ID" });
            DropIndex("dbo.UnitTypes", new[] { "UnitClass_ID" });
            DropIndex("dbo.BallValves", new[] { "WidthUnitType_ID" });
            DropIndex("dbo.BallValves", new[] { "WaterWeightUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "WaterCogZUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "WaterCogYUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "WaterCogXUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "VolumetricCapacityUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "ValveTrim_ID" });
            DropIndex("dbo.BallValves", new[] { "ValveModelNumber_ID" });
            DropIndex("dbo.BallValves", new[] { "ValveManufacturer_ID" });
            DropIndex("dbo.BallValves", new[] { "SurfacePreparation_ID" });
            DropIndex("dbo.BallValves", new[] { "SurfaceAreaUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "ScheduleThickness2_ID" });
            DropIndex("dbo.BallValves", new[] { "ScheduleThickness1_ID" });
            DropIndex("dbo.BallValves", new[] { "PressureRating2_ID" });
            DropIndex("dbo.BallValves", new[] { "PressureRating1_ID" });
            DropIndex("dbo.BallValves", new[] { "PartDataBasis_ID" });
            DropIndex("dbo.BallValves", new[] { "OffsetFrmValCenUnitType_ID" });
            DropIndex("dbo.BallValves", new[] { "NpdUnitType2_ID" });
            DropIndex("dbo.BallValves", new[] { "NpdUnitType1_ID" });
            DropIndex("dbo.BallValves", new[] { "MiscRequisitionClassification_ID" });
            DropIndex("dbo.BallValves", new[] { "MirrorBehaviorOption_ID" });
            DropIndex("dbo.BallValves", new[] { "MaterialGrade_ID" });
            DropIndex("dbo.BallValves", new[] { "ManufacturingMethod_ID" });
            DropIndex("dbo.BallValves", new[] { "LiningMaterial_ID" });
            DropIndex("dbo.BallValves", new[] { "HeightUnitType_ID" });
            DropIndex("dbo.BallValves", new[] { "GeometryType_ID" });
            DropIndex("dbo.BallValves", new[] { "GeometricIndustryStandard_ID" });
            DropIndex("dbo.BallValves", new[] { "FlowDirection2_ID" });
            DropIndex("dbo.BallValves", new[] { "FlowDirection1_ID" });
            DropIndex("dbo.BallValves", new[] { "FlangeFaceSurfaceFinish_ID" });
            DropIndex("dbo.BallValves", new[] { "FacetoFaceUnitType_ID" });
            DropIndex("dbo.BallValves", new[] { "Face1toCenterUnitType_ID" });
            DropIndex("dbo.BallValves", new[] { "EndStandard2_ID" });
            DropIndex("dbo.BallValves", new[] { "EndStandard1_ID" });
            DropIndex("dbo.BallValves", new[] { "EndPreparation2_ID" });
            DropIndex("dbo.BallValves", new[] { "EndPreparation1_ID" });
            DropIndex("dbo.BallValves", new[] { "DryWeightUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "DryCogZUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "DryCogYUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "DryCogXUnits_ID" });
            DropIndex("dbo.BallValves", new[] { "CommodityType_ID" });
            DropIndex("dbo.BallValves", new[] { "BendRadiusUnits_ID" });
            DropTable("dbo.WeldNeckFlanges");
            DropTable("dbo.WeldModelRepresentations");
            DropTable("dbo.WeldTypes");
            DropTable("dbo.WeldClasses");
            DropTable("dbo.WasherSelectionFilters");
            DropTable("dbo.WasherTypes");
            DropTable("dbo.WasherPartDatas");
            DropTable("dbo.WasherOptions");
            DropTable("dbo.Thredolets");
            DropTable("dbo.SupplementaryWasherRequirements");
            DropTable("dbo.SpectacleBlinds");
            DropTable("dbo.ReducingTees");
            DropTable("dbo.PreferredStudBoltLengths");
            DropTable("dbo.PlainPipingGenericDatas");
            DropTable("dbo.PipingGenericDataBolteds");
            DropTable("dbo.SelectionBasis");
            DropTable("dbo.WeldingRequirements");
            DropTable("dbo.Vendors");
            DropTable("dbo.ValveOperatorClasses");
            DropTable("dbo.ValveOperatorTypes");
            DropTable("dbo.ValveOperatorGeometricIndPracts");
            DropTable("dbo.ValveOperatorGeometricIndStds");
            DropTable("dbo.UnitClasses");
            DropTable("dbo.ReportingRequirements");
            DropTable("dbo.ReportingTypes");
            DropTable("dbo.PipingCommodityMatlControlDatas");
            DropTable("dbo.PipingCommodityFilters");
            DropTable("dbo.PipeStocks");
            DropTable("dbo.PipeNominalDiameters");
            DropTable("dbo.PipeBranches");
            DropTable("dbo.PartDataSources");
            DropTable("dbo.Paddles");
            DropTable("dbo.Operator9");
            DropTable("dbo.Operator5");
            DropTable("dbo.Operator351");
            DropTable("dbo.ValveOperatorIsRotatables");
            DropTable("dbo.Operator332");
            DropTable("dbo.SupplementaryNutRequirements");
            DropTable("dbo.NutSelectionFilters");
            DropTable("dbo.NutTypes");
            DropTable("dbo.NutPartDatas");
            DropTable("dbo.NutOptions");
            DropTable("dbo.MultiportValveOpReqs");
            DropTable("dbo.MatingPorts");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.ManufacturerIndustryPractices");
            DropTable("dbo.LooseMaterialRequirements");
            DropTable("dbo.JacketedPipingBasis");
            DropTable("dbo.GlobeValves");
            DropTable("dbo.GateValves");
            DropTable("dbo.GasketSelectionFilters");
            DropTable("dbo.GasketRequirements");
            DropTable("dbo.RingNumberPractices");
            DropTable("dbo.RingNumbers");
            DropTable("dbo.GasketPartDatas");
            DropTable("dbo.GasketOutsideDiameterBasis");
            DropTable("dbo.GasketOptions");
            DropTable("dbo.GasketInsideDiameterBasis");
            DropTable("dbo.GasketTypes");
            DropTable("dbo.GasketCategories");
            DropTable("dbo.FluidSystems");
            DropTable("dbo.FluidCodes");
            DropTable("dbo.FlangeInsulationKitTypes");
            DropTable("dbo.FlangeFacings");
            DropTable("dbo.Elbows");
            DropTable("dbo.EccentricReducers");
            DropTable("dbo.DrillingTemplatePatterns");
            DropTable("dbo.ShortCodeHierarchyClasses");
            DropTable("dbo.ShortCodeHierarchyTypes");
            DropTable("dbo.ShortCodeHierarchyRules");
            DropTable("dbo.DefaultChangeOfDirectionPerSpecs");
            DropTable("dbo.ConcentricReducers");
            DropTable("dbo.OptionCategories");
            DropTable("dbo.CommodityOptions");
            DropTable("dbo.ClampRequirements");
            DropTable("dbo.CheckValves");
            DropTable("dbo.Caps");
            DropTable("dbo.ButterflyValves");
            DropTable("dbo.SupplyResponsibilities");
            DropTable("dbo.FabricationRequirements");
            DropTable("dbo.FabricationTypes");
            DropTable("dbo.BoltSelectionFilters");
            DropTable("dbo.CoatingRequirements");
            DropTable("dbo.CoatingTypes");
            DropTable("dbo.BoltTypes");
            DropTable("dbo.BoltPartDatas");
            DropTable("dbo.BoltOptions");
            DropTable("dbo.BoltLubricationRequirements");
            DropTable("dbo.BoltingRequirements");
            DropTable("dbo.EndPractices");
            DropTable("dbo.EndStandards");
            DropTable("dbo.BoltExtensions");
            DropTable("dbo.BoltExtensionOptions");
            DropTable("dbo.BlindFlanges");
            DropTable("dbo.WasherCreationOptions");
            DropTable("dbo.StressReliefRequirements");
            DropTable("dbo.StressReliefPractices");
            DropTable("dbo.StressReliefs");
            DropTable("dbo.PipingCommodityOverrideOptions");
            DropTable("dbo.MaterialsOfConstructionClasses");
            DropTable("dbo.MaterialsTypes");
            DropTable("dbo.MaterialsGroups");
            DropTable("dbo.GasketRequirementOverrides");
            DropTable("dbo.ExaminationPractices");
            DropTable("dbo.Examinations");
            DropTable("dbo.DesignStandardPractices");
            DropTable("dbo.DesignStandards");
            DropTable("dbo.PipingMaterialsClassDatas");
            DropTable("dbo.BendAngles");
            DropTable("dbo.ValveTrimPractices");
            DropTable("dbo.ValveTrims");
            DropTable("dbo.ValveModelNumbers");
            DropTable("dbo.ValveManufacturerIndPractices");
            DropTable("dbo.ValveManufacturers");
            DropTable("dbo.SurfacePreparations");
            DropTable("dbo.ScheduleThicknessPractices");
            DropTable("dbo.ScheduleThicknesses");
            DropTable("dbo.RatingPractices");
            DropTable("dbo.PressureRatings");
            DropTable("dbo.PartDataBasis");
            DropTable("dbo.MiscRequisitionComponentTypes");
            DropTable("dbo.MiscRequisitionClassifications");
            DropTable("dbo.MirrorBehaviorOptions");
            DropTable("dbo.MaterialsGradePractices");
            DropTable("dbo.MaterialsCategories");
            DropTable("dbo.MaterialsGrades");
            DropTable("dbo.ManufacturingMethods");
            DropTable("dbo.LiningRequirements");
            DropTable("dbo.LiningMaterials");
            DropTable("dbo.GeometryTypes");
            DropTable("dbo.GeometricIndustryPractices");
            DropTable("dbo.GeometricIndustryStandards");
            DropTable("dbo.FlowDirections");
            DropTable("dbo.FlangeFaceSurfaceFinishes");
            DropTable("dbo.TerminationClasses");
            DropTable("dbo.TerminationSubClasses");
            DropTable("dbo.EndPreparations");
            DropTable("dbo.PipingCommodityClasses");
            DropTable("dbo.PipingCommoditySubClasses");
            DropTable("dbo.PipingCommodityTypes");
            DropTable("dbo.UnitTypes");
            DropTable("dbo.BallValves");
            DropTable("dbo.AutomatedFlangeSelectionOptions");
        }
    }
}
