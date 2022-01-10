using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   

namespace Core
{
    public class Movement : MonoBehaviour, IAction
    {
        private NavMeshAgent navMeshAgent;
        Health health;

        private void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            health = GetComponent<Health>();
        }
        private void Update()
        {
            navMeshAgent.enabled = !health.IsDead();

            UpdateAnimator();
        }
        public void StartMoveAction(Vector3 destination)
        {
            GetComponent<Scheduler>().StartAction(this);
            MoveTo(destination);
        }

        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.destination = destination;
            navMeshAgent.isStopped = false;
        }
        public void Cancel()
        {
            navMeshAgent.isStopped = true;
        }
        void UpdateAnimator()
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}
