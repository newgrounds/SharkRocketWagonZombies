﻿using UnityEngine;
using System.Collections;

public class BiteScript : MonoBehaviour {
	
	public float fuelLeft;
	public float maxFuel;



	// Use this for initialization
	void Start () {
		fuelLeft = maxFuel;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (fuelLeft);
		if (fuelLeft > 0f) {
			if (Input.GetMouseButton(0)) {
				fuelLeft -= 0.5f;
			}
		} else {
			fuelLeft = 0f;
			Dragable dragScript = (Dragable)this.GetComponent (typeof(Dragable));
			dragScript.moveLimit = 0;
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Zombie") {
			col.gameObject.renderer.enabled = false;
		}
	}
}