using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetHandlers : MonoBehaviour
{
    public MoveTrain myTrain;
    // Start is called before the first frame update
    public GameObject Panel_1,Panel_2,Panel_3,Panel_4,Panel_5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetFound()
    {
        ObserverBehaviour observerBehaviour = GetComponent<ObserverBehaviour>();

        string targetName = observerBehaviour.TargetName;
        myTrain.target = observerBehaviour.transform.position;
        myTrain.move = true;
        Debug.Log("Image Target"+targetName+"found at position"+myTrain.target);
        if (targetName == "Track1") 
            Panel_1.SetActive(true);
        if (targetName == "Track2") 
            Panel_2.SetActive(true);
        if (targetName == "Track3") 
            Panel_3.SetActive(true);
        if (targetName == "Track4") 
            Panel_4.SetActive(true);
        if (targetName == "Track5") 
            Panel_5.SetActive(true);

    }
}
