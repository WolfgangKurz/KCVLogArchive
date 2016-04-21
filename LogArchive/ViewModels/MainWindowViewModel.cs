//using Grabacr07.KanColleWrapper;
//using Grabacr07.KanColleWrapper.Models;
using System.Collections.Generic;
using System.IO;
//using System.Windows;

using LogArchive.Models;
using System;
using System.Linq;

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

		#region DropData 변경 통지 프로퍼티

		private List<DropStringLists> _DropData;

		public List<DropStringLists> DropData
		{
			get { return this._DropData; }
			set
			{
				if (this._DropData != value)
				{
					this._DropData = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region Drop_MinDate 변경 통지 프로퍼티

		private DateTime _Drop_MinDate;

		public DateTime Drop_MinDate
		{
			get
			{
				if(_Drop_MinDate == null)
					_Drop_MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
				return this._Drop_MinDate;
			}
			set
			{
				if (this._Drop_MinDate != value)
				{
					this._Drop_MinDate = new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
					this.RaisePropertyChanged();
					RefreshDropList();
				}
			}
		}

		#endregion

		#region Drop_MaxDate 변경 통지 프로퍼티

		private DateTime _Drop_MaxDate;

		public DateTime Drop_MaxDate
		{
			get
			{
				if (_Drop_MaxDate == null)
					_Drop_MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
				return this._Drop_MaxDate;
			}
			set
			{
				if (this._Drop_MaxDate != value)
				{
					this._Drop_MaxDate = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
					this.RaisePropertyChanged();
					RefreshDropList();
				}
			}
		}

		#endregion

		#region Drop_World 변경 통지 프로퍼티

		private string _Drop_World;

		public string Drop_World
		{
			get { return this._Drop_World; }
			set
			{
				if (this._Drop_World != value)
				{
					this._Drop_World = value;
					this.RaisePropertyChanged();
					RefreshDropList();
				}
			}
		}

		#endregion

		#region Drop_Map 변경 통지 프로퍼티

		private string _Drop_Map;

		public string Drop_Map
		{
			get { return this._Drop_Map; }
			set
			{
				if (this._Drop_Map != value)
				{
					this._Drop_Map = value;
					this.RaisePropertyChanged();
					RefreshDropList();
				}
			}
		}

		#endregion

		#region Drop_Nodes 변경 통지 프로퍼티

		private string _Drop_Nodes;

		public string Drop_Nodes
		{
			get { return this._Drop_Nodes; }
			set
			{
				if (this._Drop_Nodes != value)
				{
					this._Drop_Nodes = value;
					this.RaisePropertyChanged();
					RefreshDropList();
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
					RefreshDropList();
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
					RefreshDropList();
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
					RefreshDropList();
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
					RefreshDropList();
				}
			}
		}

		#endregion

		private string MainFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

		public MainWindowViewModel()
		{
			this.Title = "제독업무도 바빠! 기록열람";
		}
		public void csvtobin()
		{
			if (!Directory.Exists(Path.Combine(MainFolder, "Bin")))
				Directory.CreateDirectory(Path.Combine(MainFolder, "Bin"));
			#region ItemBuild구역
			var csvPath = Path.Combine(MainFolder, "ItemBuildLog.csv");
			if (File.Exists(csvPath))
			{

				var items = new List<ItemStringLists>();
				foreach (var line in File.ReadAllLines(csvPath))
				{
					var parts = line.Split(',');
					if (parts[0] != "날짜" && parts[1] != "NA")
						items.Add(new ItemStringLists
						{
							Date = parts[0],
							Results = parts[1],
							Assistant = parts[2],
							Fuel = int.Parse(parts[3]),
							Bullet = int.Parse(parts[4]),
							Steel = int.Parse(parts[5]),
							bauxite = int.Parse(parts[6]),
						});
					else if (parts[0] != "날짜")
						items.Add(new ItemStringLists
						{
							Date = parts[0],
							Results = string.Empty,
							Assistant = parts[2],
							Fuel = int.Parse(parts[3]),
							Bullet = int.Parse(parts[4]),
							Steel = int.Parse(parts[5]),
							bauxite = int.Parse(parts[6]),
						});
				}


				var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild.bin");

				using (var fileStream = new FileStream(binPath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (var writer = new BinaryWriter(fileStream))
				{
					foreach (var item in items)
					{
						writer.Write(item.Date);
						writer.Write(item.Results);
						writer.Write(item.Assistant);
						writer.Write(item.Fuel);
						writer.Write(item.Bullet);
						writer.Write(item.Steel);
						writer.Write(item.bauxite);
					}
					fileStream.Dispose();
					fileStream.Close();
					writer.Dispose();
					writer.Close();
				}

			}
			#endregion

			#region ShipBuild구역
			csvPath = Path.Combine(MainFolder, "ShipBuildLog.csv");
			if (File.Exists(csvPath))
			{

				var items = new List<BuildStirngLists>();
				foreach (var line in File.ReadAllLines(csvPath))
				{
					var parts = line.Split(',');
					if (parts[0] != "날짜" && parts[1] != "NA")
						items.Add(new BuildStirngLists
						{
							Date = parts[0],
							Results = parts[1],
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							bauxite = int.Parse(parts[5]),
							UseItems = int.Parse(parts[6]),
						});
					else if (parts[0] != "날짜")
						items.Add(new BuildStirngLists
						{
							Date = parts[0],
							Results = string.Empty,
							Fuel = int.Parse(parts[2]),
							Bullet = int.Parse(parts[3]),
							Steel = int.Parse(parts[4]),
							bauxite = int.Parse(parts[5]),
							UseItems = int.Parse(parts[6]),
						});
				}


				var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild.bin");

				using (var fileStream = new FileStream(binPath, FileMode.Create, FileAccess.Write, FileShare.None))
				using (var writer = new BinaryWriter(fileStream))
				{
					foreach (var item in items)
					{
						writer.Write(item.Date);
						writer.Write(item.Results);
						writer.Write(item.Fuel);
						writer.Write(item.Bullet);
						writer.Write(item.Steel);
						writer.Write(item.bauxite);
						writer.Write(item.UseItems);
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
					//ID,날짜,해역이름,해역,적 함대,랭크,드랍
					var parts = line.Split(',');
					if (parts[0] != "ID" && parts[5] != "")
						items.Add(new DropStringLists
						{
							Date = parts[0],
							SeaArea = parts[1],
							MapInfo = parts[2],
							EnemyFleet = parts[3],
							Rank = parts[4],
							Drop = parts[5],
						});
					else if (parts[0] != "ID")
						items.Add(new DropStringLists
						{
							Date = parts[0],
							SeaArea = parts[1],
							MapInfo = parts[2],
							EnemyFleet = parts[3],
							Rank = parts[4],
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

		public void RefreshDropList()
		{
			int world = 0;
			int map = 0;
			List<int> nodes = new List<int>();
			bool searchNode = true;

			if (int.TryParse(Drop_World, out world) && int.TryParse(Drop_World, out map))
			{
				string[] nodeText = Drop_Nodes.Split(',');

				foreach(var text in nodeText)
				{
					int node;
					if (!int.TryParse(text, out node))
					{
						searchNode = false;
						break;
					}
					nodes.Add(node);
				}
			}

			DropLists = DropData.Where(x => DateTime.Compare(CSVStringToTime(x.Date), Drop_MinDate) >= 0 && DateTime.Compare(CSVStringToTime(x.Date), Drop_MaxDate) <= 0)
											.Where(x => x.Rank == "S" && Drop_RankS)
											.Where(x => x.Rank == "A" && Drop_RankA)
											.Where(x => x.Rank == "B" && Drop_RankB)
											.Where(x => (x.Rank == "C" || x.Rank == "D" || x.Rank == "E") && Drop_RankC)
											.ToList();
			foreach (var drop in DropLists)
			{
				int dropworld = 0;
				int dropmap = 0;
				int dropnode = 0;

				string[] mapText = drop.MapInfo.Split('-');

				if(!int.TryParse(mapText[0], out dropworld) || !int.TryParse(mapText[1], out dropmap) || !int.TryParse(mapText[2], out dropnode))
					DropLists.Remove(drop);
				if (dropworld != world || dropmap != map || !nodes.Any(x => dropnode == x))
					DropLists.Remove(drop);
			}
		}

		public DateTime CSVStringToTime(string str)
		{
			string[] elem = str.Split("/ :".ToCharArray());

			// Excel様が *うっかり* データを破損させることがあるので対応
			return new DateTime(
				elem.Length > 0 ? int.Parse(elem[0]) : 1970,
				elem.Length > 1 ? int.Parse(elem[1]) : 1,
				elem.Length > 2 ? int.Parse(elem[2]) : 1,
				elem.Length > 3 ? int.Parse(elem[3]) : 0,
				elem.Length > 4 ? int.Parse(elem[4]) : 0,
				elem.Length > 5 ? int.Parse(elem[5]) : 0);
		}

		#region 새로고침 버튼 메서드 모음
		public void RefreshItem()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild.bin");

			if (File.Exists(binPath))
				this.ItemLists = new List<ItemStringLists>(this.ReturnItemList(binPath, false));
		}
		public void RefreshItem(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ItemBuild.bin");

			if (File.Exists(binPath))
				this.ItemLists = new List<ItemStringLists>(this.ReturnItemList(binPath, IsNavi));
		}
		public void RefreshDrop(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");
			if (File.Exists(binPath))
				this.DropData = new List<DropStringLists>(ReturnDropList(binPath, IsNavi));
			RefreshDropList();
		}
		public void RefreshBuild(bool IsNavi)
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild.bin");
			if (File.Exists(binPath))
				this.BuildLists = new List<BuildStirngLists>(ReturnBuildList(binPath, IsNavi));

		}
		public void RefreshDrop()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "Drop2.bin");
			if (File.Exists(binPath))
				this.DropData = new List<DropStringLists>(ReturnDropList(binPath, false));
			RefreshDropList();
		}
		public void RefreshBuild()
		{
			var binPath = Path.Combine(MainFolder, "Bin", "ShipBuild.bin");
			if (File.Exists(binPath))
				this.BuildLists = new List<BuildStirngLists>(ReturnBuildList(binPath, false));

		}
		#endregion

		#region Return함수
		public List<ItemStringLists> ReturnItemList(string FileName, bool IsNavi)
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
						Results = reader.ReadString(),
						Assistant = reader.ReadString(),
						Fuel = reader.ReadInt32(),
						Bullet = reader.ReadInt32(),
						Steel = reader.ReadInt32(),
						bauxite = reader.ReadInt32(),
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
			int Page = 0;
			for (int i = 0; i < items.Count; i = i + 20)
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));
			}
			this.ItemMaxPage = Page;
			if (this.ItemPages >= ItemMaxPage) this.ItemPages = this.ItemMaxPage;
			if (IsNavi) return pagingList[this.ItemPages];
			else
			{
				this.ItemPages = this.ItemMaxPage;
				return pagingList[this.ItemMaxPage];
			}
		}
		public List<BuildStirngLists> ReturnBuildList(string FileName, bool IsNavi)
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
						Results = reader.ReadString(),
						Fuel = reader.ReadInt32(),
						Bullet = reader.ReadInt32(),
						Steel = reader.ReadInt32(),
						bauxite = reader.ReadInt32(),
						UseItems = reader.ReadInt32(),
					};
					//item.Results = KanColleClient.Current.Translations.GetTranslation(item.Results, TranslationType.Ships, true);
					items.Add(item);
				}
				memoryStream.Dispose();
				memoryStream.Close();
				reader.Dispose();
				reader.Close();
			}
			int Page = 0;
			for (int i = 0; i < items.Count; i = i + 20)
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));
			}
			this.BuildMaxPage = Page;
			if (this.BuildPages >= BuildMaxPage) this.BuildPages = this.BuildMaxPage;
			if (IsNavi) return pagingList[this.BuildPages];
			else
			{
				this.BuildPages = this.BuildMaxPage;
				return pagingList[this.BuildMaxPage];
			}
		}
		public List<DropStringLists> ReturnDropList(string FileName, bool IsNavi)
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
			int Page = 0;
			for (int i = 0; i < items.Count; i = i + 20)
			{
				if (i + 20 < items.Count)
				{
					pagingList.Add(items.GetRange(i, 20));
					Page++;
				}
				else pagingList.Add(items.GetRange(i, items.Count - Page * 20));
			}
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
