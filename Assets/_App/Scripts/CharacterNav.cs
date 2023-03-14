using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterNav : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent player;
    public Animator playerAnimator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray,out hitPoint))
            {
                player.SetDestination(hitPoint.point);
            }
        }

        if(player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("walking",true);
        }
        else if(player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("walking", false);
        }
    }
}
