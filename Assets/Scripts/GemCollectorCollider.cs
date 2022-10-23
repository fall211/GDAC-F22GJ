using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollectorCollider : MonoBehaviour
{
	private int gems_collected;
	public ParticleSystem particle_system;
	public TMP_Text text_field;


	void Start(){
		var emissions = particle_system.emission;
		emissions.enabled = false;
	}

	void OnTriggerEnter(){
		gems_collected++;

		if (gems_collected == 3) {
			var emissions = particle_system.emission;
			emissions.enabled = true;
			text_field.text = ("Well done!\nTry not to die so soon this time!");

		}
	}
	
	void OnTriggerExit(){
		gems_collected--;
	}

}
