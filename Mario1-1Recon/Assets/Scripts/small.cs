using UnityEngine;
using System.Collections;

public class small : MonoBehaviour {

	public Vector2 height;
	public Vector2 startPos;
	public float Speed = 3f;
	public float bumpHeight = .5f;

	private bool bump = false;



	void Start(){

		startPos = transform.position;
		height = transform.position;
		height.y += bumpHeight;


	}




	void Update(){

		if(bump == true){
			transform.position = Vector3.MoveTowards (transform.position, height , Speed* Time.deltaTime);
			//bump = false;
			Debug.Log("UP");
		}
		if (transform.position.y == height.y) {
			while (transform.position.y != startPos.y) {
				transform.position = Vector3.MoveTowards (transform.position, startPos, Speed * Time.deltaTime);
				Debug.Log ("DOWN");
				bump = false;
			}
				
		}
	
	}

	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {

		bump = true;
	
	}
}
