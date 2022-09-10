using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
	public Transform bulletEnd;
	public Rigidbody bulletPrefab;
	public float force = 500.0f;
	float currentTime;
	public float delay = 0.5f;
	AudioSource audioSource;
    void Start()
    {
		audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if(((Mathf.Abs(SimpleInput.GetAxis("MouseX")) > 0.75f) || (Mathf.Abs(SimpleInput.GetAxis("MouseY")) > 0.75f)) && ((Time.time - currentTime > delay) || (currentTime < 0.01f))){
			currentTime = Time.time;
			audioSource.Play ();
			Rigidbody bulletInstance = Instantiate (bulletPrefab, bulletEnd.position, bulletEnd.rotation) as Rigidbody;
			bulletInstance.AddForce (bulletEnd.forward * force);
		}
    }
}
