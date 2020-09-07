using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneBackScript : MonoBehaviour
{
    void Start() {
        MainMenu();
    }
    void MainMenu() {
        SceneManager.LoadScene("mainMenuPre");
    }
}
