using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Near_humans : MonoBehaviour
{
    public Timebar timebar;
    public Annoyedbar_script annoyedbar;

    public Fly fly;
    public Collider flycollider;
  [HideInInspector] public bool IsInArea;
  [HideInInspector] public bool corutine_is_active;
    

    private void Start()
    {
        flycollider = GetComponent<Collider>();
        annoyedbar = FindObjectOfType<Annoyedbar_script>();
        timebar = FindObjectOfType<Timebar>();
        fly = GetComponent<Fly>();
    }

    IEnumerator loosetime()
    {
        

        while(corutine_is_active)
        {
            yield return new WaitForSeconds(0.05f);
            timebar.LooseTime(1.5f);
            
        }

       
    }

    IEnumerator Gain()
    {
        while(IsInArea)
        {
            yield return new WaitForSeconds(0.05f);
            annoyedbar.Gain(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Human area")
        {
            if(fly.IsStandingStill)
            {
                corutine_is_active = true;
                StartCoroutine(loosetime());
            }
            

            IsInArea = true;
            StartCoroutine(Gain());
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Human area")
        {
            corutine_is_active = false;
            IsInArea = false;
        }
       
    }
   

}
