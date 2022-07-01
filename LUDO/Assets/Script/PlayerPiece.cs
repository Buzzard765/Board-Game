using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{   
    public bool hasLaunched;
    public bool canMove;
    public int MoveSpace;

    public Paths PlayerPath;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPath = FindObjectOfType<Paths>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void launch(){
        transform.position = PlayerPath.PathGlobal[0].position;
        Manager.gm.hasLaunched = false;
        Manager.gm.canMove = false;        
    }

    
}
