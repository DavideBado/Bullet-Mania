using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InUpdate();
    }

    void InUpdate()
    {
        BulletMove();
    }

    #region UPDATE
    void BulletMove()
    {
        transform.position += new Vector3(0, Speed * Time.deltaTime);
    }
    #endregion
}
