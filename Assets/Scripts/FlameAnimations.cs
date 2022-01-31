using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{   

    public int LightMode;
    public GameObject FlameLight;
    
    void Update()
    {
        // Se não tiver nenhuma animação tocando
        if (LightMode == 0) {
			StartCoroutine (AnimateLight ());
		}
		
    }
    /* 
    A função AnimateLight é uma Corotina, pois ela deve ser executada ao longo de vários frames. Caso fosse uma função comum dentro de 
        Update(), ela teria que terminar sua execução em 1 frame
    */

    // O IEnumerator é necessário pra Corotina, pq aparentemente Void não pode executar algo como WaitForSeconds
    IEnumerator AnimateLight () {
        // Seleciona uma animação aleatória para ser executada
		LightMode = Random.Range (1, 4);
		if (LightMode == 1) {
			FlameLight.GetComponent<Animation> ().Play ("TorchAnim1");
		}
		if (LightMode == 2) {
			FlameLight.GetComponent<Animation> ().Play ("TorchAnim2");
		}
		if (LightMode == 3) {
			FlameLight.GetComponent<Animation> ().Play ("TorchAnim3");
		}
        // Esperando o tempo da animação terminar
		yield return new WaitForSeconds (0.99f);
		LightMode = 0;

	}
}
