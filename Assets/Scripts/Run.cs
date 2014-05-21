using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour
{
	
		Animator animator;
		GameObject wheel;
	
		void Start ()
		{
				animator = GetComponent<Animator> ();
				wheel = GameObject.Find ("Wheel");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				float speed = animator.GetFloat ("speed");
		
				if (Input.GetKeyDown (KeyCode.Space)) {
						speed += 0.5f;
				}
				
				speed = speed * 0.99f; // constantly slow down
				
				if (speed < 0.4f) {
						speed = 0.0f;
				}
				
				wheel.transform.Rotate (0, 0, speed);
				
				print ("speed = " + speed);
				
				animator.SetFloat ("speed", speed);
	
		}
	
	
}
