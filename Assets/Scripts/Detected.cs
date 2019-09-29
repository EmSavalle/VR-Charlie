using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detected : MonoBehaviour {
    public int timeUntilDetected = 5;
    public int lookedAtCounter = 0;
    private float lastSeen;
    private int timeUntilReset = 3;
    public Material m1;
    public Material m2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lastSeen + timeUntilReset)
        {
            lookedAtCounter = 0;
            gameObject.GetComponent<MeshRenderer>().material = m1;
        }

    }

    public void detected()
    {
        lastSeen = Time.time;
        lookedAtCounter += 1;
        gameObject.GetComponent<MeshRenderer>().material = m2;
    }
}
