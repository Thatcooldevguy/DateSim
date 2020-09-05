using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MasterButtons : MonoBehaviour
{
    public Button myButton;
    public static void changeToMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    // Start is called before the first frame update
    void start()
    {
       //  myButton.addHandler(() => { changeToMenu(); });
    }

  



    // Update is called once per frame
    void Update()
    {

    }
}
