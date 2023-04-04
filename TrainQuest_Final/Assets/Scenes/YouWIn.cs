using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWIn : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene("StartGame");
    }
}
