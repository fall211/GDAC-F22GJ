 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class MenuCursor : MonoBehaviour {
 
     void Start () {
 
         Cursor.visible = true;
         Cursor.lockState = CursorLockMode.None; 
     }

 }