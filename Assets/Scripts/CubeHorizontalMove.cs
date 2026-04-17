using UnityEngine;

public class CubeHorizontalMove : MonoBehaviour
{
    public float cubespeed = 5f;
    public float range = 10f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = -Mathf.Sin(Time.time * cubespeed) * range;
        transform.position = new Vector3(startPos.x + x, startPos.y, startPos.z);
    }
}
