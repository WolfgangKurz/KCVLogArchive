using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LogArchive.Models
{
	/// <summary>
	/// 날짜,해역이름,해역,보스,적 함대,랭크,드랍
	/// </summary>
	public class DropStringLists
	{
		public int Id { get; set; }
		public string Date { get; set; }
		public string SeaArea { get; set; }
		public string MapInfo { get; set; }
		public string Boss { get; set; }
		public string EnemyFleet { get; set; }
		public string Rank { get; set; }
		public string Drop { get; set; }
		public string DropItem { get; set; }

		public string MapDisplay
		{
			get
			{
				var part = this.MapInfo.Split('-');
				var display = "???";

				var date = Extensions.CSVStringToTime(this.Date);

				// 1기 노드와 2기 노드를 구분
				display = (date < new DateTime(2018, 08, 17, 0, 0, 0, DateTimeKind.Utc) ? NodeInfoData.OldNodeList : NodeInfoData.NodeList)
					.FirstOrDefault(x =>
						x.World.ToString() == part[0]
						&& x.Map.ToString() == part[1]
						&& x.Node.ToString() == part[2]
					)
					?.Display;

				return display == null
					? this.MapInfo
					: string.Format("{0}-{1}-{2}", part[0], part[1], display);
			}
		}
	}

	/// <summary>
	/// 날짜,비서함,연료,탄,강재,보크사이트,결과
	/// </summary>
	public class ItemStringLists
	{
		public int Id { get; set; }
		public string Date { get; set; }
		public string Assistant { get; set; }
		public int Fuel { get; set; }
		public int Steel { get; set; }
		public int Bullet { get; set; }
		public int Bauxite { get; set; }
		public string Results { get; set; }
	}

	/// <summary>
	/// 날짜,비서함,연료,탄,강재,보크사이트,개발자재,결과
	/// </summary>
	public class BuildStirngLists
	{
		public int Id { get; set; }
		public string Date { get; set; }
		public string Assistant { get; set; }
		public int Fuel { get; set; }
		public int Steel { get; set; }
		public int Bullet { get; set; }
		public int Bauxite { get; set; }
		public int UseItems { get; set; }
		public string Results { get; set; }
	}
}
