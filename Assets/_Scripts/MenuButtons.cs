using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
