﻿// Projectile.cs
//Using declarations
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FixedProject
{
	public class Projectile
	{
		private Texture2D texture;
		// Image representing the Projectile
		public Texture2D Texture
		{
			get{return texture; }
			set{texture = value; }
		}

		private Vector2 position;
		// Position of the Projectile relative to the upper left side of the screen
		public Vector2 Position
		{
			get{return position; }
			set{position = value; }
		}

		private bool active;
		// State of the Projectile
		public bool Active
		{
			get{return active; }
			set{active = value; }
		}

		private int damage;
		// The amount of damage the projectile can inflict to an enemy
		public int Damage
		{
			get{return damage; }
			set{damage = value; }
		}
			
		// Represents the viewable boundary of the game
		Viewport viewport;

		// Get the width of the projectile ship
		public int Width
		{
			get { return Texture.Width; }
		}

		// Get the height of the projectile ship
		public int Height
		{
			get { return Texture.Height; }
		}

		// Determines how fast the projectile moves
		float projectileMoveSpeed;


		public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
		{
			Texture = texture;
			Position = position;
			this.viewport = viewport;

			Active = true;

			Damage = 2;

			projectileMoveSpeed = 20f;
		}

		public void Update()
		{
			// Projectiles always move to the right
			position.X += projectileMoveSpeed;

			// Deactivate the bullet if it goes out of screen
			if (Position.X + Texture.Width / 2 > viewport.Width)
				Active = false;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(Texture, Position, null, Color.White, 0f,
				new Vector2(Width / 2, Height / 2), 1f, SpriteEffects.None, 0f);
		}
	}
}

