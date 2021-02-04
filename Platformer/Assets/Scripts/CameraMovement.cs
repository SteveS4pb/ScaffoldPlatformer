using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    [SerializeField] private float smoothing;

    [SerializeField] private Vector2 maxPosition;
    [SerializeField] private Vector2 minPosition;

    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                                                 target.position.y,
                                                 transform.position.z);
            targetPosition.x = Mathf.Clamp(target.position.x,
                                           minPosition.x, 
                                           maxPosition.x);
            targetPosition.y = Mathf.Clamp(target.position.y,
                                          minPosition.y,
                                          maxPosition.y);
            
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

        }
    }
}
