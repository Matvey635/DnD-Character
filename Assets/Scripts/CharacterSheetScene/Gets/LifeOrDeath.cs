using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeOrDeath : MonoBehaviour
{
    public void SetL()
    {
        if (GetComponent<Image>().color == new Color32(78, 204, 163, 255))
        {
            GetComponent<Image>().color = new Color32(238, 238, 238, 255);
        }
        else {
            GetComponent<Image>().color = new Color32(78, 204, 163, 255);
        }
    }

    public void SetD()
    {
        if (GetComponent<Image>().color == new Color32(227, 38, 54, 255))
        {
            GetComponent<Image>().color = new Color32(238, 238, 238, 255);
        }
        else {
            GetComponent<Image>().color = new Color32(227, 38, 54, 255);
        }
    }
}
