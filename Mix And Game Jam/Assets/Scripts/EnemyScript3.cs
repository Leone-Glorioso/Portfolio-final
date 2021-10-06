using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript3 : MonoBehaviour
{
    
   public float TimeToGo;
   public int MaxX;
   public int MaxY;
   private float TimeElapsed;
   private float score;
   public Animator animator; 

    
    void Update()
    {
    if(TimeElapsed > TimeToGo)
    {

      float x = Random.Range(-MaxX, MaxX) + 0.5f;
      float y = Random.Range(-MaxY,MaxY) + 0.5f;
      transform.position = new Vector3( x, y, 0); 
      score = Time.time; 
      TimeElapsed = 0f;
      animator.SetTrigger("Transport");
    }
    else
    {
        TimeElapsed = Time.time - score;
    }
       
    }
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.tag == "Wall")
    //     {
    //         MoveByX = -MoveByX;
    //         MoveByY = -MoveByY;
    //     }
    // }
}
