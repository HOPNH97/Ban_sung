using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{

    public GameObject flare;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnDestroy()
    {
        Instantiate(flare, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
