using UnityEngine;
using UnityEngine.AI;

public class Alt_karakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _Navmesh;

    void Awake()
    {
        _Navmesh = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;
    }

    private void LateUpdate()
    {
        _Navmesh.SetDestination(Target.transform.position);
    }
}
