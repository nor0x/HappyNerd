using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,300);
	

	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0)
		{
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.AddForce(jumpForce);
			}
		}
		else if(Input.GetKeyUp("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if(screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Die ();
	}

	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
