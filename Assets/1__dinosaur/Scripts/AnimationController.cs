using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        PlayRandomAnimation();
    }

    void PlayRandomAnimation()
    {
        if (anim.GetClipCount() > 0)
        {
            AnimationClip[] clips = new AnimationClip[anim.GetClipCount()];
            foreach (AnimationState state in anim)
            {
                AnimationClip clip = state.clip;
                if (clip != null)
                {
                    PlayAnimationClip(clip);
                    break;
                }
            }
        }
    }

    void PlayAnimationClip(AnimationClip clip)
    {
        anim.Play(clip.name);
    }
}
