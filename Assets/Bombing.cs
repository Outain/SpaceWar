using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBomb();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            SpawnBomb();
        }
    }

    public void SpawnBomb()
    {
        Instantiate(bomb, transform.position, Quaternion.Euler(90,0,0));
    }
}
