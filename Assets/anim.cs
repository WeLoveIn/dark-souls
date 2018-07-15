using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour {
	public Animator ani;
	public PlayerInput pi;
	public GameObject player;
	// Use this for initialization
	void Awake () {
		ani = GetComponent<Animator>();
		pi = transform.parent.gameObject.GetComponent<PlayerInput>();
	}
	
	// Update is called once per frame
	void Update () {
		if(pi.Dmag > 0.1f)
		transform.forward = Vector3.Slerp(player.transform.forward,pi.Dvec,.25f);
		ani.SetFloat("ground",pi.Dmag * Mathf.Lerp(ani.GetFloat("ground"),((pi.runEnable)? 2 : 1),.1f));
		if (Input.GetKeyDown(pi.keyB))
		{
			ani.SetTrigger("jump");
		}
		
	}
}
