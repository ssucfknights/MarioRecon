using UnityEngine;
using System.Collections;

public class Bump : MonoBehaviour {

	Animator anim;
	int bump = Animator.StringToHash("bump");








	void Start ()
	{
		anim = GetComponent<Animator>();


	}



	void OnTriggerEnter2D (Collider2D col){

		Debug.Log (gameObject.name + " has collided with " + col.gameObject.name);
		anim.SetBool (bump, true);


	}








}
