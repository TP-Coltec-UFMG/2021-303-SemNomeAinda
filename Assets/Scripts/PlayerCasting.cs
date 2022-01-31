using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    public static float DistanceFromTarget;
    // Variaveis static não podem ser vistas no Inspector, por isso tem uma "copia" que pode ser vista
    public float ToTarget;
    
    
    void Update()
    {
        RaycastHit Hit;
        // Physics.Raycast lança um raio e retorna true se esse raio colidir com um Collider

        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Hit)) {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}
