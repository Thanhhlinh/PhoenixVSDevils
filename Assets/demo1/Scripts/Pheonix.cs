﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pheonix : MonoBehaviour {
	public int speed;
	public Fire x;

	void Update() {
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.Space)) {
			Instantiate(x, transform.position, Quaternion.identity);
		}
	}
}
