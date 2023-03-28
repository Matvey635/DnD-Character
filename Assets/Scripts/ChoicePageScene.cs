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

    public void OpenPet()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(3);
    }

    public void OpenSpell()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(4);
    }

    public void OpenBio()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(5);
    }

    public void OpenNotes()
    {
        DataManager.DM.SaveData();
        SceneManager.LoadScene(6);
    }
}
