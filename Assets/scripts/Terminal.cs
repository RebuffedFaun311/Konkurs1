using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    public GameObject Test;
    public GameObject Test1;
    public GameObject TestUI;
    public GameObject TestUI2;
    public GameObject Basa;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Test")
        {
            TestUI.SetActive (true);
            Basa.SetActive (true);
            Destroy(Test);

        }
        if(other.tag == "Test1")
        {
            TestUI2.SetActive (true);
            Basa.SetActive (true);
            Destroy(Test1);

        }
    }
}
