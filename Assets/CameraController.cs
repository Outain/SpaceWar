using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera1, camera2, camera3, camera4, camera5, camera6, camera7;

    public float time1, time2, time3, time4, time5, time6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CameraEditing()
    {
        yield return new WaitForSeconds(time1);
        camera1.SetActive(false);
        camera2.SetActive(true);
        yield return new WaitForSeconds(time2);
        camera2.SetActive(false);
        camera3.SetActive(true);
        yield return new WaitForSeconds(time3);
        camera3.SetActive(false);
        camera4.SetActive(true);
        yield return new WaitForSeconds(time4);
        camera4.SetActive(false);
        camera5.SetActive(true);
        yield return new WaitForSeconds(time5);
        camera5.SetActive(false);
        camera6.SetActive(true);
        yield return new WaitForSeconds(time6);
        camera6.SetActive(false);
        camera7.SetActive(true);
        yield return null;
    }
}
