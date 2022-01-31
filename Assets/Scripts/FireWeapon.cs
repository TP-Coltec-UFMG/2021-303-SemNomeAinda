using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject MuzzleFlash;
    public AudioSource FireWeaponSound;
    public bool isFiring = false;
    public float FireRate = 1f;
    public float TargetDistance;
    public int DamageAmount = 5;

    void Update()
    {   
        
        if (Input.GetButtonDown("Fire1")) 
        {
            if (!isFiring) {
                StartCoroutine(FiringWeapon());
            }
        }
    }

    IEnumerator FiringWeapon() 
    {
        RaycastHit Shot;
        isFiring = true;

        if (Physics.Raycast(transform.position, transform.TransformDirection (Vector3.forward), out Shot)) 
        {
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage ("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }

        Weapon.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleFlashAnim");
        

        FireWeaponSound.Play();
        yield return new WaitForSeconds(FireRate);
        isFiring = false;
    }
}
