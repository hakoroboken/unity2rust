using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;


public class create_message : MonoBehaviour
{
    public udp_send _udp;
    private GameInputs _gameInputs;

    public GameObject _circle;
    public GameObject _cross;
    public GameObject _square;
    public GameObject _triangle;
    public GameObject _up;
    public GameObject _down;
    public GameObject _left;
    public GameObject _right;
    public GameObject _r1;
    public GameObject _r2;
    public GameObject _r3;
    public GameObject _l1;
    public GameObject _l2;
    public GameObject _l3;
    public GameObject _touchpad;
    public GameObject _option;
    public GameObject _share;

    public GameObject _R;
    public GameObject _L;

    private Image circle;
    private Image cross;
    private Image square;
    private Image triangle;
    private Image up;
    private Image down;
    private Image right;
    private Image left;
    private Image r1;
    private Image r2;
    private Image r3;
    private Image l1;
    private Image l2;
    private Image l3;
    private Image touchpad;
    private Image option;
    private Image share;

    public Sprite[] _arrow;
    public Sprite[] _button;
    public Sprite[] _1;
    public Sprite[] _2;
    public Sprite[] _minibutton;
    public Sprite[] _touch;

    public float _Ci;
    public float _Cr;
    public float _Sq;
    public float _Tr;
    public float _Up;
    public float _Do;
    public float _Ri;
    public float _Le;
    public float _R1;
    public float _R2;
    public float _R3;
    public float _L1;
    public float _L2;
    public float _L3;
    public float _To;
    public float _Op;
    public float _Sh;

    public Vector2 _LeftInputValue;
    public Vector2 _RightInputValue;
    public Vector2 _LeftLocateValue;
    public Vector2 _RightLocateValue;

    private void Awake()
    {
        _gameInputs = new GameInputs();

        _gameInputs.Action.Circle.performed += OnCircleStart;
        _gameInputs.Action.Circle.canceled += OnCircleEnd;
        _gameInputs.Action.Cross.performed += OnCrossStart;
        _gameInputs.Action.Cross.canceled += OnCrossEnd;
        _gameInputs.Action.Square.performed += OnSquareStart;
        _gameInputs.Action.Square.canceled += OnSquareEnd;
        _gameInputs.Action.Triangle.performed += OnTriangleStart;
        _gameInputs.Action.Triangle.canceled += OnTriangleEnd;

        _gameInputs.Action.Up.performed += OnUpStart;
        _gameInputs.Action.Up.canceled += OnUpEnd;
        _gameInputs.Action.Down.performed += OnDownStart;
        _gameInputs.Action.Down.canceled += OnDownEnd;
        _gameInputs.Action.Right.performed += OnRightStart;
        _gameInputs.Action.Right.canceled += OnRightEnd;
        _gameInputs.Action.Left.performed += OnLeftStart;
        _gameInputs.Action.Left.canceled += OnLeftEnd;

        _gameInputs.Action.R1.performed += OnR1Start;
        _gameInputs.Action.R1.canceled += OnR1End;
        _gameInputs.Action.R2.performed += OnR2Start;
        _gameInputs.Action.R2.canceled += OnR2End;
        _gameInputs.Action.R3.performed += OnR3Start;
        _gameInputs.Action.R3.canceled += OnR3End;
        _gameInputs.Action.L1.performed += OnL1Start;
        _gameInputs.Action.L1.canceled += OnL1End;
        _gameInputs.Action.L2.performed += OnL2Start;
        _gameInputs.Action.L2.canceled += OnL2End;
        _gameInputs.Action.L3.performed += OnL3Start;
        _gameInputs.Action.L3.canceled += OnL3End;

        _gameInputs.Action.TouchPad.performed += OnTouchStart;
        _gameInputs.Action.TouchPad.canceled += OnTouchEnd;
        _gameInputs.Action.Options.performed += OnOptionStart;
        _gameInputs.Action.Options.canceled += OnOptionEnd;
        _gameInputs.Action.Share.performed += OnShareStart;
        _gameInputs.Action.Share.canceled += OnShareEnd;

        _gameInputs.Action.RightStick.started += OnRight;
        _gameInputs.Action.RightStick.performed += OnRight;
        _gameInputs.Action.RightStick.canceled += OnRight;
        _gameInputs.Action.LeftStick.started += OnLeft;
        _gameInputs.Action.LeftStick.performed += OnLeft;
        _gameInputs.Action.LeftStick.canceled += OnLeft;

        _gameInputs.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        circle = _circle.GetComponent<Image>();
        cross = _cross.GetComponent<Image>();
        square = _square.GetComponent<Image>();
        triangle = _triangle.GetComponent<Image>();
        up = _up.GetComponent<Image>();
        down = _down.GetComponent<Image>();
        right = _right.GetComponent<Image>();
        left = _left.GetComponent<Image>();
        r1 = _r1.GetComponent<Image>();
        r2 = _r2.GetComponent<Image>();
        r3 = _r3.GetComponent<Image>();
        l1 = _l1.GetComponent<Image>();
        l2 = _l2.GetComponent<Image>();
        l3 = _l3.GetComponent<Image>();
        touchpad = _touchpad.GetComponent<Image>();
        option = _option.GetComponent<Image>();
        share = _share.GetComponent<Image>();

        _Ci = 0;
        _Cr = 0;
        _Sq = 0;
        _Tr = 0;
        _Up = 0;
        _Do = 0;
        _Ri = 0;
        _Le = 0;
        _R1 = 0;
        _R2 = 0;
        _R3 = 0;
        _L1 = 0;
        _L2 = 0;
        _L3 = 0;
        _To = 0;
        _Op = 0;
        _Sh = 0;

        _udp._message = "";
    }

    private void OnDestroy()
    {
        _gameInputs?.Dispose();
    }

    private void OnCircleStart(InputAction.CallbackContext context)
    {
        circle.sprite = _button[1];
        _Ci = 1;
    }
    private void OnCircleEnd(InputAction.CallbackContext context)
    {
        circle.sprite = _button[0];
        _Ci = 0;
    }
    private void OnCrossStart(InputAction.CallbackContext context)
    {
        cross.sprite = _button[1];
        _Cr = 1;
    }
    private void OnCrossEnd(InputAction.CallbackContext context)
    {
        cross.sprite = _button[0];
        _Cr = 0;
    }
    private void OnSquareStart(InputAction.CallbackContext context)
    {
        square.sprite = _button[1];
        _Sq = 1;
    }
    private void OnSquareEnd(InputAction.CallbackContext context)
    {
        square.sprite = _button[0];
        _Sq = 0;
    }
    private void OnTriangleStart(InputAction.CallbackContext context)
    {
        triangle.sprite = _button[1];
        _Tr = 1;
    }
    private void OnTriangleEnd(InputAction.CallbackContext context)
    {
        triangle.sprite = _button[0];
        _Tr = 0;
    }
    private void OnUpStart(InputAction.CallbackContext context)
    {
        up.sprite = _arrow[1];
        _Up = 1;
    }
    private void OnUpEnd(InputAction.CallbackContext context)
    {
        up.sprite = _arrow[0];
        _Up = 0;
    }
    private void OnDownStart(InputAction.CallbackContext context)
    {
        down.sprite = _arrow[1];
        _Do = 1;
    }
    private void OnDownEnd(InputAction.CallbackContext context)
    {
        down.sprite = _arrow[0];
        _Do = 0;
    }
    private void OnRightStart(InputAction.CallbackContext context)
    {
        right.sprite = _arrow[1];
        _Ri = 1;
    }
    private void OnRightEnd(InputAction.CallbackContext context)
    {
        right.sprite = _arrow[0];
        _Ri = 0;
    }
    private void OnLeftStart(InputAction.CallbackContext context)
    {
        left.sprite = _arrow[1];
        _Le = 1;
    }
    private void OnLeftEnd(InputAction.CallbackContext context)
    {
        left.sprite = _arrow[0];
        _Le = 0;
    }
    private void OnR1Start(InputAction.CallbackContext context)
    {
        r1.sprite = _1[1];
        _R1 = 1;
    }
    private void OnR1End(InputAction.CallbackContext context)
    {
        r1.sprite = _1[0];
        _R1 = 0;
    }
    private void OnR2Start(InputAction.CallbackContext context)
    {
        r2.sprite = _2[1];
        _R2 = 1;
    }
    private void OnR2End(InputAction.CallbackContext context)
    {
        r2.sprite = _2[0];
        _R2 = 0;
    }
    private void OnR3Start(InputAction.CallbackContext context)
    {
        r3.sprite = _button[1];
        _R3 = 1;
    }
    private void OnR3End(InputAction.CallbackContext context)
    {
        r3.sprite = _button[0];
        _R3 = 0;
    }
    private void OnL1Start(InputAction.CallbackContext context)
    {
        l1.sprite = _1[1];
        _L1 = 1;
    }
    private void OnL1End(InputAction.CallbackContext context)
    {
        l1.sprite = _1[0];
        _L1 = 0;
    }
    private void OnL2Start(InputAction.CallbackContext context)
    {
        l2.sprite = _2[1];
        _L2 = 1;
    }
    private void OnL2End(InputAction.CallbackContext context)
    {
        l2.sprite = _2[0];
        _L2 = 0;
    }
    private void OnL3Start(InputAction.CallbackContext context)
    {
        l3.sprite = _button[1];
        _L3 = 1;
    }
    private void OnL3End(InputAction.CallbackContext context)
    {
        l3.sprite = _button[0];
        _L3 = 0;
    }
    private void OnTouchStart(InputAction.CallbackContext context)
    {
        touchpad.sprite = _touch[1];
        _To = 1;
    }
    private void OnTouchEnd(InputAction.CallbackContext context)
    {
        touchpad.sprite = _touch[0];
        _To = 0;
    }
    private void OnOptionStart(InputAction.CallbackContext context)
    {
        option.sprite = _minibutton[1];
        _Op = 1;
    }
    private void OnOptionEnd(InputAction.CallbackContext context)
    {
        option.sprite = _minibutton[0];
        _Op = 0;
    }
    private void OnShareStart(InputAction.CallbackContext context)
    {
        share.sprite = _minibutton[1];
        _Sh = 1;
    }
    private void OnShareEnd(InputAction.CallbackContext context)
    {
        share.sprite = _minibutton[0];
        _Sh = 0;
    }
    private void OnRight(InputAction.CallbackContext context)
    {
        _RightInputValue = context.ReadValue<Vector2>();
        _RightLocateValue = _RightInputValue;
        _RightInputValue *= 1000;
        _RightInputValue.x += 1000;
        _RightInputValue.y += 1000;
        _RightLocateValue *= 60f;
        _R.transform.localPosition = _RightLocateValue;
    }
    private void OnLeft(InputAction.CallbackContext context)
    {
        _LeftInputValue = context.ReadValue<Vector2>();
        _LeftLocateValue = _LeftInputValue;
        _LeftInputValue *= 1000;
        _LeftInputValue.x += 1000;
        _LeftInputValue.y += 1000;
        _LeftLocateValue *= 60f;
        _L.transform.localPosition = _LeftLocateValue;
    }

    // Update is called once per frame
    void Update()
    {
        _udp._message = _RightInputValue.x.ToString("0000") + "," + _RightInputValue.y.ToString("0000") + "," + _LeftInputValue.x.ToString("0000") + "," + _LeftInputValue.y.ToString("0000") + "," + _R1 + "," + _L1 + "," + _R2 + "," + _L2 + "," + _R3 + "," + _L3 + "," + _Ci + "," + _Cr + "," + _Sq + "," + _Tr + "," + _Ri + "," + _Do + "," + _Le + "," + _Up + "," + _Op + "," + _Sh + "," + _To;
    }
}
