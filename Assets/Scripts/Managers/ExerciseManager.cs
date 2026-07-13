using System.Collections.Generic;
using UnityEngine;

public class ExerciseManager : MonoBehaviour
{
    [SerializeField] private NodeManager nodeManager;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform goalPoint;
    [SerializeField] private PathAgent agent;

    private void Start()
    {
        Node startNode = nodeManager.GetClosestNode(startPoint.position);
        Node goalNode = nodeManager.GetClosestNode(goalPoint.position);

        if (startNode == null || goalNode == null)
        {
            Debug.LogError("No se encontraron nodos válidos para StartPoint o GoalPoint.");
            return;
        }

        List<Node> path = Dijkstra.FindPath(startNode, goalNode);
        agent.SetPath(path);
    }
}