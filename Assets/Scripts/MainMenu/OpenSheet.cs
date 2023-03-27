using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSheet : MonoBehaviour
{
    public void OpenNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
