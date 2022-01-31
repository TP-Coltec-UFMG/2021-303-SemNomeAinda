using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{

    public AudioSource DoorSlam;
    public AudioSource JumpScareMusic;
    public GameObject Zombie;
    public GameObject Door;

    void OnTriggerEnter () 
    {
        // Desativa o trigger para ele não ficar ativando pra sempre
        GetComponent<BoxCollider>().enabled = false;

        Door.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorSlam.Play();
        Zombie.SetActive(true);
        StartCoroutine(PlayJumpScareMusic());
    }

    IEnumerator PlayJumpScareMusic() 
    {
        yield return new WaitForSeconds(0.4f);
        JumpScareMusic.Play(); 
    }
}
