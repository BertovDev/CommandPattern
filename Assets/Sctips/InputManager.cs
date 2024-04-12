using UnityEngine;
public class InputManager : MonoBehaviour {
    public ControlPlayer controlPlayer;

   void Update(){
    if(Input.GetKeyDown(KeyCode.A)){
        OnRightInput();
    }
    else if(Input.GetKeyDown(KeyCode.D)){
        OnLeftInput();
    }
    else if(Input.GetKeyDown(KeyCode.Space)){
        CommandInvoker.UndoCommand();
    }
   }

    private void OnLeftInput(){
        RunPlayerCommand(controlPlayer, Vector3.right);
    }
    private void OnRightInput(){
        RunPlayerCommand(controlPlayer, Vector3.back);
    }
 
    public void RunPlayerCommand(ControlPlayer player, Vector3 movement){
        ICommand command = new MoveCommand(player, movement);
        CommandInvoker.ExecuteCommand(command);
    }
}