using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public GameObject smoke;

    public float shootingTime = 0.5f;
    float oldShootingTime;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //nhấn chuột trái. viên đạn xuất hiện đi theo đường thẳng.
        if (Input.GetButton("Fire1") && Time.time > oldShootingTime + shootingTime)
        {
            oldShootingTime = Time.time;

            Instantiate(bullet, transform.position, transform.rotation);

            Instantiate(smoke, transform.position, Quaternion.identity);

            audioSource.Play();
        }
    }
}
