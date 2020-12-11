using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField]
    float force = 35f;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("Hing",5);
	}
    void Hing() {

        rb.AddForce(Vector2.down * force);
    }
   
}
