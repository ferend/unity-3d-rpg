using System;
using UnityEngine;
using UnityEngine.AI;

namespace Model
{
    public class PlayerMovement : MonoBehaviour
    {
        private Ray _lastRay;
        private RaycastHit _hit;
        
        private void Update()
        {
            if (Camera.main != null) _lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);        

            if (Input.GetMouseButtonDown(0))
            {
                MoveToMousePosition();
            }
            Debug.DrawRay(_lastRay.origin , _lastRay.direction * 100);
        }


        private void MoveToMousePosition()
        {
            Ray ray = _lastRay;
           bool hasHit = Physics.Raycast(ray, out _hit);

           if (hasHit)
           {
               GetComponent<NavMeshAgent>().destination = _hit.point;
           }
        }
    }
}
