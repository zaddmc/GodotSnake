using Godot;

public partial class snake : Node2D {

	Vector2 direction = new(5, 0);



	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		if (Input.IsActionJustPressed("ui_up"))
			direction = new Vector2(0, -5);
		else if (Input.IsActionJustPressed("ui_down"))
			direction = new Vector2(0, 5);
		else if (Input.IsActionJustPressed("ui_right"))
			direction = new Vector2(5, 0);
		else if (Input.IsActionJustPressed("ui_left"))
			direction = new Vector2(-5, 0);

		MoveSnake();
	}
	public void MoveSnake() {
		Position += direction/2;


	}
}
