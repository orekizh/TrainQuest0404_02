using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRound4 : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameRound5");
    }
}
