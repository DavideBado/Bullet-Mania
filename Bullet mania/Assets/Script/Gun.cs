using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    Vector3 DestinationPoint, StartingPoint, EndPoint;
    Vector3 ShootPosition1, ShootPosition2;
    public float Speed, Timer, SpawnRate;
    public Vector3 StartLocation;

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
        SetPositions();
        SetBool();
        SetFloat();
    }

    void InUpdate()
    {
        DestinationUpdate();
        Shoot();
        TimerCheck();
    }

    #region START
    void SetPositions()
    {       
        StartingPoint = Vector3.zero;
        transform.position = StartingPoint;
        EndPoint = new Vector3(2, 0);
        DestinationPoint = EndPoint;
        ShootPosition1 = StartingPoint;
        ShootPosition2 = DestinationPoint;
    }

    void SetBool()
    {
       
    }
    
    void SetFloat()
    {
        Timer = SpawnRate;
    }

    #endregion

    #region UPDATE  
    void DestinationUpdate()
    {
        if (transform.position == StartingPoint)
        {
            DestinationPoint = EndPoint;           
        }
        else if(transform.position == EndPoint)
        {
            DestinationPoint = StartingPoint;            
        }
        GunMove();
    }  
    void Shoot()

    {
        if (Timer <= 0)
        {
            GameObject.Instantiate(Bullet, transform.position, Quaternion.identity);
            Timer = SpawnRate;
        }
    }
    void TimerCheck()
    {
        Timer-= Time.deltaTime;
    }
    
    #endregion

    void GunMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, DestinationPoint, Speed * Time.deltaTime);
    }
}

