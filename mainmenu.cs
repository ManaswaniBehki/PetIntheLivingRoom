using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Finish");
    }

    public void StartGame() {
        SceneManager.LoadScene("floo");
    }
}
