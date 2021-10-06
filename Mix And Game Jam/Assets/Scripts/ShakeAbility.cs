using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeAbility : MonoBehaviour
{
  public Animator animator;
  public UnityEngine.Experimental.Rendering.Universal.Light2D SUN;
  public Transform lighting;
  public float hp;
  public float hpf;

    void Start()
   {
       SUN = lighting.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
       
   }
   
    void Update()
    {
        hpf = Mathf.Clamp(hp, 0f, 1f);
        if(hpf == 1f)
        {
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
            SUN.intensity = 0.2f;
            hp += 0.1f * Time.deltaTime;
        }
        

        
    }
}
