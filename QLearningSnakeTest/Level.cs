using Godot;
using System;

public partial class Level : Node2D
{
	Gear Gear = new Gear();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
	}
	public void AddGear() {
		Random rnd = new Random();
		Gear.Position = new Vector2(rnd.Next(900), rnd.Next(900));
		Gear.Connect("GearUsed", this, nameof("spawnNew")); 
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
