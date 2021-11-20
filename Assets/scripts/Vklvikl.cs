using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vklvikl : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Image1.SetActive(false);
            Image2.SetActive(false);

        }
    }
}
