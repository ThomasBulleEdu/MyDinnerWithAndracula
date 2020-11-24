
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampNonButton : MonoBehaviour
{
    public GameObject clampable;

    // Update is called once per frame
    void Update()
    {
        Vector3 buttonPos = Camera.main.WorldToScreenPoint(this.transform.position);
        clampable.transform.position = buttonPos;
    }
}
