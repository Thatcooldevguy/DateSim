using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    TextMeshProUGUI text;

    //button texts
    string play = "Play!";
    string settings = "Settings";
    string back = "Back";


    // Start is called before the first frame update
    void Start() {
        text = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        // Debug.Log(text.text);
        if (text.text == play) {
            MainMenu();
        }
        if (text.text == back) {
            PreviousScene();
        }
    }
    void MainMenu() {
        SceneManager.LoadScene("mainMenu");
    }
    void PreviousScene() {
        SceneManager.LoadScene("mainMenuPre");
    }
}
