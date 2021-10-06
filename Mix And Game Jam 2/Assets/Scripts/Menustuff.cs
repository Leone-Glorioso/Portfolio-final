using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menustuff : MonoBehaviour
{
    public Animator animator;
    public void MainMenu()
    {
        StartCoroutine(ChangingScenes());
    }
    public void Quit()
    {
        Application.Quit();
    }
    IEnumerator ChangingScenes()
    {
        animator.SetTrigger("Change");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
