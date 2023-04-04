using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRound2 : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameRound3");
    }
}
