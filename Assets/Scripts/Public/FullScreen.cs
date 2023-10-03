using UnityEngine;
using System.Collections;

public class FullScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Camera>().aspect = 800f/480f;
		//Camera.main.aspect=800f/480f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
