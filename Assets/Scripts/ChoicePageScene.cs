using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoicePageScene : MonoBehaviour
{
    public void OpenStats()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(1);
    }

    public void OpenInventory()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(2);
    }
}
