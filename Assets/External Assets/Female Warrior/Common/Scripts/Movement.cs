using UnityEngine;

namespace Retro.ThirdPersonCharacter
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Combat))]
    [RequireComponent(typeof(CharacterController))]
    public class Movement : MonoBehaviour
    {
        public float groundOffset = 0.2f;
        private bool grounded = false;
        public bool isInDialogue = false;

        private Animator _animator;
        private PlayerInput _playerInput;
        private Combat _combat;
        private CharacterController _characterController;

        private Vector2 lastMovementInput;
        private Vector3 moveDirection = Vector3.zero;

        public float gravity = 10;
        public float jumpSpeed = 4; 

        public float MaxSpeed = 10;
        private float DecelerationOnStop = 0.00f;


        private void Start()
        {
            _animator = GetComponent<Animator>();
            _playerInput = GetComponent<PlayerInput>();
            _combat = GetComponent<Combat>();
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (_animator == null) return;

            if (isInDialogue)
            {
                _animator.SetFloat("InputX", lastMovementInput.x);
                _animator.SetFloat("InputY", lastMovementInput.y);
                return;
            }

            if(_combat.AttackInProgress)
            {
                StopMovementOnAttack();
            }
            else
            {
                Move();
            }
        }
        private void Move()
        {
            var x = _playerInput.MovementInput.x;
            var y = _playerInput.MovementInput.y;

            //bool grounded = _characterController.isGrounded;
            //Do a raycast downwards to check if the player character is touching the ground or not
            RaycastHit hit;
            Vector3 rayDir = Vector3.down;
            if (Physics.Raycast(transform.position, rayDir, out hit, groundOffset)) grounded = true;
            else grounded = false;


            if (grounded)
            {
                    moveDirection = new Vector3(x, 0, y);
                    moveDirection = transform.TransformDirection(moveDirection);
                    moveDirection *= MaxSpeed;
                if (_playerInput.JumpInput)
                    moveDirection.y = jumpSpeed;
            }

            moveDirection.y -= gravity * Time.deltaTime;
            _characterController.Move(moveDirection * Time.deltaTime);

            _animator.SetFloat("InputX", x);
            _animator.SetFloat("InputY", y);
            _animator.SetBool("IsInAir", !grounded);
        }

        private void StopMovementOnAttack()
        {
            var temp = lastMovementInput;
            temp.x -= DecelerationOnStop;
            temp.y -= DecelerationOnStop;
            lastMovementInput = temp;

            _animator.SetFloat("InputX", lastMovementInput.x);
            _animator.SetFloat("InputY", lastMovementInput.y);
        }
        public void EnterDialogue()
        {
            isInDialogue = true;
        }
        public void ExitDialogue()
        {
            Invoke("TurnOffDialogue", 0.1f);
        }

        private void TurnOffDialogue()
        {
            isInDialogue = false;
        }
    }
}