using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public static GameObject P1,P2,P3,P4;
    public int P1Start, P2Start, P3Start, P4Start;
    // Start is called before the first frame update
    void Start()
    {
        //All Players will Get their movement path component. restrict their movement

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void MovePlayer(int whichplayer){
        switch (whichplayer){
            case 1:
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
        }
            
    }
}
