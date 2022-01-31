using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWeapon : MonoBehaviour
{
    
    public float Distance;
    // UI que mostra qual tecla apertar
    public GameObject ActionKey;
    // UI que mostra qual ação será feita
    public GameObject ActionText;
    // UI crosshair
    public GameObject ExtraCrosshair;

    // É a arma que aparece no mapa
    public GameObject FakePistol;
    // É a arma que o jogador utilizará
    public GameObject RealPistol;
    public GameObject Arrow;
    public GameObject JumpScareTrigger;
    

    void Update()
    {
		Distance = PlayerCasting.DistanceFromTarget;
   
    }

    // É executado quando passamos o mouse sobre o objeto no qual esse script está acoplado
    void OnMouseOver () {
        // Checa se o player está a uma distância razoavel da arma
		if (Distance <= 2) {
            ExtraCrosshair.SetActive (true);
			ActionKey.SetActive (true);
            ActionText.GetComponent<Text>().text = "Pegar a arma";
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown("Action")) {
			if (Distance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionKey.SetActive(false);
				ActionText.SetActive(false);
                ExtraCrosshair.SetActive (false);
                Arrow.SetActive(false);

                // Desativa a arma do mapa e ativa a arma na mão do Player
				FakePistol.SetActive (false);
                RealPistol.SetActive (true);

                // Ativa o trigger do jumpscare
                JumpScareTrigger.SetActive(true);
			}
		}
         if (Distance >= 2)
        {
            ActionKey.SetActive(false);
            ActionText.SetActive(false);
            ExtraCrosshair.SetActive (false);

        }

	}

    // É executado quando o mouse sai de cima do objeto no qual o script esta acoplado
	void OnMouseExit() {
		ActionKey.SetActive (false);
		ActionText.SetActive (false);
        ExtraCrosshair.SetActive (false);
	}
}
