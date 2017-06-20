using CatalogModel.Catalog.BoltedJoint;
using CatalogModel.Catalog.Commodity;
using CatalogModel.Catalog.GenericData;
using CatalogModel.Catalog.PartClasses;
using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Bolts;
using CatalogModel.MaterialClass.Piping;
using CatalogModel.Specification;
using System.Data.Entity;

namespace CatalogModel
{
	public class CatalogContext : DbContext
	{
	//	public CatalogContext() : base("name=VNPSourceCatalogData")
		public CatalogContext() : base("name=FOXSourceCatalogData")
        {
		}

		#region Catalog
		#region BoltedJoint
		public DbSet<BoltPartData> BoltPartData { get; set; }
		public DbSet<GasketPartData> GasketPartData { get; set; }
		public DbSet<NutPartData> NutPartData { get; set; }
		public DbSet<WasherPartData> WasherPartData { get; set; }
		#endregion
		#region Commodity
		public DbSet<PipeStock> PipeStock { get; set; }
		#endregion
		#region GenericData
		public DbSet<PipingGenericDataBolted> PipingGenericDataBolted { get; set; }
		public DbSet<PlainPipingGenericData> PlainPipingGenericData { get; set; }
		#endregion
		#region PartClasses
		public DbSet<BallValve> BallValves { get; set; }
		public DbSet<BlindFlange> BlindFlanges { get; set; }
		public DbSet<ButterflyValve> ButterflyValves { get; set; }
		public DbSet<Cap> Caps { get; set; }
		public DbSet<CheckValve> CheckValves { get; set; }
		public DbSet<ConcentricReducer> ConcentricReducers { get; set; }
		public DbSet<EccentricReducer> EccentricReducers { get; set; }
		public DbSet<Elbow> Elbows { get; set; }
		public DbSet<GateValve> GateValves { get; set; }
		public DbSet<GlobeValve> GlobeValves { get; set; }
		public DbSet<Operator332> Operators332 { get; set; }
		public DbSet<Operator351> Operators351 { get; set; }
		public DbSet<Operator5> Operators5 { get; set; }
		public DbSet<Operator9> Operators9 { get; set; }
		public DbSet<Paddle> Paddles { get; set; }
		public DbSet<ReducingTee> ReducingTees { get; set; }
		public DbSet<SpectacleBlind> SpectacleBlinds { get; set; }
		public DbSet<Thredolet> Thredolets { get; set; }
		public DbSet<WeldNeckFlange> WeldNeckFlanges { get; set; }
		#endregion
		#endregion

		#region Codelists
		public DbSet<AutomatedFlangeSelectionOption> AutomatedFlangeSelectionOptions { get; set; }
		public DbSet<BoltExtensionOption> BoltExtensionOptions { get; set; }
		public DbSet<BoltingRequirements> BoltingRequirements { get; set; }
		public DbSet<BoltLubricationRequirements> BoltLubricationRequirements { get; set; }
		public DbSet<BoltOption> BoltOptions { get; set; }
		public DbSet<BoltType> BoltTypes { get; set; }
		public DbSet<ClampRequirement> ClampRequirements { get; set; }
		public DbSet<CoatingType> CoatingTypes { get; set; }
		public DbSet<CoatingRequirement> CoatingRequirements { get; set; }
		public DbSet<CommodityOption> CommodityOptions { get; set; }
		public DbSet<OptionCategory> OptionCategories { get; set; }
		public DbSet<DesignStandard> DesignStandards { get; set; }
		public DbSet<DesignStandardPractice> DesignStandardPractices { get; set; }
		public DbSet<DrillingTemplatePattern> DrillingTemplatePatterns { get; set; }
		public DbSet<EndPreparation> EndPreparations { get; set; }
		public DbSet<TerminationClass> TerminationClasses { get; set; }
		public DbSet<TerminationSubClass> TerminationSubClasses { get; set; }
		public DbSet<EndStandard> EndStandards { get; set; }
		public DbSet<EndPractice> EndPractices { get; set; }
		public DbSet<Examination> Examinations { get; set; }
		public DbSet<ExaminationPractice> ExaminationPractices { get; set; }
		public DbSet<FabricationType> FabricationTypes { get; set; }
		public DbSet<FabricationRequirement> FabricationRequirements { get; set; }
		public DbSet<FlangeFaceSurfaceFinish> FlangeFaceSurfaceFinish { get; set; }
		public DbSet<FlangeFacing> FlangeFacings { get; set; }
		public DbSet<FlangeInsulationKitType> FlangeInsulationKitTypes { get; set; }
		public DbSet<FlowDirection> FlowDirections { get; set; }
		public DbSet<FluidCode> FluidCodes { get; set; }
		public DbSet<FluidSystem> FluidSystems { get; set; }
		public DbSet<GasketInsideDiameterBasis> GasketInsideDiameterBasis { get; set; }
		public DbSet<GasketOption> GasketOptions { get; set; }
		public DbSet<GasketOutsideDiameterBasis> GasketOutsideDiameterBasis { get; set; }
		public DbSet<GasketRequirementOverride> GasketRequirementOverride { get; set; }
		public DbSet<GasketRequirements> GasketRequirements { get; set; }
		public DbSet<GasketType> GasketTypes { get; set; }
		public DbSet<GasketCategory> GasketCategories { get; set; }
		public DbSet<GeometricIndustryStandard> GeometricIndustryStandards { get; set; }
		public DbSet<GeometricIndustryPractice> GeometricIndustryPractices { get; set; }
		public DbSet<GeometryType> GeometryTypes { get; set; }
		public DbSet<JacketedPipingBasis> JacketedPipingBasis { get; set; }
		public DbSet<LiningMaterial> LiningMaterials { get; set; }
		public DbSet<LiningRequirements> LiningRequirements { get; set; }
		public DbSet<LooseMaterialRequirements> LooseMaterialRequirements { get; set; }
		public DbSet<Manufacturer> Manufacturers { get; set; }//
		public DbSet<ManufacturerIndustryPractice> ManufacturerIndustryPractices { get; set; }
		public DbSet<ManufacturingMethod> ManufacturingMethods { get; set; }
		public DbSet<MaterialsGrade> MaterialsGrades { get; set; }
		public DbSet<MaterialsCategory> MaterialsCategories { get; set; }
		public DbSet<MaterialsGradePractice> MaterialsGradePractices { get; set; }
		public DbSet<MaterialsOfConstructionClass> MaterialsOfConstructionClasses { get; set; }
		public DbSet<MaterialsType> MaterialsTypes { get; set; }
		public DbSet<MaterialsGroup> MaterialsGroups { get; set; }
		public DbSet<MiscRequisitionClassification> MiscRequisitionClassifications { get; set; }
		public DbSet<MiscRequisitionComponentType> MiscRequisitionComponentTypes { get; set; }
		public DbSet<MultiportValveOpReq> MultiportValveOpReqs { get; set; }
		public DbSet<NutOption> NutOptions { get; set; }
		public DbSet<NutType> NutTypes { get; set; }
		public DbSet<PartDataBasis> PartDataBasis { get; set; }
		public DbSet<PartDataSource> PartDataSources { get; set; }
		public DbSet<PipingCommodityOverrideOption> PipingCommodityOverrideOptions { get; set; }
		public DbSet<PipingCommodityType> PipingCommodityTypes { get; set; }
		public DbSet<PipingCommoditySubClass> PipingCommoditySubClasses { get; set; }
		public DbSet<PipingCommodityClass> PipingCommodityClasses { get; set; }
		public DbSet<PressureRating> PressureRatings { get; set; }
		public DbSet<RatingPractice> RatingPractices { get; set; }
		public DbSet<ReportingType> ReportingTypes { get; set; }
		public DbSet<ReportingRequirement> ReportingRequirements { get; set; }
		public DbSet<RingNumber> RingNumbers { get; set; }
		public DbSet<RingNumberPractice> RingNumberPractices { get; set; }
		public DbSet<ScheduleThickness> ScheduleThickness { get; set; }
		public DbSet<ScheduleThicknessPractice> ScheduleThicknessPractices { get; set; }
		public DbSet<SelectionBasis> SelectionBasis { get; set; }
		public DbSet<ShortCodeHierarchyType> ShortCodeHierarchyTypes { get; set; }
		public DbSet<ShortCodeHierarchyClass> ShortCodeHierarchyClasses { get; set; }
		public DbSet<StressRelief> StressRelief { get; set; }
		public DbSet<StressReliefPractice> StressReliefPractices { get; set; }
		public DbSet<StressReliefRequirement> StressReliefRequirements { get; set; }
		public DbSet<SupplementaryNutRequirement> SupplementaryNutRequirements { get; set; }
		public DbSet<SupplementaryWasherRequirement> SupplementaryWasherRequirements { get; set; }
		public DbSet<SupplyResponsibility> SupplyResponsibility { get; set; }
		public DbSet<SurfacePreparation> SurfacePreparations { get; set; }
		public DbSet<ValveModelNumber> ValveModelNumbers { get; set; }
		public DbSet<ValveManufacturer> ValveManufacturers { get; set; }
		public DbSet<ValveManufacturerIndPractice> ValveManufacturerIndPractices { get; set; }
		public DbSet<ValveOperatorGeometricIndStd> ValveOperatorGeometricIndStd { get; set; }
		public DbSet<ValveOperatorGeometricIndPract> ValveOperatorGeometricIndPract { get; set; }
		public DbSet<ValveOperatorIsRotatable> ValveOperatorIsRotatable { get; set; }
		public DbSet<ValveOperatorType> ValveOperatorTypes { get; set; }
		public DbSet<ValveOperatorClass> ValveOperatorClasses { get; set; }
		public DbSet<ValveTrim> ValveTrim { get; set; }
		public DbSet<ValveTrimPractice> ValveTrimPractices { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<WasherCreationOption> WasherCreationOptions { get; set; }
		public DbSet<WasherOption> WasherOptions { get; set; }
		public DbSet<WasherType> WasherTypes { get; set; }
		public DbSet<WeldingRequirement> WeldingRequirements { get; set; }
		public DbSet<WeldType> WeldTypes { get; set; }
		public DbSet<WeldClass> WeldClasses { get; set; }
		#endregion

		#region MaterialClass
		#region Bolts		
		public DbSet<BoltSelectionFilter> BoltSelectionFilters { get; set; }
		public DbSet<GasketSelectionFilter> GasketSelectionFilters { get; set; }
		public DbSet<NutSelectionFilter> NutSelectionFilters { get; set; }
		public DbSet<WasherSelectionFilter> WasherSelectionFilters { get; set; }
		#endregion
		#region Piping
		public DbSet<BendAngles> BendAngles { get; set; }
		public DbSet<DefaultChangeOfDirectionPerSpec> DefaultChangeOfDirectionPerSpec { get; set; }
		public DbSet<PipeBranch> PipeBranches { get; set; }
		public DbSet<PipeNominalDiameters> PipeNominalDiameters { get; set; }
		public DbSet<PipingCommodityFilter> PipingCommodityFilters { get; set; }
		public DbSet<PipingMaterialsClassData> PipingMaterialsClassData { get; set; }
		#endregion
		#endregion

		#region Specification
		public DbSet<BoltExtension> BoltExtensions { get; set; }
		public DbSet<MatingPorts> MatingPorts { get; set; }
		public DbSet<PipingCommodityMatlControlData> PipingCommodityMatlControlData { get; set; }
		public DbSet<PreferredStudBoltLength> PreferredStudBoltLengths { get; set; }
		public DbSet<ShortCodeHierarchyRule> ShortCodeHierarchyRules { get; set; }
		public DbSet<WeldModelRepresentation> WeldModelRepresentations { get; set; }
		#endregion
	}
}
