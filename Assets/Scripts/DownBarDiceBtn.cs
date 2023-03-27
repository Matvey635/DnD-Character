using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DownBarDiceBtn : MonoBehaviour
{
    public void LoadMainMenu()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(0);
    }
}
