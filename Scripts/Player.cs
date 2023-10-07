using Godot;
using System;

public partial class Player : CharacterBody2D
{

	private float moveSpeed = 200.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = new Vector2();

		if(Input.IsKeyPressed(Key.Left)){
			velocity.X -= 1;
		}
		
		if(Input.IsKeyPressed(Key.Right)){
			velocity.X += 1;
		}

		if(Input.IsKeyPressed(Key.Up)){
			velocity.Y -= 1;
		}
		
		if(Input.IsKeyPressed(Key.Down)){
			velocity.Y += 1;
		}

		Velocity = velocity * moveSpeed;
		MoveAndSlide();
	}
}
