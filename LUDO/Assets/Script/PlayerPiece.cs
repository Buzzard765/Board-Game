using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{   
    public bool hasLaunched;
    public bool canMove;
    public int MoveSpace;

    [SerializeField]protected int spaceIndex;
    [SerializeField]protected int stepsRemaining;
    public Paths PlayerPath;

    public Transform LaunchSpot;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPath = FindObjectOfType<Paths>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    
}
