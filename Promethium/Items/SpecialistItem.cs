using Terraria;
using Terraria.ModLoader;
using Promethium;

namespace Promethium.Items
{
	public abstract class SpecialistItem:ModItem
	{
		public byte specialistID;
		
		public static bool CheckSpecialistID(Player player)
		{
			return player.GetModPlayer<CCMPlayer>(mod).specialistID==specialistID;
		}
	}
}
