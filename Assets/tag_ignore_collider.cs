using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_ignore_collider : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {

	    if (collision.gameObject.tag == "Key") {
	        Physics.IgnoreCollision(collision.collider, this.GetComponent<Collider>()); 
		}

    }
}
