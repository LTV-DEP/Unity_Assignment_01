using System;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 2f;
    public Vector3 localOffset = new Vector3(4f, 0f, 0f);
    
    private Vector3 start;
    private Vector3 end;
    private Vector3 target;

    private void Start()
    {
        start = transform.position;
        end = start + localOffset;
        target = end;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) <= 0.1f)
        {
            target = (target == end) ? start : end;
        }
    }
}
