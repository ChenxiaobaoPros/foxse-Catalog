using CatalogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestApp
{
	class Program
	{
		private static Dictionary<string, Type> _allTypes;
		private static ICodelist _lvl1parent = null;
		private static ICodelist _lvl2parent = null;

		private static void SaveEnts(string file)
		{
			var toficc = typeof(ICodelistCategory);

			var excelApp = new Excel.Application();
			excelApp.Visible = false;
			excelApp.DisplayAlerts = false;
			//excelApp.Workbooks.Open((file == null)? @"D:\All_Work\Intergraph\VNP\Catalog\Templates\test.xlsx" : file);
			excelApp.Workbooks.Open((file == null) ? @"D:\All_Work\Intergraph\VNP\Catalog\Templates\VNIPINEFT_AllCodeLists.xlsx" : file);
			//			XlsDocument xls = new XlsDocument(@"D:\All_Work\Intergraph\VNP\Catalog\Templates\VNIPINEFT_AllCodeLists.xlsx");


			//foreach (var kvp in allTypes)
			{
				//	if (!kvp.Value.GetInterfaces().Contains(toficc))
				{
					//					var matSheet = xls.Workbook.Worksheets[kvp.Key];
					foreach (Excel.Worksheet worksheet in excelApp.Sheets)
					{
						if (_allTypes.ContainsKey(worksheet.Name))
						{
							Excel.Range usedRange = worksheet.UsedRange;

							_lvl1parent = null;
							_lvl2parent = null;

							List<Type> allclTypes = new List<Type>();
							List<ICodelist> addItems = new List<ICodelist>();

							Console.WriteLine($"\n\n {worksheet.Name}");
							int clNumColIndx = 0;
							//using (CatalogContext db = new CatalogContext())
							//{
							bool started = false;
							foreach (Excel.Range row in usedRange.Rows)
							{

								//int curTypeIndx = 0;


								if (started)
								{
									string res = (row.Cells[1, 1].Value2 != null) ? row.Cells[1, 1].Value2.ToString().ToUpper() : "";
									if (res == "END")
									{
										started = false;
										break;
									}
									else if (res == "!")
									{
										continue;
									}

									String[] rowData = new String[row.Columns.Count];
									if (row.Cells[1, 2].Value2 != null)
									{
										var tt = (ICodelist)Activator.CreateInstance(allclTypes[0]);

										tt.ShortDescription = (row.Cells[1, 2].Value2 == null) ? row.Cells[1, 2].Value2 : row.Cells[1, 2].Value2.ToString();
										tt.LongDescription = (row.Cells[1, 3].Value2 == null) ? row.Cells[1, 3].Value2 : row.Cells[1, 3].Value2.ToString();
										tt.CodelistNumber = int.Parse(row.Cells[1, clNumColIndx].Value2.ToString());
										tt.SortOrder = (int?)row.Cells[1, clNumColIndx + 1].Value2;
										SaveEnts(ref tt, allclTypes[0]);
										_lvl1parent = tt;
									}
									else if (clNumColIndx > 3 && row.Cells[1, 4].Value2 != null)
									{
										var tt = (ICodelist)Activator.CreateInstance(allclTypes[1]);

										tt.ShortDescription = (row.Cells[1, 4].Value2 == null) ? row.Cells[1, 4].Value2 : row.Cells[1, 4].Value2.ToString();
										tt.LongDescription = (row.Cells[1, 5].Value2 == null) ? row.Cells[1, 5].Value2 : row.Cells[1, 5].Value2.ToString();
										tt.CodelistNumber = int.Parse(row.Cells[1, clNumColIndx].Value2.ToString());
										tt.SortOrder = (int?)row.Cells[1, clNumColIndx + 1].Value2;

										tt.Parent = _lvl1parent;
										SaveEnts(ref tt, allclTypes[1]);
										_lvl2parent = tt;
									}
									else if (clNumColIndx > 5 && row.Cells[1, 6].Value2 != null)
									{
										var tt = (ICodelist)Activator.CreateInstance(allclTypes[2]);

										tt.ShortDescription = row.Cells[1, 6].Value2.ToString();
										tt.LongDescription = (row.Cells[1, 7].Value2 == null) ? row.Cells[1, 7].Value2 : row.Cells[1, 7].Value2.ToString();
										tt.CodelistNumber = int.Parse(row.Cells[1, clNumColIndx].Value2.ToString());
										tt.SortOrder = (int?)row.Cells[1, clNumColIndx + 1].Value2;

										tt.Parent = _lvl2parent;
										SaveEnts(ref tt, allclTypes[2]);
									}

									//for (int i = 1 + curTypeIndx * 2; i < clNumColIndx; i++)
									//{
									//	if (row.Cells[1, i + 1].Value2 != null)
									//	{

									//		Console.Write(rowData[i] + " ");
									//	}
									//	else if (i == 1 || i == 3)
									//	{
									//		i++;
									//		curTypeIndx++;
									//	}
									//}
									Console.Write(".");
								}
								else
								{
									string res = (row.Cells[1, 1].Value2 != null) ? row.Cells[1, 1].Value2.ToString().ToUpper() : "";
									if (res == "START")
									{
										started = true;
									}
									else if (res == "HEAD")
									{
										for (int i = 1; i < row.Columns.Count; i += 2)
										{
											if ((row.Cells[1, i + 1].Value2 != null))
											{
												string clName = row.Cells[1, i + 1].Value2.ToString().Trim(new char[] { ' ', '\n' }).Replace('\n', ' ');
												if (clName.ToLower().Contains("codelist") && clName.ToLower().Contains("number"))
												{
													clNumColIndx = i + 1;
													break;
												}
												var clType = _allTypes[clName.Split(' ')[0]];
												//var tt = Activator.CreateInstance(clType);
												allclTypes.Add(clType);
											}

										}
									}
								}
							}

							Console.WriteLine("\nLoaded\n");
							//var tt = Activator.CreateInstance(type);

							//if (parentName != "")
							//{
							//	var parentType = types.Where(i => i.Name == parentName).SingleOrDefault();

							//	var keys = new object[] { int.Parse(parentID) };

							//	var parent = db.Set(parentType).Find(keys);

							//	((ICodelist)tt).Parent = (ICodelist)parent;
							//}

							//db.Set(type).Add(tt);


							//db.SaveChanges();
						}
					}
					//Excel.Worksheet worksheet = excelApp.Sheets[kvp.Key];
				}
				//break;
			}
			excelApp.Quit();
			//Console.WriteLine("All done.\nPress any key for exit...")
			//Console.ReadKey();
		}

		private static void SaveEnts(ref ICodelist tt, Type type)
		{
			using (CatalogContext db = new CatalogContext())
			{
				if (tt.Parent == null || tt.Parent.ID == 0)
				{
				}
				else
				{
					var res = db.Set(tt.Parent.GetType()).Find(new object[] { tt.Parent.ID });
					//((ICodelistCategory)res).AddChild(tt);
					tt.Parent = (ICodelist)res;
				}
				db.Set(type).Add(tt);
				db.SaveChanges();
			}
		}

		static void Main(string[] args)
		{

			Assembly lib = typeof(CatalogModel.Codelists.AutomatedFlangeSelectionOption).Assembly;
			_allTypes = new Dictionary<string, Type>();



			foreach (Type type in lib.GetTypes())
			{
				if (type.GetInterfaces().Contains(typeof(ICodelist)))
				{
					var spl = type.FullName.Split('.');
					if (spl.Length > 2 && spl[1] != "Migrations")
					{
						var name = spl[spl.Length - 1];
						_allTypes.Add(name, type);
					}
				}
			}

			SaveEnts((args.Length > 0)? args[0] : null);
		}
	}
}
