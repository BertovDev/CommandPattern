using UnityEngine;

// Concrete command
public class MoveCommand : ICommand {

    ControlPlayer controlPlayer;
    Vector3 movement;

    // Constructor
    public MoveCommand(ControlPlayer controlPlayer, Vector3 movement) {
        this.controlPlayer = controlPlayer;
        this.movement = movement;
    }

    public void Execute(){
        controlPlayer.DrawTrace();
        controlPlayer.Move(movement);
    }
    public void Undo(){
        controlPlayer.ClearCurrentTrace();
        controlPlayer.Move(-movement);
    }
}