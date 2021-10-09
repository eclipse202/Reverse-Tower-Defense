using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class LineRendererExtensions
{
    public static List<Vector3> GetPositions(this LineRenderer lineRenderer)
    {
        var positions = new Vector3[lineRenderer.positionCount];
        lineRenderer.GetPositions(positions);
        return positions.ToList();
    }

    public static void SetPositions(this LineRenderer lineRenderer, List<Vector3> positions)
    {
        lineRenderer.SetPositions(positions.ToArray());
    }

    public static void AddPosition(this LineRenderer lineRenderer, Vector3 position)
    {
        var currentPositions = lineRenderer.GetPositions();
        Debug.Log(currentPositions.Count);
        lineRenderer.positionCount += 2;
        currentPositions.Add(position);
        lineRenderer.SetPositions(currentPositions);

        currentPositions = lineRenderer.GetPositions();
        currentPositions[currentPositions.Count - 2] = currentPositions[currentPositions.Count - 3];
        Debug.Log(currentPositions.Count);
    }
}