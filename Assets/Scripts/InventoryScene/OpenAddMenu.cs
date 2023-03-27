using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAddMenu : MonoBehaviour
{
    public GameObject AddMenu;

    public void Open()
    {
        AddMenu.SetActive(true);
    }
}
