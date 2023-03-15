using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ARCharacterNav : CharacterNav
{
    void Update()
    {
        //deplacement du personnage
        if(Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            Touch touch = Input.GetTouch(0);
            List<ARRaycastHit> hitPoints = new List<ARRaycastHit>();
            if (arRaycastManager.Raycast(touch.position,hitPoints))
            {

                player.SetDestination( hitPoint.pose.position);
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
