using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {
	
	GravityAttractor planet;
	
	void Awake () {
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
		
		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		GetComponent<Rigidbody>().useGravity = false;
		//GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	void FixedUpdate () {
		// Allow this body to be influenced by planet's gravity
		planet.Attract(transform);
	} 

    //void OnDrawGizmos() {

    //        Color color;
    //        color = Color.green;
    //        // local up
    //        DrawHelperAtCenter(this.transform.up, color, 2f);

    //        color.g -= 0.5f;
    //        // global up
    //        DrawHelperAtCenter(Vector3.up, color, 1f);

    //        color = Color.blue;
    //        // local forward
    //        DrawHelperAtCenter(this.transform.forward, color, 2f);

    //        color.b -= 0.5f;
    //        // global forward
    //        DrawHelperAtCenter(Vector3.forward, color, 1f);

    //        color = Color.red;
    //        // local right
    //        DrawHelperAtCenter(this.transform.right, color, 2f);

    //        color.r -= 0.5f;
    //        // global right
    //        DrawHelperAtCenter(Vector3.right, color, 1f);
    //    }

    //    private void DrawHelperAtCenter(Vector3 direction, Color color, float scale) {

    //        Gizmos.color = color;
    //        Vector3 destination = transform.position + direction * scale;
    //        Gizmos.DrawLine(transform.position, destination);
    //    }
    }
