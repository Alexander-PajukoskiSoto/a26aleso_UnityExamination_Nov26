using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public string levelToChange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeToGameScene()
    {
        SceneManager.LoadScene(levelToChange);
    }
}
