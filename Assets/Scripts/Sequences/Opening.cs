using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Opening : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    void Start()
    {
        // Desativa os movimentos do player durante a cena
        Player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(Cutscene ());
        

    }

    IEnumerator Cutscene () {
        yield return new WaitForSeconds (2);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "Preciso sair daqui.";
        yield return new WaitForSeconds (2);
        TextBox.GetComponent<Text>().text = "";
         Player.GetComponent<FirstPersonController>().enabled = true;
    }


}
