using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetHandlers : MonoBehaviour
{
    public MoveTrain myTrain;
    // Start is called before the first frame update
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
    }
}
