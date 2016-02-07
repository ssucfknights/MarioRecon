using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	void start(){

		transform.position = player.position;


	}




	void Update () 
	{

		if(player.position.x > transform.position.x){ 
			transform.position = new Vector3 (player.position.x, offset.y, offset.z); // Camera follows the player with specified offset position
		
		}

	}
}
