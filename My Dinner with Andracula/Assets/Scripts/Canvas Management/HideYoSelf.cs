using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideYoSelf : MonoBehaviour
{
    public GameObject selfUr;

    void HideUrSelf()
    {
        selfUr.SetActive(false);
    }
}
