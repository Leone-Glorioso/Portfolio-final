using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakeAbility : MonoBehaviour
{
    public Animator animator;
  public UnityEngine.Experimental.Rendering.Universal.Light2D SUN;
  public Transform lighting;
  public float hp;
  public float hpf;
  public bool HasNotEnded = true;
  public Animator anima;
 // public GameObject UKI;

    void Start()
   {
       SUN = lighting.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
       
   }
   
    void Update()
    {
       if(HasNotEnded == true)
       {
            hpf = Mathf.Clamp(hp, 0f, 1f);
        if(hpf == 1f)
        {
           // UKI.SetActive(true);
            anima.SetBool("Transition", true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                
                SUN.intensity = 1f;
                animator.SetTrigger("Effect");
                hp = 0f;
              //  yield return new WaitForSeconds(1);
            }
        }
        else
        {
           // UKI.SetActive(false);
            anima.SetBool("Transition", false);
            SUN.intensity = 0.05f;
            hp += 0.1f * Time.deltaTime;
        }}
    

        
    }

}