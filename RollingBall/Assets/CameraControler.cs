using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

    public Transform sphere;

	
	// Update is called once per frame
	void Update () {
        Vector3 vector = new Vector3(0, 3f, -5f);

        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();
        float velocity = rigidbody.velocity.sqrMagnitude;

        vector = vector * (1f + velocity / 254);

        Vector3 newPosition = sphere.position + vector;

        transform.position = Vector3.Lerp(transform.position, newPosition, 0.02f);

        transform.position = sphere.position + vector;
        transform.LookAt(sphere);
    }
}
