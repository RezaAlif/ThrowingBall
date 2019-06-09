using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour {
    public Transform Ball;
    Camera mainCamera;
    public float maximum;

	// Use this for initialization
	void Start () {
        mainCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Ball.position.y >= maximum)
        {
            mainCamera.fieldOfView = 30 + Ball.position.y - (maximum * 0.5f) * 2f;
            transform.position = new Vector3(transform.position.x, Ball.position.y - 2.17f, transform.position.z);
        }
        else
        {
            mainCamera.fieldOfView = 30;
        }
	}
}
