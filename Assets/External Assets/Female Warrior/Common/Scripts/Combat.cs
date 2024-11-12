using UnityEngine;
using NaughtyCharacter;

namespace Retro.ThirdPersonCharacter
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(Animator))]
    public class Combat : MonoBehaviour
    {
        private const string attackTriggerName = "Attack";
        private const string specialAttackTriggerName = "Ability";

        private Animator _animator;
        private PlayerInput _playerInput;
        private Movement _movement;

        public bool AttackInProgress {get; private set;} = false;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _playerInput = GetComponent<PlayerInput>();
            _movement = GetComponent<Movement>();
        }

        private void Update()
        {
            if(_playerInput.AttackInput && !AttackInProgress && !_movement.isInDialogue)
            {
                Attack();
            }
            else if (_playerInput.SpecialAttackInput && !AttackInProgress && !_movement.isInDialogue)
            {
                SpecialAttack();
            }
        }

        private void SetAttackStart()
        {
            AttackInProgress = true;
        }

        private void SetAttackEnd()
        {
            AttackInProgress = false;
        }

        private void Attack()
        {
            _animator.SetTrigger(attackTriggerName);
        }

        private void SpecialAttack()
        {
            _animator.SetTrigger(specialAttackTriggerName);
        }
    }
}