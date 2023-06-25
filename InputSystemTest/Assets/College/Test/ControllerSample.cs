using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerSample : MonoBehaviour
{
    [SerializeField] private InputAction _fireAction;

    private CollegeExampleAction _collegeExampleAction;

    // private void Start()
    // {
    //     _fireAction.performed += _ => Debug.Log("Fire");
    // }

    private void Start()
    {
        _collegeExampleAction = new CollegeExampleAction();
        _collegeExampleAction.Player.Test.performed += _ => Debug.Log("test"); 
        _collegeExampleAction.Player.WeakSkill.performed += _ => Debug.Log("weak");
        
        // これを記載し忘れてずっと動かなかった
        _collegeExampleAction.Enable();
    }
    
    private void Update()
    {
        #region Keyboard

        // 現在のキーボード情報
        var currentKeyboard = Keyboard.current;

        // キーボード接続チェック
        if (currentKeyboard == null)
            return;

        // スペースキーが押された瞬間かどうか
        if (currentKeyboard.spaceKey.wasPressedThisFrame)
            Debug.Log("スペースキーが押された！");

        #endregion

        #region Virtual Stick

        // 現在のゲームパッド情報
        var currentPad = Gamepad.current;

        // ゲームパッド接続チェック
        if (currentPad == null)
            return;

        // 左スティック入力取得
        var leftStickValue = currentPad.leftStick.ReadValue();
        Debug.Log($"移動量：{leftStickValue}");

        #endregion
    }
    
    private void OnEnable()
    {
        _fireAction.Enable();
    }

    private void OnDisable()
    {
        _fireAction.Disable();
    }

    private void OnDestroy()
    {
        _fireAction.Dispose();
        _collegeExampleAction.Disable();
    }
}
