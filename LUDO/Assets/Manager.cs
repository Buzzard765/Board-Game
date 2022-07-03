using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public int whoseTurn;
    public int redSteps, blueSteps, greenSteps, yellowSteps;
    
    public int redScore, blueScore, greenScore, yellowScore;
    public static Manager gm;
    public int stepsAmount;
    public bool canMove, canLaunch;
    public bool gameClear;
    [SerializeField] private Text WinText;
    [SerializeField] private GameObject Panel;
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

    public void declareWinner(){
        if(redScore == 4){                   
            WinText.text += "\nPlayer 1 Wins";
            gameClear = true;         
        }else if(blueScore == 4){
            WinText.text += "\nPlayer 2 Wins";
            gameClear = true;
        }else if(greenScore == 4){
            WinText.text += "\nPlayer 3 Wins";
            gameClear = true;
        }else if(yellowScore == 4){
            WinText.text += "\nPlayer 4 Wins";
            gameClear = true;
        }
        if(gameClear == true){
            Panel.SetActive(true);
        }
    }
    public void changeTurn(int player){

        /*if(canMove == true){
            switch (whoseTurn){
            case 1:
                //red.canMove = true;
                redSteps = stepsAmount;
                break;
            case 2:
                //blue.canMove = true;
                blueSteps = stepsAmount;
                break;
            case 3:
                //green.canMove = true;
                greenSteps = stepsAmount;
                break;
            case 4:
                //yellow.canMove = true;
                yellowSteps = stepsAmount;
                break;
            }
            //canMove = false;
        }*/
       
    }

    public void LaunchTurn(int player){
        /*if(hasLaunched == true){
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
        }*/
    }
}
