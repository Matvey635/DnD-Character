using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdSheetActs : MonoBehaviour
{
    public GameObject GetSheetInitiative;
    public GameObject GetSheetSpeed;
    public GameObject GetSheetAllHits;
    public GameObject GetSheetHitsLost;


    public void ActInitiative()
    {
        GetSheetInitiative.SetActive(true);
    }

    public void ActSpeed()
    {
        GetSheetSpeed.SetActive(true);
    } 

    public void ActAH()
    {
        GetSheetAllHits.SetActive(true);
    } 

    public void ActLH()
    {
        GetSheetHitsLost.SetActive(true);
    } 
}
