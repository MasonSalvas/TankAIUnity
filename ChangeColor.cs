using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	Animator animu;
	public float duration = 1.0F;
	public Color color0 = Color.red;
	public Color color1 = Color.green;
	public Color color2 = Color.yellow;
	public Light lt;

	void Start() {
		animu = GetComponent<Animator>();
		lt = GetComponent<Light>();
	}
	void Update() {
		double t = 1;
		
	    if (Input.GetKeyDown (KeyCode.R)) {
			
			lt.color = color0;
			
		}
		
		if (Input.GetKeyDown (KeyCode.G)) {
			
			lt.color = color1;
			
		}
		
		if (Input.GetKeyDown (KeyCode.Y)) {
			
			lt.color = color2;
			
		}
		
	}
}