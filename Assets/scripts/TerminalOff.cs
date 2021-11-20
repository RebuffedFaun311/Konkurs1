using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalOff : MonoBehaviour
{
    public GameObject Basa;
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            Basa.SetActive (false);
        }
    }
}
