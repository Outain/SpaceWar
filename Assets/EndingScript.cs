using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript : MonoBehaviour
{
    public GameObject explosion;
    public Transform ex1, ex2, ex3, ex4, ex5;

    public float timeBetweenExplosions;

  

    public Animator anim;

    public float timeUntilEnd;

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(Ending());

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        print(time);
    }

    public void End()
    {
        
    }

    IEnumerator Ending()
    {
        yield return new WaitForSeconds(timeUntilEnd);
        Instantiate(explosion, ex1.position, Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenExplosions);
        Instantiate(explosion, ex2.position, Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenExplosions);
        Instantiate(explosion, ex3.position, Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenExplosions);
        Instantiate(explosion, ex4.position, Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenExplosions);
        Instantiate(explosion, ex5.position, Quaternion.identity);
        anim.SetTrigger("end");
        
        yield return null;
    }
}
