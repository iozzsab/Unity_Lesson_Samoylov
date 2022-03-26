using UnityEngine;
using System.Collections;
using UnityEngine.AI;

namespace StartGameDev
{
	public class NavMesh : MonoBehaviour
	{
		EnemyVision navMesh;
		public Transform target;
		NavMeshAgent agent;

		void Start()
		{
			agent = GetComponent<NavMeshAgent>();

		}


		
		void Update()
		{
			
			agent.SetDestination(target.position);
		}
		
	}
}