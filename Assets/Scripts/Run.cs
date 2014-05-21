using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour
{
	
		Animator animator;
	
		void Start ()
		{
				animator = GetComponent<Animator> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				float speed = animator.GetFloat ("speed");
		
				if (Input.GetKeyDown (KeyCode.Space)) {
						speed += 0.5f;
				}
				
				speed = speed * 0.975f; // constantly slow down
				
				if (speed < 0.4f) {
						speed = 0.0f;
				}
				
				print ("speed = " + speed);
				
				animator.SetFloat ("speed", speed);
	
		}
	
	
}
