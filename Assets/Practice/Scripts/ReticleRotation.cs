using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    [SerializeField] private float rotation_speed = 30.0f;
    private float rotation_amount;

    // Start is called before the first frame update
    void Start()
    {
        rotation_amount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rotation_amount += rotation_speed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, rotation_amount, 0);
    }
}
