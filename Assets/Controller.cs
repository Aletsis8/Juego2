using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField]float speed=15;
	[SerializeField]Transform leftpaddle;
	[SerializeField]Transform rightpaddle;


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)&& leftpaddle.position.y<3.7 ){
			leftpaddle.Translate (Vector2.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)&& leftpaddle.position.y>-3.7){
			leftpaddle.Translate (Vector2.right * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.UpArrow)&& rightpaddle.position.y<3.7) {
			rightpaddle.Translate (Vector2.right * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)&& rightpaddle.position.y>-3.7) {
			rightpaddle.Translate (Vector2.left * Time.deltaTime * speed);
		}
	}
		
}