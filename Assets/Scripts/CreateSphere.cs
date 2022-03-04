using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    //====
    public GameObject obj;
    public float force;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            // vẽ 1 đường thẳng từ vị trí camera đến điểm vị trí chuột tiếp xúc với màn hình có vật.
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Ray ray = new Ray(transform.position, transform.forward);
            // trả về đối tượng va chạm tên "hit";
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Plane")
            {
                 Instantiate(obj, hit.point, Quaternion.identity);
                //hit.rigidbody.AddForce(Vector3.one * force);
            }
        }
    }
}
