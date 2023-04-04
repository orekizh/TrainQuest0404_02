using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;
using Vuforia;

public class MoveTrain : MonoBehaviour
{

    public Vector3 target;
    public bool move = false;
    public int count;
    public TextMeshProUGUI countUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
            transform.position = Vector3.MoveTowards(transform.position,
                target, 0.1f * Time.deltaTime);
        countUI.text = count.ToString();
    }
    public void TargetFound()
    {
        move = true;
    }
    public void PlusOne()
    {
        count = count + 1;
    }
    public void PlusTwo()
    {
        count = count + 2;

    }
    public void PlusThree()
    {
        count = count + 3;

    }
    public void MinOne()
    {
        count = count - 1;
    }
    public void MinTwo()
    {
        count = count - 2;
    }
    public void MinThree()
    {

        count = count - 3;
    }
    public void Double()
    {
        count = count + 6;
    }

}
