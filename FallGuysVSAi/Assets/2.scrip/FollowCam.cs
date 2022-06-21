using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    Renderer ObstacleRenderer;






    void Update()
    {
        transform.position = target.position + offset;

        float Distance = Vector3.Distance(transform.position, target.transform.position);

        Vector3 Direction = (target.transform.position - transform.position).normalized;

        RaycastHit hit;
        

        if (Physics.Raycast(transform.position, Direction, out hit, Distance))

        {
           
            // 2.맞았으면 Renderer를 얻어온다.
            ObstacleRenderer = hit.collider.GetComponentInChildren<Renderer>();

                Material Mat = ObstacleRenderer.material;

                Color matColor = Mat.color;

            if (ObstacleRenderer != null)

            {
              
                // 3. Metrial의 Aplha를 바꾼다.

                matColor.a = 0.5f;

                Mat.color = matColor;   

            }
            
        }

    }
}
