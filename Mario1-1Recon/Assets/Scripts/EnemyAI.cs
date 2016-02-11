using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Vector2 death;
	public float speed = 3f;
	//for score to be represented in UI
	public GameObject score;




	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector2.MoveTowards (transform.position, death, speed * Time.deltaTime);


	}

	private void OnTriggerEnter2D(Collider2D other)
	{



		if (other.tag == "Player")
		{

			if (other.name == "GroundCheck") {
				//references UI script and adds 100 to the variable score
				Score uiscript = score.GetComponent<Score> ();
				uiscript.score = uiscript.score + 100;
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
