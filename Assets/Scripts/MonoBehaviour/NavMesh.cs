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
			if (agent.enabled)
			{
				agent.SetDestination(target.position);
			}
			
		}
	
	}
}