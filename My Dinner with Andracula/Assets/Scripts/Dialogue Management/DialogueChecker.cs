using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueChecker : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string hitName; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));
            Vector3 direction = worldMousePosition - Camera.main.transform.position;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                Debug.Log("You selected the " + hit.transform.name);
                hitName = hit.transform.name;
                
            }
        }
    }
}
