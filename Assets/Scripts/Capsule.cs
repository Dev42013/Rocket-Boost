using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour {


    [SerializeField] AudioClip collect;

    AudioSource audioSource;


    private Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rend.enabled = false;
            audioSource.PlayOneShot(collect);

   

            
            Destroy(gameObject, 0.5f);
        }
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

        rend = GetComponent<Renderer>();
        rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
