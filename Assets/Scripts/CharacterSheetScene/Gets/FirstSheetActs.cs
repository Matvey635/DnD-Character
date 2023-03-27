using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSheetActs : MonoBehaviour
{
    public GameObject GetSheetName;
    public GameObject GetSheetClass;
    public GameObject GetSheetKD;
    public GameObject GetSheetHP;

    public GameObject GetSheetXP;

    public void ActName()
    {
        GetSheetName.SetActive(true);
    }

    public void ActClass()
    {
        GetSheetClass.SetActive(true);
    } 

    public void ActKD()
    {
        GetSheetKD.SetActive(true);
    }

    public void ActHP()
    {
        GetSheetHP.SetActive(true);
    } 

    public void ActXP()
    {
        GetSheetXP.SetActive(true);
    } 
}
