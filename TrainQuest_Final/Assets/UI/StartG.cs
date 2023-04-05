using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartG : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("TrainQuest_Final");
    }
}
