using Godot;
using System;

public class PlayerController : KinematicBody2D
{
    // Player movement speed
    [Export]
    public float Speed = 400;

    private Vector2 velocity;

    public override void _PhysicsProcess(float delta)
    {
        GetInput();
        MoveAndSlide(velocity);
    }

    private void GetInput()
    {
        var inputDirection = new Vector2(
            Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"),
            Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up")
        );

        velocity = inputDirection.Normalized() * Speed; 
    }
}
