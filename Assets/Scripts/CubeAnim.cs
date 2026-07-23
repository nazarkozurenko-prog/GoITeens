using UnityEngine;

public class CubeAnim : MonoBehaviour
{
    private Animator animator;
    public GameObject spherePrefab;
    
    void Awake()
    {
        animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.H)) 
        {
            animator.SetTrigger("Win");
        }
    }

    public void SpawnSphere()
    {
        Instantiate(spherePrefab, transform.position, transform.rotation);
    }
}
