using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustFontSize : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject ActionKey;
    public GameObject ActionText;
    public bool highVisibility = false;
    
    
    void Start()
    {
        TextBox.GetComponent<Text>().fontSize = (int)(teste.FontSize/2);
        ActionKey.GetComponent<Text>().fontSize = (int)(teste.FontSize/2);
        ActionText.GetComponent<Text>().fontSize = (int)(teste.FontSize/2);
    }

   void setHighVisibility(){
       highVisibility = true;
   }
}
