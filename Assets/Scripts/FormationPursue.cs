using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationPursue : SteeringBehaviour
{
    public Boid target;

    Vector3 targetPos;
    public Vector3 offSet;

    private void Start()
    {
        offSet =transform.position- target.transform.position;
    }

    public void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, targetPos);
        }
    }

    public override Vector3 Calculate()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        float time = dist / boid.maxSpeed;
        Vector3 offSetPos = target.transform.position + offSet;
        targetPos = offSetPos + (target.velocity * time);

        return boid.SeekForce(targetPos);
    }
}
