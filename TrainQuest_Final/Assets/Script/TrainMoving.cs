using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMoving : MonoBehaviour
{
    public GameObject target;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(move==true)
        transform.position = Vector3.MoveTowards(transform.position,
        target.transform.position,0.15f*Time.deltaTime);
        
    }
    public void TargetFound()
    {
        Debug.Log("First turn!");
        move = true;
    }
}
