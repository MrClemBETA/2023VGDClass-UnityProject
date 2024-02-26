using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows;

namespace SOS.AndrewsAdventure.Character.Party
{
    public class PartyFollow : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] float speed;

        private NavMeshAgent agent;
        private Animator animator;
        private float _animationBlend;
        private int _animIDSpeed;
        private int _animIDGrounded;
        private int _animIDJump;
        private int _animIDFreeFall;
        private int _animIDMotionSpeed;
        private float speedRateChange = 10.0f;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.speed = speed;
            _animIDSpeed = Animator.StringToHash("Speed");
            _animIDGrounded = Animator.StringToHash("Grounded");
            _animIDJump = Animator.StringToHash("Jump");
            _animIDFreeFall = Animator.StringToHash("FreeFall");
            _animIDMotionSpeed = Animator.StringToHash("MotionSpeed");
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.destination = target.position;
            Move();
        }

        private void Move()
        {
            float inputMagnitude = agent.velocity.magnitude / agent.speed;
            _animationBlend = Mathf.Lerp(_animationBlend, agent.speed * inputMagnitude, Time.deltaTime * speedRateChange);

            if (_animationBlend < 0.01f) _animationBlend = 0f;

            animator.SetFloat(_animIDSpeed, _animationBlend);
            animator.SetFloat(_animIDMotionSpeed, inputMagnitude);
        }

        public void SetTarget(Transform target) { this.target = target; }
        public float GetSpeed() { return speed; }
    }
}
