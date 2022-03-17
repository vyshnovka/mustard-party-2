using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectMovement", menuName = "ScriptableObjects/ObjectMovementScriptableObject")]

public class ObjectMovementScriptableObject : ScriptableObject
{
    [SerializeField] public float startSpeed;
    [NonSerialized] public float runtimeSpeed;

    public void OnEnable()
    {
        runtimeSpeed = startSpeed;
    }
}
