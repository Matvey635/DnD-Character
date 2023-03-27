using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentObjHeightsSetter : MonoBehaviour
{
    public GameObject WeaponPanel;

    public void SetHeight()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2( GetComponent<RectTransform>().sizeDelta[0], WeaponPanel.GetComponent<RectTransform>().sizeDelta[1] + 290 );
    }
}
