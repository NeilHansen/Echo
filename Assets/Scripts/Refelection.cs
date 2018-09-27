using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {

        Debug.DrawLine(transform.position, transform.forward, Color.green);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.forward, 100.0f);
            Debug.DrawLine(transform.position, transform.forward, Color.red, 3.0f);

            if (hit != null)//hit != null && hit.collider != null && hit.collider)//hit.collider.gameObject.name == "Mirror")
            {
                Debug.Log(hit.collider.name);
            //    Vector3 inDirection = Vector3.Reflect(transform.right, hit.normal);

             //   Debug.DrawRay(hit.point, inDirection * 100, Color.red, 3.0f);
             //   hit = Physics2D.Raycast(hit.point + hit.normal * 0.01f, inDirection, 100.0f);

             
            }

        }

    }
}
