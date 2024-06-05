using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject enemy;
    private Rigidbody rb;
    public Transform enemyTransform;
    public Transform targetObj;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, speed * Time.deltaTime);
        rb = GetComponent<Rigidbody>();
        float moveHorizontal = transform.position.x;
        float moveVertical = transform.position.z;
        Vector3 roll = new Vector3(x: moveHorizontal, y: 0, z: moveVertical);
        Vector3 Jump = new Vector3(x: 0, y: 0, z: moveVertical);
        enemyTransform = GameObject.FindGameObjectWithTag("Enemies").transform;
        rb.AddForce(roll * (speed * Time.deltaTime));
        rb.AddForce(Jump * (speed * Time.deltaTime));
    }
}
