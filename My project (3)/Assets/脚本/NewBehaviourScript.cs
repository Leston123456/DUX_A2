using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Snowman;
    public float value;
    public Vector3 sizeChange;
    private Vector3 position;

    public void Start()
    {
        position = new Vector3(Snowman.transform.position.x, Snowman.transform.position.y, Snowman.transform.position.z);
    }

    public void MoveRight()
    {
        value += 0.1f;
        Snowman.transform.position = new Vector3(Snowman.transform.position.x + value, Snowman.transform.position.y, Snowman.transform.position.z);
    }

    public void RotateObject()
    {
        Snowman.transform.Rotate(20f, 0, 0);
    }

    public void GrowObject()
    {
        Snowman.transform.localScale = Snowman.transform.localScale + sizeChange;
    }

    public void ResetObject()
    {
        Snowman.transform.position = position;
        Snowman.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Snowman.transform.localScale = Vector3.one;
    }
}