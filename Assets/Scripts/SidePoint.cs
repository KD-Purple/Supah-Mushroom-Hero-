using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePoint : MonoBehaviour
{
    [SerializeField] private Transform oppositePoint;
    [SerializeField] private Transform target;
    [SerializeField] private bool leftSide;

    // Update is called once per frame
    private void Update()
    {
        if(leftSide){
            if(transform.position.x > target.position.x){
                MovetoOppositePoint();
            }
        }
        else
        {
            if(transform.position.x < target.position.x){
                MovetoOppositePoint();
            }
        }
    }

    private void MovetoOppositePoint() => target.position = new Vector2(oppositePoint.position.x, target.position.y);

}
