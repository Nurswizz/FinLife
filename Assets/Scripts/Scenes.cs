using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void goToLevel()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("NextMenu");
    }
}
