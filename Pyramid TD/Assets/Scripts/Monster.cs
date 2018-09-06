using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
    // Navigate to Castle
    GameObject pyramid = GameObject.Find("Pyramid");
    if (pyramid)
      GetComponent<UnityEngine.AI.NavMeshAgent>().destination = pyramid.transform.position;
	}

	void OnTriggerEnter(Collider co) {
    // If castle then deal Damage
    if (co.name == "Pyramid") {
      co.GetComponentInChildren<Health>().decrease();
			Destroy(gameObject);
    }
	}
}
