using UnityEngine;

public class PlayFootstep : MonoBehaviour
{
    public void PlaySound()
    {
        SoundManager.PlaySound(SoundType.WALK_CONCRETE);
    }
}
