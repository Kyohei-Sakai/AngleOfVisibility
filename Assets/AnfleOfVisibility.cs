using UnityEngine;
using System.Collections;

public class AnfleOfVisibility : MonoBehaviour {

	public Camera eye;

	// Use this for initialization
	void Start () {
		Debug.Log (eye.aspect);
		eye.aspect = 1.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
