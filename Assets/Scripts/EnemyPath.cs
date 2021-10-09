using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath
{
    public List<Vector3> pathPoints;

    public EnemyPath()
    {

    }

    public EnemyPath(List<Vector3> pathPoints)
    {
        this.pathPoints = pathPoints;
    }
}
