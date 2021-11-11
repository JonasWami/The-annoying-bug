using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Near_humans : MonoBehaviour
{
    public Timebar timebar;

    public Fly fly;

  [HideInInspector] public bool corutine_is_active;

    private void Start()
    {
        timebar = FindObjectOfType<Timebar>();
        fly = GetComponent<Fly>();
    }

    IEnumerator loosetime()
    {
        

        while(corutine_is_active)
        {
            yield return new WaitForSeconds(0.1f);
            timebar.LooseTime(5);
            
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Human area" && fly.IsStandingStill == true)
        {
            corutine_is_active = true;
            StartCoroutine(loosetime());

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Human area")
        {
            corutine_is_active = false;
        }
       
    }

}
