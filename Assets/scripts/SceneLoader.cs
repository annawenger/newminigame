using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    enum Scenes { Start, Main, GameOver, Won };

    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene((int)Scenes.Start);
    }

    public void LoadMainGameScene()
    {
        SceneManager.LoadScene((int)Scenes.Main);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOver);
    }

    public void LoadWonScene()
    {
        SceneManager.LoadScene((int)Scenes.GameOver);
    }
}
