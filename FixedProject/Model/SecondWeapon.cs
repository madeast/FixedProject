using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FixedProject.Model
{
	public class SecondWeapon
	{
		private Texture2D texture;
		private int damage;
		private float secondarySpeed;
		private Vector2 position;
		private bool active;
		private Viewport viewport;
		private int height;
		private int width;


		public int Height
		{
			get { return Texture.Height; }

		}

		public int Width
		{
			get { return Texture.Width; }
		}

		public bool Active
		{
			get { return active; }
			set { active = value; }
		}
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
			set { secondarySpeed = value; }
		}

		public Vector2 Position
		{
				get { return position; }
				set { position = value; }
		}

		public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
		{
				this.viewport = viewport;
				this.texture = texture;
				this.position = position;
				this.damage = 50000000;
				this.secondarySpeed = .3f;
				this.active = true;
		}

		public void Update()
		{
				position.X += secondarySpeed;
				position.Y += .25f;
		}

		public void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(Texture, Position, null, Color.White, position.Y * 3, Vector2.Zero, 1f, SpriteEffects.None, 0f);			}
	}
}

