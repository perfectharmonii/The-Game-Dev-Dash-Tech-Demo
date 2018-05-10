using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperObtained : MonoBehaviour {

    public Image DeveloperPiece;

	void Update()
    {
        if (Input.GetKey(KeyCode.Keypad2))
        {
            DeveloperPiece.GetComponent<Image>().color = Color.green;
        }
    }
}
