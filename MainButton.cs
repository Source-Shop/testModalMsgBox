using Godot;
using System;

public partial class MainButton : Button
{
	public PackedScene MsgxScene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MsgxScene = GD.Load<PackedScene>("res://MsgButton.tscn");
	

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnButtonPressed()
	{
		var MsgBox = MsgxScene.Instantiate();
		AddSibling(MsgBox);
	
	}
}
