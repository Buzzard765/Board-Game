using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPieces : PlayerPiece
{
    int playerIndex;  
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
        if(Manager.gm.whoseTurn == 3 && Manager.gm.canMove == true && hasLaunched == true){
            Debug.Log(Manager.gm.canMove);
            MovePlayer();
        }

        if(Manager.gm.whoseTurn == 3 && Manager.gm.canLaunch == true && hasLaunched == false){
            LaunchNewPiece();           
        }        
    }

    void LaunchNewPiece(){
        hasLaunched = true;
        Manager.gm.canLaunch = false;
        transform.position = LaunchSpot.position + new Vector3(
            Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f));;
        Manager.gm.canMove = false;
        Dice.onRoll = true;
    }
    

    void MovePlayer(){
        StartCoroutine(MoveSteps(PlayerPath.PathG));
    }

    IEnumerator MoveSteps(Transform[] playerPath){
        int steps = Manager.gm.stepsAmount;
        //int backwardSteps =
        if(spaceIndex+steps < playerPath.Length){
            for (int i = spaceIndex; i < (spaceIndex + steps); i++){
                if(AvailablePath(steps, spaceIndex, playerPath) == true){
                    transform.position = playerPath[i].position + 
                    new Vector3(0.3f, 0.3f,0);
                    yield return new WaitForSeconds(0.2f);         
                }
                   
            } 
            spaceIndex += steps;
        }else if(spaceIndex+steps > playerPath.Length){
            Debug.Log("overreach");
            //hitung berapa banyak langkah mundur
            int forwardremain = playerPath.Length - spaceIndex;
            int backwardSteps = (spaceIndex+steps) - playerPath.Length;
            Debug.Log(backwardSteps);
            Debug.Log(playerPath.Length - backwardSteps);
            //melangkah mundur
            for (int i = spaceIndex; i < playerPath.Length; i++){
                transform.position = playerPath[i].position;
                yield return new WaitForSeconds(0.2f);
                 Debug.Log("forward first");
            }
            for (int i  = playerPath.Length-2; i> (playerPath.Length-2 - backwardSteps); i--){
                Debug.Log(playerPath.Length-2 + ">" + (playerPath.Length - backwardSteps));
                transform.position = playerPath[i].position;
                yield return new WaitForSeconds(0.2f);   
                Debug.Log("backward");        
            }
            spaceIndex = (playerPath.Length - backwardSteps);
        }
        Dice.onRoll = true;
        
        Manager.gm.canMove = false;
        Manager.gm.canLaunch = false;
        Manager.gm.declareWinner();
        
        if(spaceIndex == playerPath.Length){
            Manager.gm.greenScore++;
            Debug.Log("a Green Piece has reached Home!");
            Destroy(gameObject);
        }
        StopCoroutine(MoveSteps(playerPath));

    }

    bool AvailablePath(int StepsRemaining, int StepsTaken, Transform[] remainingPath){
        int PathPoints = remainingPath.Length - StepsTaken;
        if(PathPoints >= stepsRemaining){
            return true;
        }
        return false;
    }
}
