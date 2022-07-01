using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public Movement P1,P2,P3,P4;

    public int diceThrown;
    public int P1Start, P2Start, P3Start, P4Start;
    // Start is called before the first frame update
    void Start()
    {
        //All Players will Get their movement path component. restrict their movement

    }

    // Update is called once per frame
    void Update()
    {
        MovementManager();
    }

    void MovementManager(){
        if(P1.WPIndex > P1.StartIndex + diceThrown){           
            P1.onMove = false;
            P1.StartIndex = P1.WPIndex-1;
        }
        if(P2.WPIndex > P2.StartIndex + diceThrown){
            P2.onMove = false;
            P2.StartIndex = P2.WPIndex-1;
        }
        /*if(P3.WPIndex > P3Start + diceThrown){
            P3.onMove = false;
            P3.StartIndex = P3.WPIndex-1;
        }
        if(P3.WPIndex > P3Start + diceThrown){
            P4.onMove = false;
            P4.StartIndex = P4.WPIndex-1;
        }*/
    }

    void WinManager(){
        
    }

    public void PlayerPieces(){
        
    }

    public void MovePlayer(int whichplayer){
        switch (whichplayer){
            case 1:
                P1.MoveSpace = diceThrown;
                P1.onMove = true;
                break;
            case 2:
                P2.MoveSpace = diceThrown;
                P2.onMove = true;
                break;
            case 3:
                P3.onMove = true;
                break;
            case 4:
                P4.onMove = true;
                break;
        }
            
    }
}
