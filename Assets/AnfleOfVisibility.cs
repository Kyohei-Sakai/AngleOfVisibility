using UnityEngine;
using System.Collections;

public class AnfleOfVisibility : MonoBehaviour {

	public Camera eye;

	// Use this for initialization
	void Start () {
		Debug.Log (eye.aspect);
		eye.aspect = 1.0f;

		// Viewport Rectを変更
//		eye.rect = new Rect (0, 0.5f, 0.5f, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
