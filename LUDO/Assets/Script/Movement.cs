using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform[] waypoints;
    private float speed = 7;
    public int WPIndex;
    public int StartIndex = 0;
    public bool onMove = false;
    public int MoveSpace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onMove == true){
            Move();
        }
    }

    public void Move(){
        if (WPIndex < waypoints.Length)
        {
            transform.position = Vector2.MoveTowards
                (transform.position,
                waypoints[WPIndex].transform.position,
                speed * Time.deltaTime);

            if (transform.position == waypoints[WPIndex].transform.position)
            {
                WPIndex += 1;
            }
        }
        if(MoveSpace > (waypoints.Length-WPIndex)){
            transform.position = Vector2.MoveTowards
                (transform.position,
                waypoints[(waypoints.Length - (MoveSpace - waypoints.Length-WPIndex))].transform.position,
                speed * Time.deltaTime);
            
            if (transform.position == waypoints[WPIndex].transform.position)
            {
                WPIndex += 1;
            }
        }       
        
    }
}
