using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanerHit : MonoBehaviour
{

    public Scaner scan;

    Kamen nowkam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "kamni"){
            nowkam = other.gameObject.GetComponent<Kamen>();
            scan.InfoUpdate(nowkam);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "kamni"){
            nowkam = null;
            scan.InfoHide();
        }
    }
}
