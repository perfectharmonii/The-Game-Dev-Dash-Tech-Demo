using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperEXPObtained : MonoBehaviour
{
    public Image DeveloperEXPPiece;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            DeveloperEXPPiece.GetComponent<Image>().color = Color.green;
        }
    }
}
