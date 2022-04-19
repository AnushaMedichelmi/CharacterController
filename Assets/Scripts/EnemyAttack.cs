using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
            
    }
    private void OnTriggerEnter(Collider other)

    {
       if(other.gameObject.tag=="Player")
        {
            Animator.SetTrigger("Roundkick");
        }
    }

    private void OnTriggerExit(Collider other)
    {

        Animator.SetTrigger("Run");
        
    }

}
