using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public Button restart;
    // Start is called before the first frame update
    void Start()
    {
        restart.onClick.AddListener(restartClick);
    }

    void restartClick()
    {
        SceneManager.LoadScene("IntroMenu");
    }
}
