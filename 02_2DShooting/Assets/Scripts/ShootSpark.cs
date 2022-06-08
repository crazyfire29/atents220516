using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpark : MonoBehaviour
{
    void Start()
    {
        Animator anim = GetComponent<Animator>();
        Destroy(this.gameObject, anim.GetCurrentAnimatorClipInfo(0)[0].clip.length);
    }
}
