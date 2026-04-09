using UnityEngine;

public class EnemyCircleMove : MonoBehaviour
{
    public Transform center;      // 圆心
    public float radius = 3f;     // 半径
    public float speed = 2f;      // 转动速度
    private float angle;          // 当前角度

    void Start()
    {
        // 初始化角度，避免所有敌人都从同一个位置开始
        Vector3 offset = transform.position - center.position;
        angle = Mathf.Atan2(offset.z, offset.x);
    }

    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = center.position.x + Mathf.Cos(angle) * radius;
        float z = center.position.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, transform.position.y, z);
    }
}