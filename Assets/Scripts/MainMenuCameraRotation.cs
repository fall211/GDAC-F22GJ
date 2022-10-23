using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCameraRotation : MonoBehaviour
{
	public Transform target;
	
	private void Update(){
		float rotate_speed = 4f;
		transform.LookAt(target);
		transform.Translate(Vector3.left * Time.deltaTime * rotate_speed);
	}
}
