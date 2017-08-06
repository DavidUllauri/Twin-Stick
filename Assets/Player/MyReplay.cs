using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public struct MyKeyFrame {

    private float time;         // The time we are storing this event
    private Vector3 position;
    private Quaternion rotation;

    public MyKeyFrame(float time, Vector3 position, Quaternion rotation) {
        this.time = time;
        this.position = position;
        this.rotation = rotation;
    }
}
