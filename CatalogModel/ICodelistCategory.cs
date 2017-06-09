using System.Collections.Generic;

namespace CatalogModel
{
	public interface ICodelistCategory
	{
		List<ICodelist> Childs { get; }
		void AddChild(ICodelist child);
	}
}
