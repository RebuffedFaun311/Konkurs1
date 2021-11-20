using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaner : MonoBehaviour
{
    public GameObject ScanerTrigger;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            ScanerTrigger.SetActive (true);
        } 
         if (Input.GetMouseButtonUp(0)) 
        {
            ScanerTrigger.SetActive (false);
        } 
    }
}
