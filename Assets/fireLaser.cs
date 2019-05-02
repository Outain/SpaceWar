using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireLaser : MonoBehaviour
{
    public GameObject laser;
    public AudioSource playAudio;
    public bool onTarget,isXWing,isTieFighter;

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
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (isXWing)
            {
                if (hit.transform.gameObject.tag == "tiefigther")
                {
                    onTarget = true;
                }
            }
            else if (isTieFighter)
            {
                if (hit.transform.gameObject.tag == "xwing")
                {
                    onTarget = true;
                }
            }
        }
        else
        {
            onTarget = false;
        }
    }

    IEnumerator firing()
    {
        while (true)
        {
            if (onTarget)
            {
                Instantiate(laser, topLeft.position, transform.rotation);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, topRight.position, transform.rotation);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, bottomLeft.position, transform.rotation);
                playAudio.Play();
                yield return new WaitForSeconds(firingOffset);
                Instantiate(laser, bottomRight.position, transform.rotation);
                playAudio.Play();
                yield return new WaitForSeconds(coolDown);
            }

            yield return null;
        }
    }
}
