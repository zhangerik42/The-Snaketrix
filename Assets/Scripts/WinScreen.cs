using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
  public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
