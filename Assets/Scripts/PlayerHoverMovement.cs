using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoverMovement : MonoBehaviour
{
    public float MaxSpeed = 10f;
    public float DistanceFromGround = 30f;
    public Transform orientation;

    private void Update() {
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");

        Vector3 newPos = transform.position;
        newPos += orientation.right * Hor * MaxSpeed * Time.deltaTime;
        newPos += orientation.forward * Ver * MaxSpeed * Time.deltaTime;

        transform.position = newPos;

        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit)) {
            newPos.y = (hit.point + Vector3.up * DistanceFromGround).y;
        }

        transform.position = newPos;
    }

}
