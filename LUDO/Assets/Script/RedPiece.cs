using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPiece : PlayerPiece
{
    int playerIndex;
    public int spaceIndex;
    public int stepsRemaining;
    GameDice Dice;
    Manager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        Dice = FindObjectOfType<GameDice>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        if(Manager.gm.canMove == true){
            Debug.Log(Manager.gm.canMove);
            MovePlayer();
        }        
    }

    void LaunchNewPiece(int PlayerTurn){
        
    }
    

    void MovePlayer(){
        StartCoroutine(MoveSteps());
    }

    IEnumerator MoveSteps(){
        int steps = Manager.gm.stepsAmount;
        //int backwardSteps =
        if(spaceIndex+steps < PlayerPath.PathGlobal.Length){
            for (int i = spaceIndex; i < (spaceIndex + steps); i++){
                transform.position = PlayerPath.PathGlobal[i].position;
                yield return new WaitForSeconds(0.2f);
            
            }
        }else if(spaceIndex+steps > PlayerPath.PathGlobal.Length){
            int backwardSteps = PlayerPath.PathGlobal.Length - (spaceIndex+steps);
            for (int i = PlayerPath.PathGlobal.Length; i < (PlayerPath.PathGlobal.Length - backwardSteps); i--){
                transform.position = PlayerPath.PathGlobal[i].position;
                yield return new WaitForSeconds(0.2f);           
            }
        }
        
        spaceIndex += steps;
        Dice.onRoll = true;
        Manager.gm.canMove = false;
    }
}
