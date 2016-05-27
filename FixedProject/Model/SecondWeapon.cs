using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FixedProject
{
	public class SecondWeapon
	{
		private Texture2D texture;
		private int damage;
		private float secondarySpeed;
		private Vector2 position;

		public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public float SecondarySpeed
		{
			get { return secondarySpeed; }
			set { secondarySpeed = value; 
		}

		public Vector2 Position
		{
				get { return position; }
				set { position = value; }
		}

		public void Initialize(Texture2D texture, Vector2 position)
		{
				this.texture = texture;
				this.position = position;
				this.damage = 5000;
				this.secondarySpeed = .3;
		}

		public void Update()
		{
				position.X += secondarySpeed;
				position.Y += .25;
		}

		public void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, position.Y * 3, Vector2.Zero, 1f, SpriteEffects.None, 0f);			}
	}
}

