using UnityEngine;
using System.Collections;

public class SphereControler : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        Vector3 direction = Vector3.zero;


        if (Input.GetKey(KeyCode.UpArrow) == true) {
            direction = -Vector3.left;
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) {
            direction = Vector3.left;
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            direction = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.RightArrow) == true) {
            direction = -Vector3.forward;
        }

        rigidbody.AddTorque(direction*10f);
    }
}
