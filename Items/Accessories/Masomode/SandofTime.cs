using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FargowiltasSouls.Items.Accessories.Masomode
{
    public class SandsofTime : ModItem
    {
        public override string Texture => "FargowiltasSouls/Items/Placeholder";
        //sprite should be an hourglass
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sands of Time");
            Tooltip.SetDefault(@"''
Works in your inventory
Grants immunity to Mighty Wind
You respawn twice as fast");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.rare = 6;
            item.value = Item.sellPrice(0, 15);
        }

//change to update inventory
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //player.buffImmune[BuffID] = true; mighty wind
            
            //respawn faster ech

            
        }
    }
}