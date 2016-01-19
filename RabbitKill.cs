using UnityEngine;
using System.Collections;

public class RabbitKill : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "World"){
			return;
		}
		if (other.tag == "Crossbow"){
			return;
		}
		if (other.tag == "Player"){
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);		
	}
}
