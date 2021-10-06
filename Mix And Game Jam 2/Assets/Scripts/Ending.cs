using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    //public Animator animator;
     public GameObject qMenu; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            // qMenu.SetActive(true);
        //    StartCoroutine(SceneEnded());
           qMenu.SetActive(true);
           Time.timeScale = 0f;
        }
    }

    // IEnumerator SceneEnded()
    // {
    //     animator.SetTrigger("Change");
    //     yield return new WaitForSeconds(1);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    // public void Ending()
    // {
    //     animator.SetTrigger("Change");
    //     yield return new WaitForSeconds(1);
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

}
