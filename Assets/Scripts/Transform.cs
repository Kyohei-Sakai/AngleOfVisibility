using UnityEngine;
using System.Collections;

public class Transform : MonoBehaviour {

	public GameObject cube;

	// Use this for initialization
	void Start () {
		
		Debug.Log (cube.name);
		Debug.Log (cube.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
