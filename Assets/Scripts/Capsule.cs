using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour {


    [SerializeField] AudioClip collect;

    AudioSource audioSource;
    ScoreManager scoreBoard;

    private Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CollectPill();
        }
    }

    private void CollectPill()
    {
        rend.enabled = false;        // turn off visibility of the pill
        audioSource.PlayOneShot(collect);

        

        Destroy(gameObject, 0.5f);       // destroy the pill in 0.5 s
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

        rend = GetComponent<Renderer>();    // reference the renderer
        rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
