using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Vector3 originPos, targetPos;
  public bool isMoving;
  private float TimeToMove = 0.2f;
  public Transform light; 
  public Animator animator;
 // private float TimeLimit = 2f;
    void Update()
    {
        animator.SetBool("Running", isMoving);
        //TimeLimit -= Time.time;
        if(Input.GetKeyDown(KeyCode.W) && !isMoving )
        {
            StartCoroutine(MovePlayer(Vector3.up));
            light.rotation = Quaternion.Euler(0f,0f,0f);
           // TimeLimit = 2f;
        }
         if(Input.GetKeyDown(KeyCode.A) && !isMoving )
        {
            StartCoroutine(MovePlayer(Vector3.left));
            light.rotation = Quaternion.Euler(0f,0f,90f);
           // TimeLimit = 2f;
        }
         if(Input.GetKeyDown(KeyCode.S) && !isMoving )
        {
            StartCoroutine(MovePlayer(Vector3.down));
            light.rotation = Quaternion.Euler(0f,0f,180f);
           // TimeLimit = 2f;
        }
         if(Input.GetKeyDown(KeyCode.D) && !isMoving )
        {
            StartCoroutine(MovePlayer(Vector3.right));
            light.rotation = Quaternion.Euler(0f,0f,270f);
           // TimeLimit = 2f;
        }
        
    }

    IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedtime = 0f;
        originPos = transform.position;
        targetPos = originPos + direction;

        while(elapsedtime < TimeToMove)
        {
            transform.position = Vector3.Lerp(originPos, targetPos, (elapsedtime / TimeToMove));
            elapsedtime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }
}
