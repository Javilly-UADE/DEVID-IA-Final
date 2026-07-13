using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    [Header("Grid")]
    [SerializeField] private Node nodePrefab;
    [SerializeField] private Vector2 gridSize = new Vector2(5f, 5f);
    [SerializeField] private float spacing = 2f;
    [SerializeField] private LayerMask obstacleMask;

    [Header("Connections")]
    [SerializeField] private float connectionRadius = 2.5f;

    private List<Node> nodes = new List<Node>();

    public List<Node> Nodes => nodes;

    private void Awake()
    {
        GenerateNodes();
        ConnectNodes();
    }

    private void GenerateNodes()
    {
        nodes.Clear();

        float startX = transform.position.x - gridSize.x / 2f;
        float startZ = transform.position.z - gridSize.y / 2f;

        for (float x = 0; x <= gridSize.x; x += spacing)
        {
            for (float z = 0; z <= gridSize.y; z += spacing)
            {
                Vector3 worldPos = new Vector3(startX + x, transform.position.y, startZ + z);

                bool blocked = Physics.CheckSphere(worldPos, 0.4f, obstacleMask);

                if (!blocked)
                {
                    Node newNode = Instantiate(nodePrefab, worldPos, Quaternion.identity, transform);
                    nodes.Add(newNode);
                }
            }
        }
    }

    private void ConnectNodes()
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            nodes[i].neighbors.Clear();

            for (int j = 0; j < nodes.Count; j++)
            {
                if (i == j)
                    continue;

                float distance = Vector3.Distance(nodes[i].transform.position, nodes[j].transform.position);

                if (distance <= connectionRadius)
                {
                    nodes[i].neighbors.Add(nodes[j]);
                }
            }
        }
    }

    public Node GetClosestNode(Vector3 position)
    {
        Node closest = null;
        float closestDistance = Mathf.Infinity;

        for (int i = 0; i < nodes.Count; i++)
        {
            float distance = Vector3.Distance(position, nodes[i].transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closest = nodes[i];
            }
        }

        return closest;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Vector3 size = new Vector3(gridSize.x, 0.1f, gridSize.y);
        Gizmos.DrawWireCube(transform.position, size);
    }
}
