using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    [SerializeField] float minY;
    [SerializeField] float maxY;
    [SerializeField] float xPos;
    [SerializeField] GameObject cupPrefab;

    void Start()
    {
        for (float i = minY; i <= maxY; i += (maxY-minY) / 5)
        {
            Instantiate(cupPrefab, new Vector2(xPos, i), Quaternion.identity);
        }

        for (float i = minY; i <= maxY; i += (maxY-minY) / 5)
        {
            Instantiate(cupPrefab, new Vector2(-xPos, i), Quaternion.identity);
        }
    }
}
