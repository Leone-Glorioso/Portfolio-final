using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideScript : MonoBehaviour
{
    public Transform glight;
    public UnityEngine.Experimental.Rendering.Universal.Light2D light;
   // public GameObject lMenu;
    void Start()
    {
        light = glight.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }
    private void  OnTriggerEnter2D(Collider2D other)
    {
      
        if(other.tag == "enemy")
        {
            transform.GetComponent<ShakeAbility>().HasNotEnded = false;
            light.intensity = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
           // Destroy(gameObject);
            
        }
    }
}
