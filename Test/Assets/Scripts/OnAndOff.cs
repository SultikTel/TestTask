using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAndOff : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnOrOff()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void Write()
    {
        Debug.Log("fd");
    }

    // Update is called once per frame

}
