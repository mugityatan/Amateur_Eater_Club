using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1.0f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //指定したスピードから現在の速度を引いて加速力を求める
        float currentSpeed = speed - rb.velocity.magnitude;
        //調整された加速力で力を加える
        rb.AddForce(new Vector3(0, 0, currentSpeed));
    }
}
