using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float rotSpeed = 100;

    public Transform moveSpot;

    private float waitTime;
    [SerializeField] private float startWaitTime;

    public float minX, minZ, maxX, maxZ;

    void Start(){
        waitTime = startWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), .5f, Random.Range(minZ, maxZ));
    }

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                moveSpot.position = new Vector3(Random.Range(minX, maxX), .5f, Random.Range(minZ, maxZ));
                Quaternion.LookRotation(moveSpot.position, Vector3.up);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

}
