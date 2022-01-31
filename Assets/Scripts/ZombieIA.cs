using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieIA : MonoBehaviour
{

    public GameObject Player;
    public float enemySpeed = 0.03f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public AudioSource zombieNoise1;
    public AudioSource zombieNoise2;
    public int randomNumber;
    public int randomNumber2;
    public int randomNumber3;
    
    void Update()
    {
        transform.LookAt (Player.transform);
        if (attackTrigger == false)
        {
            
            this.GetComponent<Animation>().Play("Z_Walk");
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, enemySpeed);
        }

        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            this.GetComponent<Animation>().Play("Z_Attack");
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter(){
        attackTrigger = true;
    }

    void OnTriggerExit(){
        attackTrigger = false;
    }

    IEnumerator MakeNoise(){
        randomNumber2 = Random.Range(1,3);
        randomNumber3 = Random.Range(3,10);
         if (randomNumber == 1){
            zombieNoise1.Play();
        } else if (randomNumber == 2){
            zombieNoise2.Play();
        }
        yield return new WaitForSeconds(randomNumber3);
    }

    IEnumerator InflictDamage(){
        isAttacking = true;
        randomNumber = Random.Range(1,4);
        if (randomNumber == 1){
            hurtSound1.Play();
        } else if (randomNumber == 2){
            hurtSound2.Play();
        } else if (randomNumber == 3){
            hurtSound3.Play();
        }
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;
        yield return new WaitForSeconds (0.3f);
        isAttacking = false;
    }
}
