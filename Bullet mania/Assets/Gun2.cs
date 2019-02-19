using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject Bullet;
    public float Timer, SpawnRate;
    public float r;
    public int BulletsNum;
    Vector3 Center;
    // Start is called before the first frame update
    void Start()
    {
        InStart();
    }

    // Update is called once per frame
    void Update()
    {
        InUpdate();
    }

    void InStart()
    {
        SetCenter();
    }

    void InUpdate()
    {
        Shoot();
        Rotate();
        TimerCheck();
    }

    #region START
    void SetCenter()
    {
        Center = transform.position;
    }
    #endregion
    #region UPDATE

    void Shoot()
    {
        if (Timer <= 0)
        {
            for (int i = 0; i < BulletsNum; i++)
            {
                GameObject.Instantiate(Bullet, PointOnCircle(Center, r, i), Quaternion.identity);
            }
            Timer = SpawnRate;
        }
    }

    void Rotate()
    {

    }

    void TimerCheck()
    {
        Timer -= Time.deltaTime;
    }
    #endregion

    Vector3 PointOnCircle(Vector3 center, float r, int i)
    {
        return center + Quaternion.AngleAxis(45f * i, Vector3.forward) * (Vector3.right * r);
    }
}
