using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manager.Models
{
	public class PipingMaterialsClassDataViewModel
	{
		public int ID { get; set; }
		public string SpecName { get; set; }
		public int? MaterialsOfConstructionClass { get; set; }
		public string MaterialsDescription { get; set; }
		public string FluidService { get; set; }
		public int? DesignStandard { get; set; }
		public int? AutomatedFlangeSelectionOption { get; set; }
		public int? PipingCommodityOverrideOption { get; set; }
		public int? WasherCreationOption { get; set; }
		public int? LiningMaterial { get; set; }
		public string Comments { get; set; }
		public string RevisionNumber { get; set; }
		public string ApprovedBy { get; set; }
		public DateTime? ApprovalDate { get; set; }
		public string JacketMatOfConstructionClass { get; set; }
		public string JumperMatOfConstructionClass { get; set; }
		public string JacketMaterialsDescription { get; set; }
		public string JumperMaterialsDescription { get; set; }
		public string JacketAndJumperFluidService { get; set; }
		public int? StressRelief { get; set; }
		public int? Examination { get; set; }
		public string HyperlinkToHumanSpec { get; set; }
		public string PipingNote1 { get; set; }
		public int? GasketRequirementOverride { get; set; }
		public int? StressReliefRequirement { get; set; }
		public int? MaterialsGroup { get; set; }
		public string WeldingProcedureSpecification { get; set; }
		public int? MaterialsType { get; set; }
	}
}