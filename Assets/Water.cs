using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public Transform water;
    public float maxY;

    // Update is called once per frame
    private void Update()
    {
        water.position = new Vector3(water.position.x, water.position.y + Time.deltaTime * 0.6f, water.position.z);
        if (water.position.y >= maxY)
        {
            water.position = new Vector3(water.position.x, maxY, water.position.z);
            return;
        }
    }
}
