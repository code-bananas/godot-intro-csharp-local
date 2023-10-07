using Godot;
using System;

public partial class Coin : Area2D
{
	public void _on_body_entered(Node2D body){
		Vector2 scaling = new Vector2(1.2f, 1.2f);
		
		body.ApplyScale(scaling);
		
		QueueFree();
	}
}
