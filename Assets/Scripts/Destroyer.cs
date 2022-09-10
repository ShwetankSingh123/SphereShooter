using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
	public float delay = 3.0f;
    void Start()
    {
		Destroy (this.gameObject, delay);
    }
		
}
