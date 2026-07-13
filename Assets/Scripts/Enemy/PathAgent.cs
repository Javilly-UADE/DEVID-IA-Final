using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PathAgent : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    [SerializeField] private float rotationSpeed = 8f;
    [SerializeField] private float reachDistance = 0.2f;

    private Rigidbody rb;
    private List<Node> path = new List<Node>();
    private int currentIndex = 0;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetPath(List<Node> newPath)
    {
        path = newPath;
        currentIndex = 0;
    }

    private void FixedUpdate()
    {
        if (path == null || path.Count == 0 || currentIndex >= path.Count)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }

        Vector3 target = path[currentIndex].transform.position;
        Vector3 dir = target - transform.position;
        dir.y = 0f;

        if (dir.magnitude < reachDistance)
        {
            currentIndex++;
            return;
        }

        Vector3 moveDir = dir.normalized;

        rb.linearVelocity = moveDir * speed;

        if (moveDir != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDir);
            rb.MoveRotation(
                Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime)
            );
        }
    }
}
