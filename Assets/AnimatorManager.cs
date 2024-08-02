using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
   Animator animator;
    int horizental;
    int vertical;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        horizental = Animator.StringToHash("horizental");
        vertical = Animator.StringToHash("vertical");
    }
    void UpdateAnimatorValues(float horizentalMovement, float verticalmovement)
    {
        animator.SetFloat(horizental, horizentalMovement, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, verticalmovement, 0.1f, Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
