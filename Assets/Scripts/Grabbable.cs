using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    private Rigidbody obj_rigidbody;
    private Transform grab_point;

    private void Awake(){
        obj_rigidbody = GetComponent<Rigidbody>();
    }
    public void Grab(Transform grab_point) {
        this.grab_point =  grab_point;
        obj_rigidbody.useGravity = false;
    }

    public void Drop() {
        this.grab_point = null;
        obj_rigidbody.useGravity = true;
    }

    private void FixedUpdate(){
        if (this.grab_point != null){
            float item_move_speed = 20f;
            Vector3 new_pos = Vector3.Lerp(transform.position, grab_point.position, Time.deltaTime * item_move_speed);
            obj_rigidbody.MovePosition(new_pos);
        }
    }
}
