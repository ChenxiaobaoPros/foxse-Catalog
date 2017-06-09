using CatalogModel.Codelists;
using System;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Название и описание класса
	/// </summary>
	public class PipingMaterialsClassData
	{
		public int ID { get; set; }

		public string SpecName { get; set; }

		public virtual MaterialsOfConstructionClass MaterialsOfConstructionClass { get; set; }

		public string MaterialsDescription { get; set; }

		public string FluidService { get; set; }
		public virtual DesignStandard DesignStandard { get; set; }
		public virtual AutomatedFlangeSelectionOption AutomatedFlangeSelectionOption { get; set; }
		public virtual PipingCommodityOverrideOption PipingCommodityOverrideOption { get; set; }
		public virtual WasherCreationOption WasherCreationOption { get; set; }
		public virtual LiningMaterial LiningMaterial { get; set; }
		public string Comments { get; set; }
		public string RevisionNumber { get; set; }
		public string ApprovedBy { get; set; }
		public DateTime? ApprovalDate { get; set; }
		public string JacketMatOfConstructionClass { get; set; }
		public string JumperMatOfConstructionClass { get; set; }
		public string JacketMaterialsDescription { get; set; }
		public string JumperMaterialsDescription { get; set; }
		public string JacketAndJumperFluidService { get; set; }
		public virtual StressRelief StressRelief { get; set; }
		public virtual Examination Examination { get; set; }
		public string HyperlinkToHumanSpec { get; set; }
		public string PipingNote1 { get; set; }
		public virtual GasketRequirementOverride GasketRequirementOverride { get; set; }
		public virtual StressReliefRequirement StressReliefRequirement { get; set; }
		public virtual MaterialsGroup MaterialsGroup { get; set; }
		public string WeldingProcedureSpecification { get; set; }
		public virtual MaterialsType MaterialsType { get; set; }
	}
}
