using System.Collections.Generic;
using UnityEngine;

public class Dijkstra : MonoBehaviour
{
    public static List<Node> FindPath(Node start, Node goal)
    {
        List<Node> open = new List<Node>();
        List<Node> closed = new List<Node>();

        Dictionary<Node, float> costs = new Dictionary<Node, float>();
        Dictionary<Node, Node> parents = new Dictionary<Node, Node>();

        open.Add(start);
        costs[start] = 0f;

        while (open.Count > 0)
        {
            Node current = GetLowestCostNode(open, costs);

            if (current == goal)
            {
                return ReconstructPath(goal, parents);
            }

            open.Remove(current);
            closed.Add(current);

            for (int i = 0; i < current.neighbors.Count; i++)
            {
                Node neighbor = current.neighbors[i];

                if (closed.Contains(neighbor))
                    continue;

                float newCost = costs[current] + Vector3.Distance(
                    current.transform.position,
                    neighbor.transform.position
                );

                if (!costs.ContainsKey(neighbor) || newCost < costs[neighbor])
                {
                    costs[neighbor] = newCost;
                    parents[neighbor] = current;

                    if (!open.Contains(neighbor))
                    {
                        open.Add(neighbor);
                    }
                }
            }
        }

        return new List<Node>();
    }

    private static Node GetLowestCostNode(List<Node> open, Dictionary<Node, float> costs)
    {
        Node best = open[0];
        float bestCost = costs[best];

        for (int i = 1; i < open.Count; i++)
        {
            if (costs[open[i]] < bestCost)
            {
                best = open[i];
                bestCost = costs[open[i]];
            }
        }

        return best;
    }

    private static List<Node> ReconstructPath(Node goal, Dictionary<Node, Node> parents)
    {
        List<Node> path = new List<Node>();
        Node current = goal;

        path.Add(current);

        path.Reverse();
        return path;
    }
}
