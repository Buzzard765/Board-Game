using System.Collections;
using UnityEngine;

public class GameDice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public int whosTurn = 1;  
    //public Core GameManager;
    public int randomDiceSide;
    public int bonusRoll = 2;
	// Use this for initialization
    public bool onRoll =true;
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
	}

    private void OnMouseDown()
    {
        //onRoll = false;
        /*if (onRoll == true)
            StartCoroutine("RollTheDice");*/
        if(onRoll == true){
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            if(randomDiceSide + 1 == 6){
                LaunchReady();
            }
            Manager.gm.stepsAmount = randomDiceSide + 1;        
            changeTurn();       
            onRoll = false;
        }
       
    }

    public void LaunchReady(){
        Manager.gm.canLaunch= true;      
    }

    public void changeTurn(){
        Manager.gm.canMove = true;
        if (whosTurn == 1)
        {           
            Manager.gm.changeTurn(1);
        } else if (whosTurn == 2)
        {
            Manager.gm.changeTurn(2);
        }
        else if (whosTurn == 3)
        {
            Manager.gm.changeTurn(3);
        }
        else if (whosTurn == 4)
        {
            Manager.gm.changeTurn(4);
        }
        Manager.gm.whoseTurn = whosTurn;
        if(whosTurn <4){          
            whosTurn += 1;
        }else{
            whosTurn = 1;
        }
        
        
    }

    private IEnumerator RollTheDice()
    {
        yield return new WaitForSeconds(0.05f);
        /*onRoll = false;
        //randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            
        }

        GameManager.diceThrown = randomDiceSide + 1;
        
        if (whosTurn == 1)
        {
            GameManager.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            GameManager.MovePlayer(2);
        }
        whosTurn *= -1;
        onRoll = true;*/
    }
}
