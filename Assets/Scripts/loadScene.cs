using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
  public  void loadTwoScene()
    {
        SceneManager.LoadScene("Two players");
    }
   public void loadBotScene()
    {
        SceneManager.LoadScene("Single player");
    }
  public  void loadSecretScene()
    {
        SceneManager.LoadScene("Secret mode");
    }

}
