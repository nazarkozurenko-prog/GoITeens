using UnityEngine;

public class AnimHandler : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private const string walkParametr = "Walk";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool(walkParametr, true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool(walkParametr, false);
        }
    }

    public void SetWalk(bool walk)
    {
        anim.SetBool(walkParametr, walk);
    }
}
