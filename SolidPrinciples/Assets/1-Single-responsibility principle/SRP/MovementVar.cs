using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Movement Var", menuName = "Solid/Movement Var")]
public class MovementVar : ScriptableObject
{
    public Vector3 movementVector;
    public void Reset()
    {
        movementVector = new Vector3(0f, 0f, 0f);
    }
    public void Set(float x, float y, float z)
    {
        movementVector.Set(x, y, z);
    }
}
