using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideScript : MonoBehaviour
{
    
    private void  OnTriggerEnter2D(Collider2D other)
    {
      
        if(other.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
           // Destroy(gameObject);
            
        }
    }
}
