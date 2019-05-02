using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireLaser : MonoBehaviour
{
    public GameObject laser;
    public AudioSource playAudio;
    public bool onTarget;

    public Transform topLeft, bottomLeft, topRight, bottomRight;

    public float firingOffset;

    public float coolDown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(firing());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator firing()
    {
        while (true)
        {
            if (onTarget)
            {
                Instantiate(laser, topLeft.position, Quaternion.identity);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, topRight.position, Quaternion.identity);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, bottomLeft.position, Quaternion.identity);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, bottomRight.position, Quaternion.identity);
                playAudio.Play();
                yield return new WaitForSeconds(coolDown);
            }

            yield return null;
        }
    }
}
