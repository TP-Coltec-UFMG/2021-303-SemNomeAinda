using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public void Start(){
       StartCoroutine(backToMenu());
       
   }
   IEnumerator backToMenu(){
       yield return new WaitForSeconds(3);
       SceneManager.LoadScene("Menu");
   }
}
