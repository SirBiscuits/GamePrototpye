using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		//Make sure rooms dont generate on themselves
		Destroy(other.gameObject);
		
	}
}
