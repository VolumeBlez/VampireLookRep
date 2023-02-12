
using UnityEngine;

public class PlayerInputControl : MonoBehaviour
{
    [SerializeField] private Player _playerUnit;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private Animator _animator;

    private PlayerMove _playerMove = new();
    private Input _input;

    private Input Input 
    {
        get 
        {
            if(_input != null) return _input;
            return _input = new Input();
        }
    }

    private void OnDisable() 
    {
        Input.Disable();
    }

    private void Start() 
    {
        _playerMove.InitMove(_rb2D, _animator);
        Input.Enable();

        Input.Player.Move.performed += ctx => _playerMove.SetMove(ctx.ReadValue<Vector2>());
        Input.Player.Move.canceled += ctx => _playerMove.ResetMove();
    }

    private void Update()
    {
        _playerMove.MoveInput();
    }

    private void FixedUpdate() 
    {
        _playerMove.Move(_playerUnit.Data.WalkSpeed.Value);
    }

}
