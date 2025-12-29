using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour, IMovement
{
	NavMeshAgent agent;
	public void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	public void Move(Vector3 target)
	{
		agent.SetDestination(target);
	}
}
