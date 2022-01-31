using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /**
     * 
     */
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }


    /*
     * Nao funciona durante o runtime dentro do editor
     * mas fora funciona (no caso se buildarmos o executavel) -> CONFIA!
     */
    public void QuitGame()
    {
        Debug.Log("SAIU DESSA PORRA DESSE JOGO!");
        Application.Quit();
    }
}
