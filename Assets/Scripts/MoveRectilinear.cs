using UnityEngine;
using System.Collections;

public class MoveRectilinear : MonoBehaviour {

	public GameObject obj;

	public float velocity = 0.1f;

	// Use this for initialization
	void Start () {
		if (obj == null) {
			return;
		}

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = obj.transform.position;
		pos.z += velocity;
		obj.transform.position = pos;

	}
}
