using System.ComponentModel.DataAnnotations;
using CatalogModel.Codelists;
using System;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Название и описание класса
	/// </summary>
	public class PipingMaterialsClassData
	{
		[Display(Order = -1)]
		public int ID { get; set; }

		[Display(Order = 0)]
		public string SpecName { get; set; }

		[Display(Order = 1)]
		public virtual MaterialsOfConstructionClass MaterialsOfConstructionClass { get; set; }

		[Display(Order = 2)]
		public string MaterialsDescription { get; set; }

		[Display(Order = 3)]
		public string FluidService { get; set; }

		[Display(Order = 4)]
		public virtual DesignStandard DesignStandard { get; set; }

		[Display(Order = 5)]
		public virtual AutomatedFlangeSelectionOption AutomatedFlangeSelectionOption { get; set; }

		[Display(Order = 6)]
		public virtual PipingCommodityOverrideOption PipingCommodityOverrideOption { get; set; }

		[Display(Order = 7)]
		public virtual WasherCreationOption WasherCreationOption { get; set; }

		[Display(Order = 8)]
		public virtual LiningMaterial LiningMaterial { get; set; }

		[Display(Order = 9)]
		public string Comments { get; set; }

		[Display(Order = 10)]
		public string RevisionNumber { get; set; }

		[Display(Order = 11)]
		public string ApprovedBy { get; set; }

		[Display(Order = 12)]
		public DateTime? ApprovalDate { get; set; }

		[Display(Order = 13)]
		public string JacketMatOfConstructionClass { get; set; }

		[Display(Order = 14)]
		public string JumperMatOfConstructionClass { get; set; }

		[Display(Order = 15)]
		public string JacketMaterialsDescription { get; set; }

		[Display(Order = 16)]
		public string JumperMaterialsDescription { get; set; }

		[Display(Order = 17)]
		public string JacketAndJumperFluidService { get; set; }

		[Display(Order = 18)]
		public virtual StressRelief StressRelief { get; set; }

		[Display(Order = 19)]
		public virtual Examination Examination { get; set; }

		[Display(Order = 20)]
		public string HyperlinkToHumanSpec { get; set; }

		[Display(Order = 21)]
		public string PipingNote1 { get; set; }

		[Display(Order = 22)]
		public virtual GasketRequirementOverride GasketRequirementOverride { get; set; }

		[Display(Order = 23)]
		public virtual StressReliefRequirement StressReliefRequirement { get; set; }

		[Display(Order = 24)]
		public virtual MaterialsGroup MaterialsGroup { get; set; }

		[Display(Order = 25)]
		public string WeldingProcedureSpecification { get; set; }

		[Display(Order = 26)]
		public virtual MaterialsType MaterialsType { get; set; }
	}
}
