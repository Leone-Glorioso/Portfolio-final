using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour
{
 //  public Transform target;
   public float WaitingSec;
   public float MoveByX;
   public float MoveByY;
   public float TimeToGo;
   private float TimeElapsed;
   private float score;
    // void Start()
    // {
    //   Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();  
    // }

    
    void Update()
    {
    if(TimeElapsed > TimeToGo)
    {
      transform.position += new Vector3(MoveByX, MoveByY, 0); 
      score = Time.time; 
      TimeElapsed = 0f;
    }
    else
    {
        TimeElapsed = Time.time - score;
    }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Wall")
        {
            MoveByX = -MoveByX;
            MoveByY = -MoveByY;
        }
    }

    // IEnumerator EnemyMoveP1()
    // {
    //     transform.position += new Vector3(0, MoveBy, 0);
    //     yield return new WaitForSeconds(WaitingSec);
    // }
}
