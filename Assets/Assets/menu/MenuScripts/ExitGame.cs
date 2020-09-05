using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {

    }



// Update is called once per frame
void Update()
    {
        System.Threading.Thread.Sleep(2000); 
        quit();
    }
}
