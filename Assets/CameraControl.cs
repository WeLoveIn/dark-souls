using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	private GameObject playerHandle;
	private GameObject cameraHandle;
	public PlayerInput pi;
	// Use this for initialization
	void Awake () {
		
		cameraHandle = transform.parent.gameObject;
		playerHandle = cameraHandle.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
