using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detected : MonoBehaviour {
    public int timeUntilDetected = 5;
    public int lookedAtCounter = 0;
    private float lastSeen;
    private int timeUntilReset = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lastSeen + timeUntilReset)
        {
            lookedAtCounter = 0;
        }
	}

    public void detected()
    {
        if (lookedAtCounter >= timeUntilDetected)
        {
            Destroy(gameObject);
        }
        else
        {
            lastSeen = Time.time;
            lookedAtCounter += 1;
        }
        
    }
}
