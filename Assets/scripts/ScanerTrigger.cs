using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanerTrigger : MonoBehaviour
{
    public GameObject TestUI1;
    public GameObject TestUI2;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Test")
        {
            TestUI1.SetActive (true);
        }
        if(other.tag == "Test1")
        {
            TestUI2.SetActive (true);
        }
    }
}
