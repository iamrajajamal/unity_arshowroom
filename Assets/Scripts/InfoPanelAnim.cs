using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlaySlide() =>
        anim.Play("InfoAnim");

    public void CloseSlide() =>
        anim.Play("InfoAnimReverse");

}
