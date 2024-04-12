using System.Collections.Generic;

public class CommandInvoker {
    private static Stack<ICommand> commandStack = new Stack<ICommand>();

    public static void ExecuteCommand(ICommand command){
        command.Execute();
        commandStack.Push(command);
    }

    public static void UndoCommand(){
        if(commandStack.Count > 0){
           ICommand activeCommand = commandStack.Pop();
           activeCommand.Undo();
        }
    }
}