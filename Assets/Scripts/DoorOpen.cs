using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    
    public float Distance;
    // UI que mostra qual tecla apertar
    public GameObject ActionKey;
    // UI que mostra qual ação será feita
    public GameObject ActionText;
    // UI crosshair
    public GameObject ExtraCrosshair;
    public GameObject Door;
    public AudioSource CreakSound;

    void Start()
    {

    }

    void Update()
    {
		Distance = PlayerCasting.DistanceFromTarget;
   
    }

    // É executado quando passamos o mouse sobre o objeto no qual esse script está acoplado
    void OnMouseOver () {
        // Checa se o player está a uma distância razoavel da porta
		if (Distance <= 2) {
			ActionKey.SetActive (true);
			ActionText.SetActive (true);
            ExtraCrosshair.SetActive (true);
		}
		if (Input.GetButtonDown("Action")) {
			if (Distance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionKey.SetActive(false);
				ActionText.SetActive(false);
                ExtraCrosshair.SetActive (false);
				Door.GetComponent<Animation> ().Play ("FirstDoorOpenAnim");
				CreakSound.Play ();
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
