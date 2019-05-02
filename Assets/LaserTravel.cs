using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTravel : MonoBehaviour
{
    public float speed;

    public float destroyTime;

    private float timeAlive;
    // Start is called before the first frame update
    void Start()
    {
        timeAlive = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        transform.position += Vector3.forward *speed* Time.deltaTime;
        if (timeAlive >= destroyTime)
        {
            Destroy(this.gameObject);
        }
    }
}
