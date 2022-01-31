using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;


public class FindWeapon : MonoBehaviour
{
   public GameObject Arrow;
    public GameObject Player;
    public GameObject TextBox;

    void OnTriggerEnter()
    {
        StartCoroutine (Cutscene ());
    }

    IEnumerator Cutscene () {
        TextBox.GetComponent<Text>().text = "Parece que tem uma arma naquela mesa";
        yield return new WaitForSeconds (2.5f);
        
        TextBox.GetComponent<Text>().text = "";
        Arrow.SetActive (true);
    }
}
