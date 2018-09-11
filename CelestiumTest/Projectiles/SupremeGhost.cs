using System; //what sources the code uses, these sources allow for calling of terraria functions, existing system functions and microsoft vector functions (probably more)
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestiumTest.Projectiles //where it's stored, replace Mod with the name of your mod. This file is stored in the folder \Mod Sources\(mod name, folder can't have spaces)\Projectiles.
{
    public class SupremeGhost : ModProjectile
    {
        public override void SetDefaults()
        {
			 projectile.width = 48;
            projectile.height = 120;
            projectile.aiStyle = 2;
            projectile.friendly  = true; //player projectile
            projectile.ranged = true; //ranged projectile
            projectile.timeLeft = 360;
            aiType = ProjectileID.Bullet; //This clones the exact AI of the vanilla projectile Bullet.

         }
        public override void AI()
        {
            Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 227, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f);   //spawns dust behind it, this is a spectral light blue dust
        }
        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
		
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("69"), 180, false);
target.AddBuff(mod.BuffType("39"), 180, false);	
        }
    }
}