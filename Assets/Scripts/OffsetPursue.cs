using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursue : SteeringBehaviour
{
    public Boid leader;

    Vector3 targetPos;
    Vector3 worldTarget;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - leader.transform.position;
        print(offset);
        offset = Quaternion.Inverse(leader.transform.rotation) * offset;
        print(offset);
    }
    public void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }

    public override Vector3 Calculate()
    {
        worldTarget = leader.transform.TransformPoint(offset);
        print("Leader"+leader.transform.position);
        print("offset"+worldTarget);
        float dist = Vector3.Distance(worldTarget, transform.position);
        float time = dist / boid.maxSpeed;
        targetPos = worldTarget+  (leader.velocity * time);
        return boid.ArriveForce(targetPos);
    }
 
}
