using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaner : MonoBehaviour
{
    public GameObject ScanerTrigger;


    public Text Table_name;
    public Text Table_massa;
    public Text Table_molmassa;
    public Text Table_kolElectronv;
    public Text Table_kolProtonov;
    public Text Table_kolNetronov;

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


    public void InfoUpdate(Kamen kam){
        Table_name.text = kam.name;
        Table_massa.text = kam.massa;
        Table_molmassa.text = kam.molmassa;
        Table_kolElectronv.text = kam.kolElectronv ;
        Table_kolProtonov.text = kam.kolProtonov;
        Table_kolNetronov.text = kam.kolNetronov;
    }

    public void InfoHide(){
        Table_name.text = "-";
        Table_massa.text = "-";
        Table_molmassa.text = "-";
        Table_kolElectronv.text =  "-";
        Table_kolProtonov.text = "-";
        Table_kolNetronov.text = "-";
    }
}
