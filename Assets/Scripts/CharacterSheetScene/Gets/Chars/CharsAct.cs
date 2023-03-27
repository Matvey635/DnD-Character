using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharsAct : MonoBehaviour
{
    public GameObject GetSheetStr;
    public GameObject GetSheetDex;
    public GameObject GetSheetCon;
    public GameObject GetSheetInt;
    public GameObject GetSheetWis;
    public GameObject GetSheetCha;


    public void ActStr()
    {
        GetSheetStr.SetActive(true);
    }

    public void ActDex()
    {
        GetSheetDex.SetActive(true);
    }

    public void ActCon()
    {
        GetSheetCon.SetActive(true);
    }

    public void ActInt()
    {
        GetSheetInt.SetActive(true);
    }

    public void ActWis()
    {
        GetSheetWis.SetActive(true);
    }

    public void ActCha()
    {
        GetSheetCha.SetActive(true);
    }
}
