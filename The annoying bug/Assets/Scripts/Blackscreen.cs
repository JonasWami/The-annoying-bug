using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blackscreen : MonoBehaviour
{
   [SerializeField] int death;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loader", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loader()
    {
        SceneManager.LoadScene(death);
    }
}
