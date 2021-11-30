using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotateSpeed = 1;
    public float translateSpeed = 1 ;

    private void Update(){
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime); // 0 , 1 ,0
        transform.Translate(Vector3.right *translateSpeed * Time.deltaTime); //1 , 0 ,0 
    }

}
