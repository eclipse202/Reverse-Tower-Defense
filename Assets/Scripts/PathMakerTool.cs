using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using System.Windows;

public class PathMakerTool : MonoBehaviour
{
    List<Vector3> pathPoints = new List<Vector3>();
    LineRenderer lineRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pathPoints.Add(point);
            Debug.Log("Added point at: " + point);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            string codeForPoints = "List<Vector3> pathPoints = new List<Vector3>();\n";
            foreach (var point in pathPoints)
            {
                codeForPoints += $"pathPoints.Add(new Vector3({point.x}f, {point.y}f));\n";
            }

            codeForPoints.CopyToClipboard();
            Debug.Log("Path points have been saved to clipboard. To use them just paste" +
                " Ctrl + V in the file you want to add the points to");
        }
    }
}
