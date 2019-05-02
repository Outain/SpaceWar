using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfScript : MonoBehaviour
{
    private float timeAlive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        if (timeAlive >= 3f)
        {
            Destroy(this.gameObject);
        }
    }
}
