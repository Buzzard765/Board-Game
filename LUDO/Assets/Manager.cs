using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int whoseTurn;
    public PlayerPiece red, blue, green, yellow;
    public bool redLaunch, greenLaunch, blueLaunch, yellowLaunch;
    public static Manager gm;
    public int stepsAmount;
    public bool canMove, hasLaunched;
    GameDice dice;
    private void Awake() {
        gm = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeTurn(int player){

        if(canMove == true){
            switch (whoseTurn){
            case 1:
                //red.canMove = true;
                red.MoveSpace = stepsAmount;
                break;
            case 2:
                //blue.canMove = true;
                blue.MoveSpace = stepsAmount;
                break;
            case 3:
                //green.canMove = true;
                green.MoveSpace = stepsAmount;
                break;
            case 4:
                //yellow.canMove = true;
                yellow.MoveSpace = stepsAmount;
                break;
            }
            //canMove = false;
        }
       
    }

    public void LaunchTurn(int player){
        if(hasLaunched == true){
            switch (player){
            case 1:
                red.launch();
                red.canMove = false;               
                break;
            case 2:
                blue.hasLaunched = true;
                blue.launch();
                break;
            case 3:
                green.hasLaunched = true;
                green.launch();
                break;
            case 4:
                yellow.hasLaunched = true;
                yellow.launch();
                break;
            }
            //hasLaunched = false;
        }
    }
}
