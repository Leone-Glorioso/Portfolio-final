using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
public GameObject enemy;

private void OnTriggerEnter2D(Collider2D other)
{
    if(other.tag == "Player")
    {
        enemy.GetComponent<EnemyScript5>().isFollowing = true;
    }
}
}
