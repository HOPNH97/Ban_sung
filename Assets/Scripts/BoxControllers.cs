using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers : MonoBehaviour
{
    public GameObject boom;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (this.gameObject.tag == "Boom")
            {
                Instantiate(boom, transform.position, Quaternion.identity);
            }
            audioSource.Play();

            Destroy(this.gameObject, 0.5f);
        }
    }
}
