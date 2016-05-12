using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FixedProject.View;

namespace FixedProject.Model
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;
		private Animation playerAnimation;

		public Texture2D PlayerTexture;

		public Vector2 Position;

		public bool Active
		{
			get{ return active; }
			set{ active = value; }
		}

		public int Health
		{
			get{ return health; }
			set{ health = value; }
		}

		public int Width
		{
			get { return playerAnimation.FrameWidth; }
		}

		public int Score
		{
			get { return score; }
			set { score = value; }
		}
			
		// Get the width of the player ship


		// Get the height of the player ship
		public int Height
		{
			get { return playerAnimation.FrameHeight; }
		}

		public void Initialize(Texture2D texture, Vector2 position)
		{
			this.active = true;
			this.health = 100;
			this.score = 0;
			this.PlayerTexture = texture;
			this.Position = position;

		}

			// Initialize the player
			public void Initialize(Animation animation, Vector2 position)
			{
				this.playerAnimation = animation;

				// Set the starting position of the player around the middle of the screen and to the back
				this.Position = position;

				// Set the player to be active
				this.active = true;

				// Set the player health
				this.health = 100;

				this.score = 0;
			}

		// Update the player animation
		public void Update(GameTime gameTime)
		{
			playerAnimation.Position = Position;
			playerAnimation.Update(gameTime);
		}

		// Draw the player
		public void Draw(SpriteBatch spriteBatch)
		{
			playerAnimation.Draw(spriteBatch);
		}
				
	}
}

