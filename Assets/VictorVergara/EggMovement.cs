using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vergara{
    public class EggMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        private Rigidbody2D rb2D;
        public bool win;

            void Awake(){
                //rb2D = gameObject.GetComponent<Rigidbody2D>();
            }
        
            void FixedUpdate(){
                if(!(win)){
                float inputX = Input.GetAxis("Horizontal");
                float inputY = Input.GetAxis("Vertical");
                transform.position += new Vector3(inputX, inputY, 0) * Time.deltaTime * 10f; 
                }

            }
    }
}