using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToPosition : MonoBehaviour
{
    public Transform target;
   // public GameObject targetPrefab;
    //public GameObject[] targets;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
