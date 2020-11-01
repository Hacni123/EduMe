using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLogic : MonoBehaviour
{
    private PlayerController pc;
    void Start()
    {
        pc = GetComponentInParent<PlayerController>();	
    }

    private void OnTriggerStay2D (Collider2D other) {
		if(other.gameObject.tag== "Ground")
		{
			pc.grounded=true;
		}
	}
private void OnTriggerEnter2D (Collider2D other) {
		if(other.gameObject.tag== "Ground")
		{
			pc.grounded=true;
		}
	}

private void OnTriggerExit2D (Collider2D other) {
		if(other.gameObject.tag== "Ground")
		{
			pc.grounded=false;
		}
	}

    // Update is called once per frame
   
}
