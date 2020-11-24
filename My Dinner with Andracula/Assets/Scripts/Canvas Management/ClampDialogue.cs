using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampDialogue : MonoBehaviour
{
    public Button choiceLabel;

    // Update is called once per frame
    void Update()
    {
        Vector3 buttonPos = Camera.main.WorldToScreenPoint(this.transform.position);
        choiceLabel.transform.position = buttonPos;
    }
}
