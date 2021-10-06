using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public GameObject activeUI;
   public bool GameIsPaused;
   public Animator animator;
//    public GameObject UiC;

 void Update()
 {
     if(Input.GetKeyDown(KeyCode.Escape))
     {
         
     if(!GameIsPaused)
     {
         Pause();
     }
     else
     {
         Resume();
     }
     }
 } 
 public void Pause()
 {
     activeUI.SetActive(true);
     Time.timeScale = 0f;
     GameIsPaused = true;
 }
  public void Resume()
 {
     activeUI.SetActive(false);
     Time.timeScale = 1f;
     GameIsPaused = false;
 }
 public void Mains()
 {
     SceneManager.LoadScene(0);
 }
 public void Quit()
 {
     Application.Quit();
     Debug.Log("Quit");
 }
 public void Next()
 {
     animator.SetTrigger("Change");
    // yield return new WaitForSeconds(1);
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     Time.timeScale = 1f;
    //  StartCoroutine(Action());
    // animator.SetTrigger("Change");
    // UiC.SetActive(true);
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
//  IEnumerator Action()
//  {
//       UiC.SetActive(true);
//      animator.SetTrigger("Change");
//      yield return new WaitForSeconds(1);
//      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//  }
}
