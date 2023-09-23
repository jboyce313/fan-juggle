using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameLogic : MonoBehaviour
{
    public void StartGame()
    {
        Score.balls = 0;
        SceneManager.LoadScene(0);
    }
}
