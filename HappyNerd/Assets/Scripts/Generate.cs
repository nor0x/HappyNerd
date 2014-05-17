using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject obstacles;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacles", 1.5f, 3.0f);
	}
	
	void CreateObstacles()
	{
		Instantiate(obstacles);
	}
}
