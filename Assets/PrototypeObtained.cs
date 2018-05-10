using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrototypeObtained : MonoBehaviour
{
    public Image PrototypePiece;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad3))
        {
            PrototypePiece.GetComponent<Image>().color = Color.green;
        }
    }
}
