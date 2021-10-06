using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript5 : MonoBehaviour
{
    public bool isFollowing = false;
    public Transform player;
    public float TimeToGo;
   private float TimeElapsed;
   private float score;
    public int MoveByX;
    public int MoveByY;
    
    void Update()
    {
        if(isFollowing == true)
        {
            StartFollowing();
        }
        
    }
    void StartFollowing()
    {
    if(player != null){
    if(transform.position.x != player.position.x)
    {
    if(TimeElapsed > TimeToGo)
    {
        if(transform.position.x > player.position.x)
        {
            transform.position += new Vector3(-MoveByX, 0, 0);
        }
        if(transform.position.x < player.position.x)
        {
            transform.position += new Vector3(MoveByX, 0, 0);
        }  
      score = Time.time; 
      TimeElapsed = 0f;
    }
    else
    {
        TimeElapsed = Time.time - score;
    }
    }
       else if(transform.position.x == player.position.x)
        {
         if(transform.position.y != player.position.y)
            {
            if(TimeElapsed > TimeToGo)
            {
            if(transform.position.y > player.position.y)
            {
                transform.position += new Vector3(0, -MoveByY, 0);
            }
            if(transform.position.y < player.position.y)
            {
                transform.position += new Vector3(0, MoveByY, 0);
            } 
            score = Time.time; 
            TimeElapsed = 0f;
            }
            else
            {
            TimeElapsed = Time.time - score;
            }
            }
        }

        }
    }
}
