using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : MonoBehaviour
{
	// Public svo ég get valið materialið beint úr editornum
    public Material material;
	
	// Hver pickup staður er stilltur sem trigger svo þetta er callað í hvert sinn sem hann er triggered
    private void OnTriggerEnter(Collider other)
    {
		// Athugar hvort hluturinn sem triggeraði triggerinn sé alveg örugglega ekki main pallurinn
        if (other.gameObject.tag == "Ground") return;
        Debug.Log("trigger " + other.tag);
		
		// Nær í rendererinn á hlutnum sem triggeraði svo hægt er að breyta materialinu á honum
        Renderer rend = other.gameObject.GetComponent<Renderer>();
        rend.sharedMaterial = material;
    }
}
