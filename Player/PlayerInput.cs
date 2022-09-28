using UnityEngine;

// 플레이어 캐릭터를 조작하기 위한 사용자 입력을 감지
// 감지된 입력값을 다른 컴포넌트들이 사용할 수 있도록 제공
public class PlayerInput : MonoBehaviour {
    public string moveAxisName = "Vertical"; // 앞뒤 움직임을 위한 입력축 이름
    public string rotateAxisName = "Horizontal"; // 좌우 회전을 위한 입력축 이름
    public string fireButtonName = "Fire1"; // 발사를 위한 입력 버튼 이름
    public string reloadButtonName = "Reload"; // 재장전을 위한 입력 버튼 이름

    // 값 할당은 내부에서만 가능 -> 프로퍼티 메서드 사용(변수값을 읽거나 쓰는 과정에서 유연한 처리를 삽입)
    // 프로퍼티 사용시 자동 변환, 안전성 증가, 접근자 개별 설정 등이 가능
    // get 과 set에 식이 없이 사용할때 -> 자동 구현 프로퍼티 : get과 set의 접근 권한을 분리하는 것 이외의 처리가 필요하지 않을 때 사용
    /* public float move { get; private set; } 코드는 아래 코드와 같음
     * public float move{
     *      get { return m_move; }
     *      private set { m_move = value; }
     * }
     * private float m_move;
     */
    //move, rotate, fire, reload는 PlayerInput 외부에서는 값을 읽기만 가능하고, 값 할당은 PlayerInput 내부에서만 가능한 자동 구현 프로퍼티
    public float move { get; private set; } // 감지된 움직임 입력값
    public float rotate { get; private set; } // 감지된 회전 입력값
    public bool fire { get; private set; } // 감지된 발사 입력값
    public bool reload { get; private set; } // 감지된 재장전 입력값

    // 매프레임 사용자 입력을 감지
    private void Update() {
        // 게임오버 상태에서는 사용자 입력을 감지하지 않는다
        if (GameManager.instance != null && GameManager.instance.isGameover)
        {
            move = 0;
            rotate = 0;
            fire = false;
            reload = false;
            return;
        }

        // move에 관한 입력 감지
        move = Input.GetAxis(moveAxisName);
        // rotate에 관한 입력 감지
        rotate = Input.GetAxis(rotateAxisName);
        // fire에 관한 입력 감지
        fire = Input.GetButton(fireButtonName);
        // reload에 관한 입력 감지
        reload = Input.GetButtonDown(reloadButtonName);
    }
}