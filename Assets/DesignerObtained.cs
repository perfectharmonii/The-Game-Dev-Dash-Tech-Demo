using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesignerObtained : MonoBehaviour
{
    public Image DesignerPiece;

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            DesignerPiece.GetComponent<Image>().color = Color.green;
        }
    }
}
