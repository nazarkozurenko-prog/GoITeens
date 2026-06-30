using NUnit.Framework;
using UnityEngine;

public class AnimHandler : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private const string walkParametr = "Walk";
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            anim.SetBool(walkParametr, true);
        }
    }

    public void SetWalk(bool walk)
    {
        Animation.SetBool(walkParametr, Is);
    }
}