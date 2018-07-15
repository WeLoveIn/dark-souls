using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
	[Header("----- Key settings -----")]
public string keyUp;
public string keyDown;
public string keyLeft;
public string keyRight;
public string keyA;
public string keyB;
public string keyC;
public string keyD;
	[Header("----- Output singals -----")]
public float Dup;
public float Dmag;
public float Dright;
private float targetDup;
private float targetDright;
public Vector3 Dvec;
public bool runEnable;
public bool jump;

	[Header("----- Others -----")]
private float velocityDup;
private float velocityDright;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		runEnable = Input.GetKey(keyA);
		targetDup = (Input.GetKey(keyUp)? 1.0f:0) - (Input.GetKey(keyDown)? 1.0f:0);
		targetDright = (Input.GetKey(keyRight)? 1.0f:0) - (Input.GetKey(keyLeft)? 1.0f:0);
		Dup = Mathf.SmoothDamp(Dup,targetDup,ref velocityDup,.1f);
		Dright = Mathf.SmoothDamp(Dright,targetDright,ref velocityDright,.1f);
		Vector2 targetVec2 = SquareToCircle(new Vector2(Dright,Dup));
		float Dupn = targetVec2.y;
		float Drightn = targetVec2.x;
		Dmag = Mathf.Sqrt(Dupn * Dupn + Drightn * Drightn);
		Dvec =Drightn * transform.right + Dupn * transform.forward;
	}
	private Vector2 SquareToCircle(Vector2 input){
			Vector2 outPut = Vector2.zero;
			outPut.x = input.x * Mathf.Sqrt(1 - (input.y * input.y)/2);
			outPut.y = input.y * Mathf.Sqrt(1 - (input.x * input.x)/2);
			return outPut;
	}
}
