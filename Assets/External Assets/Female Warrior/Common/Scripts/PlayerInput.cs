using Unity.VisualScripting;
using UnityEngine;

namespace Retro.ThirdPersonCharacter
{
    public class PlayerInput : MonoBehaviour
    {
        public float rotationSpeed;

        private bool _attackInput;
        private bool _specialAttackInput;
        private Vector2 _movementInput;
        private bool _jumpInput;
        private bool _changeCameraModeInput;

        public bool AttackInput {get => _attackInput;}
        public bool SpecialAttackInput {get => _specialAttackInput;}
        public Vector2 MovementInput {get => _movementInput;}
        public bool JumpInput { get => _jumpInput; }
        public bool ChangeCameraModeInput {get => _changeCameraModeInput;}

        public Movement _movement;

        private void Start()
        {
            _movement = GetComponent<Movement>();
        }
        private void Update()
        {
            _attackInput = Input.GetMouseButtonDown(0);
            _specialAttackInput = Input.GetMouseButtonDown(1);

            _movementInput.Set(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
            _jumpInput = Input.GetButtonDown("Jump");
            _changeCameraModeInput = Input.GetKeyDown(KeyCode.F);

            //Rotate with Mouse:
            if (!_movement.isInDialogue)
            {
                Vector3 camRotation = new Vector3(0, Input.GetAxis("Mouse X"), 0);
                transform.localEulerAngles += camRotation * rotationSpeed * Time.deltaTime;
            }
        }
    }
}