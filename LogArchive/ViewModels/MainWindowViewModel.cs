//using Grabacr07.KanColleWrapper;
//using Grabacr07.KanColleWrapper.Models;
using System.Collections.Generic;
using System.IO;
//using System.Windows;

using LogArchive.Models;
using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace LogArchive.ViewModels
{
	public class MainWindowViewModel : WindowViewModel
	{
		#region ItemLists 変更通知プロパティ

		private List<ItemStringLists> _ItemLists;

		public List<ItemStringLists> ItemLists
		{
			get { return this._ItemLists; }
			set
			{
				if (this._ItemLists != value)
				{
					this._ItemLists = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region DropLists 変更通知プロパティ

		private List<DropStringLists> _DropLists;

		public List<DropStringLists> DropLists
		{
			get { return this._DropLists; }
			set
			{
				if (this._DropLists != value)
				{
					this._DropLists = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region BuildLists 変更通知プロパティ

		private List<BuildStirngLists> _BuildLists;

		public List<BuildStirngLists> BuildLists
		{
			get { return this._BuildLists; }
			set
			{
				if (this._BuildLists != value)
				{
					this._BuildLists = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region ItemPages
		private int _ItemPages;
		public int ItemPages
		{
			get { return this._ItemPages; }
			set
			{
				if (this._ItemPages == value) return;
				this._ItemPages = value;
				this.RefreshItem(true);
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region ItemMaxPage
		private int _ItemMaxPage;
		public int ItemMaxPage
		{
			get { return this._ItemMaxPage; }
			set
			{
				if (this._ItemMaxPage == value) return;
				this._ItemMaxPage = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region BuildPages
		private int _BuildPages;
		public int BuildPages
		{
			get { return this._BuildPages; }
			set
			{
				if (this._BuildPages == value) return;
				this._BuildPages = value;
				this.RefreshBuild(true);
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region BuildMaxPage
		private int _BuildMaxPage;
		public int BuildMaxPage
		{
			get { return this._BuildMaxPage; }
			set
			{
				if (this._BuildMaxPage == value) return;
				this._BuildMaxPage = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region DropPages
		private int _DropPages;
		public int DropPages
		{
			get { return this._DropPages; }
			set
			{
				if (this._DropPages == value) return;
				this._DropPages = value;
				this.RefreshDrop(true);
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region DropMaxPage
		private int _DropMaxPage;
		public int DropMaxPage
		{
			get { return this._DropMaxPage; }
			set
			{
				if (this._DropMaxPage == value) return;
				this._DropMaxPage = value;
				this.RaisePropertyChanged();
			}
		}
		#endregion

		#region Item_DateRange 변경 통지 프로퍼티

		private bool _Item_DateRange;

		public bool Item_DateRange
		{
			get { return this._Item_DateRange; }
			set
			{
				if (this._Item_DateRange != value)
				{
					_Item_DateRange = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_MinDate 변경 통지 프로퍼티

		private DateTime _Item_MinDate;

		public DateTime Item_MinDate
		{
			get { return this._Item_MinDate; }
			set
			{
				if (this._Item_MinDate != value)
				{
					this._Item_MinDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_MaxDate 변경 통지 프로퍼티

		private DateTime _Item_MaxDate;

		public DateTime Item_MaxDate
		{
			get { return this._Item_MaxDate; }
			set
			{
				if (this._Item_MaxDate != value)
				{
					this._Item_MaxDate = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_Assistant 변경 통지 프로퍼티

		private string _Item_Assistant;

		public string Item_Assistant
		{
			get { return this._Item_Assistant; }
			set
			{
				if (this._Item_Assistant != value)
				{
					this._Item_Assistant = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_Fuel 변경 통지 프로퍼티

		private int _Item_Fuel;

		public int Item_Fuel
		{
			get { return this._Item_Fuel; }
			set
			{
				if (this._Item_Fuel != value)
				{
					this._Item_Fuel = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_Bullet 변경 통지 프로퍼티

		private int _Item_Bullet;

		public int Item_Bullet
		{
			get { return this._Item_Bullet; }
			set
			{
				if (this._Item_Bullet != value)
				{
					this._Item_Bullet = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_Steel 변경 통지 프로퍼티

		private int _Item_Steel;

		public int Item_Steel
		{
			get { return this._Item_Steel; }
			set
			{
				if (this._Item_Steel != value)
				{
					this._Item_Steel = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Item_Bauxite 변경 통지 프로퍼티

		private int _Item_Bauxite;

		public int Item_Bauxite
		{
			get { return this._Item_Bauxite; }
			set
			{
				if (this._Item_Bauxite != value)
				{
					this._Item_Bauxite = value;
					this.RaisePropertyChanged();
					RefreshItem(true);
				}
			}
		}

		#endregion

		#region Build_DateRange 변경 통지 프로퍼티

		private bool _Build_DateRange;

		public bool Build_DateRange
		{
			get { return this._Build_DateRange; }
			set
			{
				if (this._Build_DateRange != value)
				{
					_Build_DateRange = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_MinDate 변경 통지 프로퍼티

		private DateTime _Build_MinDate;

		public DateTime Build_MinDate
		{
			get { return this._Build_MinDate; }
			set
			{
				if (this._Build_MinDate != value)
				{
					this._Build_MinDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_MaxDate 변경 통지 프로퍼티

		private DateTime _Build_MaxDate;

		public DateTime Build_MaxDate
		{
			get { return this._Build_MaxDate; }
			set
			{
				if (this._Build_MaxDate != value)
				{
					this._Build_MaxDate = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Assistant 변경 통지 프로퍼티

		private string _Build_Assistant;

		public string Build_Assistant
		{
			get { return this._Build_Assistant; }
			set
			{
				if (this._Build_Assistant != value)
				{
					this._Build_Assistant = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Fuel 변경 통지 프로퍼티

		private int _Build_Fuel;

		public int Build_Fuel
		{
			get { return this._Build_Fuel; }
			set
			{
				if (this._Build_Fuel != value)
				{
					this._Build_Fuel = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Bullet 변경 통지 프로퍼티

		private int _Build_Bullet;

		public int Build_Bullet
		{
			get { return this._Build_Bullet; }
			set
			{
				if (this._Build_Bullet != value)
				{
					this._Build_Bullet = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Steel 변경 통지 프로퍼티

		private int _Build_Steel;

		public int Build_Steel
		{
			get { return this._Build_Steel; }
			set
			{
				if (this._Build_Steel != value)
				{
					this._Build_Steel = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Bauxite 변경 통지 프로퍼티

		private int _Build_Bauxite;

		public int Build_Bauxite
		{
			get { return this._Build_Bauxite; }
			set
			{
				if (this._Build_Bauxite != value)
				{
					this._Build_Bauxite = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_ItemAll 변경 통지 프로퍼티

		private bool _Build_ItemAll;

		public bool Build_ItemAll
		{
			get { return this._Build_ItemAll; }
			set
			{
				if (this._Build_ItemAll != value)
				{
					this._Build_ItemAll = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Item1 변경 통지 프로퍼티

		private bool _Build_Item1;

		public bool Build_Item1
		{
			get { return this._Build_Item1; }
			set
			{
				if (this._Build_Item1 != value)
				{
					this._Build_Item1 = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Item20 변경 통지 프로퍼티

		private bool _Build_Item20;

		public bool Build_Item20
		{
			get { return this._Build_Item20; }
			set
			{
				if (this._Build_Item20 != value)
				{
					this._Build_Item20 = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_Item100 변경 통지 프로퍼티

		private bool _Build_Item100;

		public bool Build_Item100
		{
			get { return this._Build_Item100; }
			set
			{
				if (this._Build_Item100 != value)
				{
					this._Build_Item100 = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Build_LargeShip 변경 통지 프로퍼티

		private bool? _Build_LargeShip;

		public bool? Build_LargeShip
		{
			get { return this._Build_LargeShip; }
			set
			{
				if (this._Build_LargeShip != value)
				{
					_Build_LargeShip = value;
					this.RaisePropertyChanged();
					RefreshBuild(true);
				}
			}
		}

		#endregion

		#region Drop_DateRange 변경 통지 프로퍼티

		private bool _Drop_DateRange;

		public bool Drop_DateRange
		{
			get { return this._Drop_DateRange; }
			set
			{
				if (this._Drop_DateRange != value)
				{
					_Drop_DateRange = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_MinDate 변경 통지 프로퍼티

		private DateTime _Drop_MinDate;

		public DateTime Drop_MinDate
		{
			get { return this._Drop_MinDate; }
			set
			{
				if (this._Drop_MinDate != value)
				{
					this._Drop_MinDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_MaxDate 변경 통지 프로퍼티

		private DateTime _Drop_MaxDate;

		public DateTime Drop_MaxDate
		{
			get { return this._Drop_MaxDate; }
			set
			{
				if (this._Drop_MaxDate != value)
				{
					this._Drop_MaxDate = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_BossCheck 변경 통지 프로퍼티

		private bool? _Drop_BossCheck;
		
		public bool? Drop_BossCheck
		{
			get { return this._Drop_BossCheck; }
			set
			{
				if (this._Drop_BossCheck != value)
				{
					_Drop_BossCheck = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_World 변경 통지 프로퍼티

		private int _Drop_World;

		public int Drop_World
		{
			get { return this._Drop_World; }
			set
			{
				if (this._Drop_World != value)
				{
					this._Drop_World = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_Map 변경 통지 프로퍼티

		private int _Drop_Map;

		public int Drop_Map
		{
			get { return this._Drop_Map; }
			set
			{
				if (this._Drop_Map != value)
				{
					this._Drop_Map = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_Nodes 변경 통지 프로퍼티

		private List<int> _Drop_Nodes;

		public List<int> Drop_Nodes
		{
			get { return this._Drop_Nodes; }
			set
			{
				if (this._Drop_Nodes != value)
				{
					this._Drop_Nodes = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_RankS 변경 통지 프로퍼티

		private bool _Drop_RankS;

		public bool Drop_RankS
		{
			get { return this._Drop_RankS; }
			set
			{
				if (this._Drop_RankS != value)
				{
					this._Drop_RankS = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_RankA 변경 통지 프로퍼티

		private bool _Drop_RankA;

		public bool Drop_RankA
		{
			get { return this._Drop_RankA; }
			set
			{
				if (this._Drop_RankA != value)
				{
					this._Drop_RankA = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_RankB 변경 통지 프로퍼티

		private bool _Drop_RankB;

		public bool Drop_RankB
		{
			get { return this._Drop_RankB; }
			set
			{
				if (this._Drop_RankB != value)
				{
					this._Drop_RankB = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		#region Drop_RankC 변경 통지 프로퍼티

		private bool _Drop_RankC;

		public bool Drop_RankC
		{
			get { return this._Drop_RankC; }
			set
			{
				if (this._Drop_RankC != value)
				{
					this._Drop_RankC = value;
					this.RaisePropertyChanged();
					RefreshDrop(true);
				}
			}
		}

		#endregion

		private string MainFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

		public MainWindowViewModel()
		{
			this.Title = "제독업무도 바빠! 기록열람";

			this._Item_MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
			this._Item_MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);

			this._Build_MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
			this._Build_MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
			this._Build_ItemAll = true;
			this._Build_LargeShip = null;

			this._Drop_MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
			this._Drop_MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
			this._Drop_Nodes = new List<int>();
			this._Drop_BossCheck = null;
			this._Drop_RankS = true;
			this._Drop_RankA = true;
			this._Drop_RankB = true;
			this._Drop_RankC = true;
		}
		public void csvtobin()
		{
			if (!Directory.Exists(Path.Combine(MainFolder, "Bin")))
				Directory.CreateDirectory(Path.Combine(MainFolder, "Bin"));

			#region ItemBuild구역
			var csvPath = Path.Combine(MainFolder, "ItemBuildLog2.csv");
			if (File.Exists(csvPath))
			{

				var items = new List<ItemStringLists>();
				foreach (var line in File.ReadAllLines(csvPath))
				{
					var parts = line.Split(',');
					if (parts[0] != "날짜" && parts[6] != "NA")
						items.Add(new ItemStringLists
						{
							Date = parts[0],
							Assistant = parts[1],
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							Bauxite = int.Parse(parts[5]),
							Results = parts[6],
						});
					else if (parts[0] != "날짜")
						items.Add(new ItemStringLists
						{
							Date = parts[0],
							Assistant = parts[1],
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							Bauxite = int.Parse(parts[5]),
							Results = string.Empty,
						});
				}


				var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild2.bin");

				using (var fileStream = new FileStream(binPath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (var writer = new BinaryWriter(fileStream))
				{
					foreach (var item in items)
					{
						writer.Write(item.Date);
						writer.Write(item.Assistant);
						writer.Write(item.Fuel);
						writer.Write(item.Bullet);
						writer.Write(item.Steel);
						writer.Write(item.Bauxite);
						writer.Write(item.Results);
					}
					fileStream.Dispose();
					fileStream.Close();
					writer.Dispose();
					writer.Close();
				}

			}
			#endregion

			#region ShipBuild구역
			csvPath = Path.Combine(MainFolder, "ShipBuildLog2.csv");
			if (File.Exists(csvPath))
			{

				var items = new List<BuildStirngLists>();
				foreach (var line in File.ReadAllLines(csvPath))
				{
					var parts = line.Split(',');
					if (parts[0] != "날짜" && parts[7] != "NA")
						items.Add(new BuildStirngLists
						{
							Date = parts[0],
							Assistant = parts[1],
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							Bauxite = int.Parse(parts[5]),
							UseItems = int.Parse(parts[6]),
							Results = parts[7],
						});
					else if (parts[0] != "날짜")
						items.Add(new BuildStirngLists
						{
							Date = parts[0],
							Assistant = parts[1],
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							Bauxite = int.Parse(parts[5]),
							UseItems = int.Parse(parts[6]),
							Results = string.Empty,
						});
				}


				var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild2.bin");

				using (var fileStream = new FileStream(binPath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (var writer = new BinaryWriter(fileStream))
				{
					foreach (var item in items)
					{
						writer.Write(item.Date);
						writer.Write(item.Assistant);
						writer.Write(item.Fuel);
						writer.Write(item.Bullet);
						writer.Write(item.Steel);
						writer.Write(item.Bauxite);
						writer.Write(item.UseItems);
						writer.Write(item.Results);
					}
					fileStream.Dispose();
					fileStream.Close();
					writer.Dispose();
					writer.Close();
				}

			}
			#endregion

			#region Drop구역
			csvPath = Path.Combine(MainFolder, "DropLog2.csv");
			if (File.Exists(csvPath))
			{

				var items = new List<DropStringLists>();
				foreach (var line in File.ReadAllLines(csvPath))
				{
					var parts = line.Split(',');
					if (parts[0] != "날짜" && parts[6] != "")
						items.Add(new DropStringLists
						{
							Date = parts[0],
							SeaArea = parts[1],
							MapInfo = parts[2],
							Boss = parts[3],
							EnemyFleet = parts[4],
							Rank = parts[5],
							Drop = parts[6],
						});
					else if (parts[0] != "날짜")
						items.Add(new DropStringLists
						{
							Date = parts[0],
							SeaArea = parts[1],
							MapInfo = parts[2],
							Boss = parts[3],
							EnemyFleet = parts[4],
							Rank = parts[5],
							Drop = string.Empty,
						});
				}


				var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");

				using (var fileStream = new FileStream(binPath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (var writer = new BinaryWriter(fileStream))
				{
					foreach (var item in items)
					{
						writer.Write(item.Date);
						writer.Write(item.SeaArea);
						writer.Write(item.MapInfo);
						writer.Write(item.Boss);
						writer.Write(item.EnemyFleet);
						writer.Write(item.Rank);
						writer.Write(item.Drop);
					}
					fileStream.Dispose();
					fileStream.Close();
					writer.Dispose();
					writer.Close();
				}

			}
			#endregion
		}

		public void ItemGoBack()
		{
			if (this.ItemPages >= 1) this.ItemPages--;
		}
		public void ItemGoForward()
		{
			if (this.ItemPages + 1 <= ItemMaxPage) this.ItemPages++;
		}

		public void BuildGoBack()
		{
			if (this.BuildPages >= 1) this.BuildPages--;
		}
		public void BuildGoForward()
		{
			if (this.BuildPages + 1 <= BuildMaxPage) this.BuildPages++;
		}
		public void DropGoBack()
		{
			if (this.DropPages >= 1) this.DropPages--;
		}
		public void DropGoForward()
		{
			if (this.DropPages + 1 <= DropMaxPage) this.DropPages++;
		}

		public DateTime CSVStringToTime(string str)
		{
			string[] elem = str.Split("- :".ToCharArray());

			// Excel様が *うっかり* データを破損させることがあるので対応
			return new DateTime(
				elem.Length > 0 ? int.Parse(elem[0]) : 1970,
				elem.Length > 1 ? int.Parse(elem[1]) : 1,
				elem.Length > 2 ? int.Parse(elem[2]) : 1,
				elem.Length > 3 ? int.Parse(elem[3]) : 0,
				elem.Length > 4 ? int.Parse(elem[4]) : 0,
				elem.Length > 5 ? int.Parse(elem[5]) : 0);
		}

		#region ItemLists 필터
		public List<ItemStringLists> ItemListFilter(List<ItemStringLists> itemdata)
		{
			if (itemdata == null)
				return null;

			itemdata = itemdata.Where(x => !Item_DateRange || (Item_DateRange && DateTime.Compare(CSVStringToTime(x.Date), Item_MinDate) >= 0 && DateTime.Compare(CSVStringToTime(x.Date), Item_MaxDate) <= 0))
											.Where(x => ItemAssistantCheck(x))
											.Where(x => ItemRecipeCheck(x))
											.ToList();

			int count = 1;
			foreach (var item in itemdata)
			{
				item.Id = count;
				count++;
			}

			return itemdata;
		}

		/// <summary>
		/// 해당 개발 데이터가 비서함 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool ItemAssistantCheck(ItemStringLists itemdata)
		{
			if (Item_Assistant == null || Item_Assistant == "" || itemdata.Assistant.Contains(Item_Assistant))
				return true;

			return false;
		}

		/// <summary>
		/// 해당 개발 데이터가 레시피 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool ItemRecipeCheck(ItemStringLists itemdata)
		{
			if ((Item_Fuel == 0 || itemdata.Fuel == Item_Fuel) &&
				(Item_Bullet == 0 || itemdata.Bullet == Item_Bullet) &&
				(Item_Steel == 0 || itemdata.Steel == Item_Steel) &&
				(Item_Bauxite == 0 || itemdata.Bauxite == Item_Bauxite))
				return true;

			return false;
		}
		#endregion

		#region BuildLists 필터
		public List<BuildStirngLists> BuildListFilter(List<BuildStirngLists> builddata)
		{
			if (builddata == null)
				return null;

			builddata = builddata.Where(x => !Build_DateRange || (Build_DateRange && DateTime.Compare(CSVStringToTime(x.Date), Build_MinDate) >= 0 && DateTime.Compare(CSVStringToTime(x.Date), Build_MaxDate) <= 0))
											.Where(x => BuildAssistantCheck(x))
											.Where(x => BuildRecipeCheck(x))
											.Where(x => BuildItemCheck(x))
											.Where(x => BuildLargeShipCheck(x))
											.ToList();

			int count = 1;
			foreach (var build in builddata)
			{
				build.Id = count;
				count++;
			}

			return builddata;
		}

		/// <summary>
		/// 해당 건조 데이터가 비서함 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool BuildAssistantCheck(BuildStirngLists builddata)
		{
			if (Build_Assistant == null || Build_Assistant == "" || builddata.Assistant.Contains(Build_Assistant))
				return true;

			return false;
		}

		/// <summary>
		/// 해당 건조 데이터가 레시피 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool BuildRecipeCheck(BuildStirngLists builddata)
		{
			if ((Build_Fuel == 0 || builddata.Fuel == Build_Fuel) &&
				(Build_Bullet == 0 || builddata.Bullet == Build_Bullet) &&
				(Build_Steel == 0 || builddata.Steel == Build_Steel) &&
				(Build_Bauxite == 0 || builddata.Bauxite == Build_Bauxite))
				return true;

			return false;
		}

		/// <summary>
		/// 해당 건조 데이터가 개발자재 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool BuildItemCheck(BuildStirngLists builddata)
		{
			if (Build_ItemAll) return true;
			if (Build_Item1 && builddata.UseItems == 1) return true;
			if (Build_Item20 && builddata.UseItems == 20) return true;
			if (Build_Item100 && builddata.UseItems == 100) return true;

			return false;
		}

		/// <summary>
		/// 해당 건조 데이터가 대형함 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool BuildLargeShipCheck(BuildStirngLists builddata)
		{
			if (Build_LargeShip == null) return true;
			if (Build_LargeShip == true && IsLargeShipRecipe(builddata)) return true;
			if (Build_LargeShip == false && !IsLargeShipRecipe(builddata)) return true;

			return false;
		}

		/// <summary>
		/// 해당 건조 데이터의 레시피가 대형함 건조 레시피인지를 구합니다.
		/// </summary>
		public bool IsLargeShipRecipe(BuildStirngLists builddata)
		{
			if (builddata.Fuel >= 1500 || builddata.Bullet >= 1500 || builddata.Steel >= 2000 || builddata.Bauxite >= 1000)
				return true;

			return false;
		}
		#endregion

		#region DropLists 필터
		public List<DropStringLists> DropListFilter(List<DropStringLists> dropdata)
		{
			if (dropdata == null)
				return null;

			dropdata = dropdata.Where(x => !Drop_DateRange || (Drop_DateRange && DateTime.Compare(CSVStringToTime(x.Date), Drop_MinDate) >= 0 && DateTime.Compare(CSVStringToTime(x.Date), Drop_MaxDate) <= 0))
											.Where(x => DropRankCalc(x))
											.Where(x => DropMapInfoCalc(x))
											.Where(x => DropBossCalc(x))
											.ToList();

			int count = 1;
			foreach (var drop in dropdata)
			{
				drop.Id = count;
				count++;
			}

			return dropdata;
		}

		/// <summary>
		/// 해당 드랍 데이터가 랭크 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool DropRankCalc(DropStringLists dropdata)
		{
			if (Drop_RankS && dropdata.Rank == "S") return true;
			if (Drop_RankA && dropdata.Rank == "A") return true;
			if (Drop_RankB && dropdata.Rank == "B") return true;
			if (Drop_RankC && (dropdata.Rank == "C" || dropdata.Rank == "D" || dropdata.Rank == "E")) return true;

			return false;
		}

		/// <summary>
		/// 해당 드랍 데이터가 맵 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool DropMapInfoCalc(DropStringLists dropdata)
		{
			int dropworld = 0;
			int dropmap = 0;
			int dropnode = 0;

			string[] mapText = dropdata.MapInfo.Split('-');

			if (int.TryParse(mapText[0], out dropworld) && int.TryParse(mapText[1], out dropmap) && int.TryParse(mapText[2], out dropnode))
				if ((Drop_World == 0 || dropworld == Drop_World) && (Drop_Map == 0 || dropmap == Drop_Map) && (Drop_BossCheck == true || Drop_Nodes.Count == 0 || Drop_Nodes.Any(x => dropnode == x)))
					return true;

			return false;
		}

		/// <summary>
		/// 해당 드랍 데이터가 보스 조건을 만족하고 있는지를 구합니다.
		/// </summary>
		public bool DropBossCalc(DropStringLists dropdata)
		{
			if (Drop_BossCheck == null) return true;
			if (Drop_BossCheck == true && dropdata.Boss == "O") return true;
			if (Drop_BossCheck == false && dropdata.Boss == "X") return true;

			return false;
		}
		#endregion

		#region 새로고침 버튼 메서드 모음
		public void RefreshItem(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild2.bin");

			if (File.Exists(binPath))
				this.ItemLists = new List<ItemStringLists>(this.ReturnItemList(binPath, IsNavi));
		}
		public void RefreshDrop(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");
			if (File.Exists(binPath))
				this.DropLists = new List<DropStringLists>(ReturnDropList(binPath, IsNavi));
		}
		public void RefreshBuild(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild2.bin");
			if (File.Exists(binPath))
				this.BuildLists = new List<BuildStirngLists>(ReturnBuildList(binPath, IsNavi));

		}
		public void RefreshItem()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild2.bin");

			if (File.Exists(binPath))
				this.ItemLists = new List<ItemStringLists>(this.ReturnItemList(binPath, false));
		}
		public void RefreshDrop()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");
			if (File.Exists(binPath))
				this.DropLists = new List<DropStringLists>(ReturnDropList(binPath, false));
		}
		public void RefreshBuild()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild2.bin");
			if (File.Exists(binPath))
				this.BuildLists = new List<BuildStirngLists>(ReturnBuildList(binPath, false));

		}
		#endregion

		#region 복사 버튼 메서드 모음
		public void CopyItemList()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild2.bin");
			List<ItemStringLists> itemlist = null;
			if (File.Exists(binPath))
				itemlist = ReturnItemList(binPath, false, true);
			else
				return;

			StringBuilder text = new StringBuilder();

			text.AppendLine("No.,날짜,비서함,연료,탄,강재,보크사이트,결과");

			int count = 1;
			foreach (var item in itemlist)
			{
				text.AppendLine($"{count},{item.Date},{item.Assistant},{item.Fuel},{item.Bullet},{item.Steel},{item.Bauxite},{item.Results}");
				count++;
			}

			Clipboard.SetText(text.ToString());
		}

		public void CopyBuildList()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild2.bin");
			List<BuildStirngLists> buildlist = null;
			if (File.Exists(binPath))
				buildlist = ReturnBuildList(binPath, false, true);
			else
				return;

			StringBuilder text = new StringBuilder();

			text.AppendLine("No.,날짜,비서함,연료,탄,강재,보크사이트,개발자재,결과");

			int count = 1;
			foreach (var build in buildlist)
			{
				text.AppendLine($"{count},{build.Date},{build.Assistant},{build.Fuel},{build.Bullet},{build.Steel},{build.Bauxite},{build.UseItems},{build.Results}");
				count++;
			}

			Clipboard.SetText(text.ToString());
		}

		public void CopyDropList()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");
			List<DropStringLists> droplist = null;
			if (File.Exists(binPath))
				droplist = ReturnDropList(binPath, false, true);
			else
				return;

			StringBuilder text = new StringBuilder();

			text.AppendLine("No.,날짜,해역이름,해역,보스,적 함대,랭크,드랍");

			int count = 1;
			foreach (var drop in droplist)
			{
				text.AppendLine($"{count},{drop.Date},{drop.SeaArea},{drop.MapInfo},{drop.Boss},{drop.EnemyFleet},{drop.Rank},{drop.Drop}");
				count++;
			}

			Clipboard.SetText(text.ToString());
		}
		#endregion

		#region Return함수
		public List<ItemStringLists> ReturnItemList(string FileName, bool IsNavi, bool ReturnAll = false)
		{
			var items = new List<ItemStringLists>();

			var pagingList = new List<List<ItemStringLists>>();

			var bytes = File.ReadAllBytes(FileName);
			using (var memoryStream = new MemoryStream(bytes))
			using (var reader = new BinaryReader(memoryStream))
			{
				while (memoryStream.Position < memoryStream.Length)
				{
					var item = new ItemStringLists
					{
						Date = reader.ReadString(),
						Assistant = reader.ReadString(),
						Fuel = reader.ReadInt32(),
						Bullet = reader.ReadInt32(),
						Steel = reader.ReadInt32(),
						Bauxite = reader.ReadInt32(),
						Results = reader.ReadString(),
					};
					//item.Results = KanColleClient.Current.Translations.GetTranslation(item.Results, TranslationType.Equipment, true);
					//item.Assistant = KanColleClient.Current.Translations.GetTranslation(item.Assistant, TranslationType.ShipTypes, true);
					items.Add(item);
				}
				memoryStream.Dispose();
				memoryStream.Close();
				reader.Dispose();
				reader.Close();
			}
			items = ItemListFilter(items);
			if (ReturnAll == true) return items;

			int Page = 0, i = 0;
			do
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));

				i = i + 20;
			} while (i < items.Count);
			this.ItemMaxPage = Page;
			if (this.ItemPages >= ItemMaxPage) this.ItemPages = this.ItemMaxPage;
			if (IsNavi) return pagingList[this.ItemPages];
			else
			{
				this.ItemPages = this.ItemMaxPage;
				return pagingList[this.ItemMaxPage];
			}
		}
		public List<BuildStirngLists> ReturnBuildList(string FileName, bool IsNavi, bool ReturnAll = false)
		{
			var items = new List<BuildStirngLists>();

			var pagingList = new List<List<BuildStirngLists>>();

			var bytes = File.ReadAllBytes(FileName);
			using (var memoryStream = new MemoryStream(bytes))
			using (var reader = new BinaryReader(memoryStream))
			{
				while (memoryStream.Position < memoryStream.Length)
				{
					var item = new BuildStirngLists
					{
						Date = reader.ReadString(),
						Assistant = reader.ReadString(),
						Fuel = reader.ReadInt32(),
						Bullet = reader.ReadInt32(),
						Steel = reader.ReadInt32(),
						Bauxite = reader.ReadInt32(),
						UseItems = reader.ReadInt32(),
						Results = reader.ReadString(),
					};
					//item.Results = KanColleClient.Current.Translations.GetTranslation(item.Results, TranslationType.Ships, true);
					items.Add(item);
				}
				memoryStream.Dispose();
				memoryStream.Close();
				reader.Dispose();
				reader.Close();
			}
			items = BuildListFilter(items);
			if (ReturnAll == true) return items;

			int Page = 0, i = 0;
			do
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));

				i = i + 20;
			} while (i < items.Count);
			this.BuildMaxPage = Page;
			if (this.BuildPages >= BuildMaxPage) this.BuildPages = this.BuildMaxPage;
			if (IsNavi) return pagingList[this.BuildPages];
			else
			{
				this.BuildPages = this.BuildMaxPage;
				return pagingList[this.BuildMaxPage];
			}
		}
		public List<DropStringLists> ReturnDropList(string FileName, bool IsNavi, bool ReturnAll=false)
		{
			var items = new List<DropStringLists>();

			var pagingList = new List<List<DropStringLists>>();

			var bytes = File.ReadAllBytes(FileName);
			using (var memoryStream = new MemoryStream(bytes))
			using (var reader = new BinaryReader(memoryStream))
			{
				while (memoryStream.Position < memoryStream.Length)
				{
					var item = new DropStringLists
					{
						Date = reader.ReadString(),
						SeaArea = reader.ReadString(),
						MapInfo = reader.ReadString(),
						Boss = reader.ReadString(),
						EnemyFleet = reader.ReadString(),
						Rank = reader.ReadString(),
						Drop = reader.ReadString(),
					};
					//item.SeaArea = KanColleClient.Current.Translations.GetTranslation(item.SeaArea, TranslationType.OperationMaps, true);
					//item.EnemyFleet = KanColleClient.Current.Translations.GetTranslation(item.EnemyFleet, TranslationType.OperationSortie, true);
					items.Add(item);
				}
				memoryStream.Dispose();
				memoryStream.Close();
				reader.Dispose();
				reader.Close();
			}
			items = DropListFilter(items);
			if (ReturnAll == true) return items;

			int Page = 0, i = 0;
			do
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));

				i = i + 20;
			} while (i < items.Count);
			this.DropMaxPage = Page;
			if (this.DropPages >= DropMaxPage) this.DropPages = this.DropMaxPage;
			if (IsNavi) return pagingList[this.DropPages];
			else
			{
				this.DropPages = this.DropMaxPage;
				return pagingList[this.DropMaxPage];
			}
		}
		#endregion
	}
}
