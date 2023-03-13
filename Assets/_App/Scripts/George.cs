using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class George : MonoBehaviour
{
    public int damage = 5;
    public Animator playerAnimator;
    private int Chopping;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        îf(Chopping)
            {
            tree.chop(damage);
            playerAnimator.SetBool("hitting", true);
        }else
        {
            playerAnimator.SetBool("hitting", false);
        }
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "item")
        {
            Item item = collision.gameObject.GetComponent<Item>();
            item.pickup();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "tree")
        {
            Tree tree = other.gameObject.GetComponent<Tree>();
            transform.LookAt(tree.transform);
            Chopping = true;
        }
    }
}
