using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Vector2 death;
	public float speed = 3f;



	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector2.MoveTowards (transform.position, death, speed * Time.deltaTime);


	}

	private void OnTriggerEnter2D(Collider2D other)
	{



		if (other.tag == "Player")
		{

			if (other.name == "GroundCheck") {
				Destroy (this.gameObject);
			} 
			else {
				Debug.Log ("PLAYER HIT");
				Application.LoadLevel (Application.loadedLevel);
			}
		}


		if (other.tag == "wall")
			Destroy (this.gameObject);
	}
}
