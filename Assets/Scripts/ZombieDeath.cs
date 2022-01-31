using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour {

    public int EnemyHealth = 20;
    public GameObject Enemy;
    // O objetivo dessa variavel é parar de checar a vida do zumbi se ele estiver morto
    public bool isAlive = true;
    public AudioSource JumpScareMusic;

    void DamageZombie (int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update () {
		if (EnemyHealth <= 0 && isAlive)
        {
            this.GetComponent<ZombieIA>().enabled = false;
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            this.GetComponent<BoxCollider>().enabled = false;
            
            isAlive = false;
            Enemy.GetComponent<Animation>().Stop("Z_Walk");
            Enemy.GetComponent<Animation>().Play("Z_FallingBack");
            JumpScareMusic.Stop();
        }
	}
}