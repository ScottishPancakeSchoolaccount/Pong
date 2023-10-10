using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    void loadTwoScene()
    {
        SceneManager.LoadScene("pong basic");
    }
    void loadBotScene()
    {
        SceneManager.LoadScene("pong bot");
    }

}
