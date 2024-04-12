using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Client
public class ControlPlayer : MonoBehaviour
{
    GameObject player;
    public GameObject stepTrace;

    public Stack<GameObject> stepTraceStack = new Stack<GameObject>();
    
    void Start(){
        this.player = this.gameObject;
    }
    
    public void Move(Vector3 movement){
        player.transform.position = player.transform.position + movement;
    }

    public void DrawTrace(){
        GameObject trace = Instantiate(stepTrace, player.transform.parent);
        trace.transform.position = new Vector3(this.gameObject.transform.position.x,0.1f,player.transform.position.z);
        stepTraceStack.Push(trace);
    }

    public void ClearCurrentTrace(){
        if(stepTraceStack.Count > 0){
            Destroy(stepTraceStack.Pop());
        }
    }
}
