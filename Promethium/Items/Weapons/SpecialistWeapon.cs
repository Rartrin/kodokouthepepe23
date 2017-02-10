using Terraria;
using Terraria.ModLoader;
using Promethium.Items;

namespace Promethium.Items.Weapons
{
	public abstract class SpecialistWeapon:SpecialistItem
	{
		public override bool CanUseItem(Player player)
		{
			return CheckSpecialistID(player);
		}
	}
}
