using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TowerInfo : ScriptableObject
{
    public double attackSpeed;
    public float projectileSpeed;
    public double attackDamage;
    public double attackRange;
    public int tier;
    public Sprite display;
}
