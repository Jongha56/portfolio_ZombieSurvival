## portfolio_ZombieSurvival

**목차**
1. 각 폴더 설명
2. 플레이 영상
3. 참고 서적
---
**1. 각 폴더 설명**
* **Item : 게임 상에서 필요한 아이템 관련 스크립트를 모아놓은 폴더입니다.**
  * AmmoPack.cs : 총알을 추가하는 아이템
  * Coin.cs : 게임 점수를 증가시키는 아이템
  * Gun.cs : 총을 구현하는 스크립트, 총을 발사하거나, 재장전 등 기본 기능을 구현했습니다.
  * HealthPack.cs : 체력을 회복하는 아이템
* **Manager : 게임을 하는데 기본적으로 필요한 기능을 담당하는 스크립트를 모아놓은 폴더입니다.**
  * GameManager.cs : 점수를 추가하고, 게임오버 처리등의 기능을 구현했습니다.
  * IDamageable.cs : 데미지를 입을 수 있는 타입들이 공통적으로 가져야하는 인터페이스로, 인터페이스를 사용해 공격받은 물체가 어떤 타입인지 쉽게 파악할 수 있게 구현했습니다.
  * IItem.cs : 아이템 타입들이 공통적으로 가져야하는 인터페이스로, 인터페이스를 사용해 습득한 아이템이 어떤 타입인지 쉽게 파악할 수 있게 구현했습니다.
  * ItemSpawner.cs : 내비메쉬를 이용해 아이템을 주기적으로 플레이어 근처에 생성하게 해주는 기능을 구현했습니다.
  * LivingEntity.cs : 생명체로서 기본적인 능력인 체력, 데미지 받기, 체력 회복, 사망 이벤트를 구현했습니다.
  * Rotator.cs : 게임 오브젝트를 지속적으로 회전시키는 스크립트입니다.
  * UIManager.cs : 다른 스크립트에서 HUD Canvas 게임 오브젝트의 각 UI 요소를 편리하게 접근해서 쉽게 갱신하도록 접근 경로를 만드는 스크립트입니다.
  * ZombieSpawner.cs : 좀비 게임 오브젝트를 주기적으로 생성해주는 기능을 구현했습니다.
* **Player : 플레이어와 관련된 기능을 가진 스크립트를 모아놓은 폴더입니다.**
  * PlayerHealth.cs : 생명체의 기본기능을 가진 LivingEntity를 상속하고, 기본 기능에 대해 상세하게 구현했습니다.
  * PlayerInput.cs : 플레이어를 조작하기 위한 사용자의 입력을 감지하고, 입력값을 다른 컴포넌트들이 사용할 수 있도록 구현했습니다.
  * PlayerMovement.cs : PlayerInput의 입력값을 이용해 플레이어의 움직임을 담당하는 스크립트입니다.
  * PlayerShooter.cs : PlayerInput의 입력값을 이용해 총을 발사하고, 총 발사의 애니메이터를 담당하는 스크립트입니다.
* **Scriptable : 스크립터블 오브젝트 에셋으로 만들어 각기 다른 데이터를 관리할 수 있게 만들어 놓은 스크립트를 모아놓은 폴더입니다.**
  * GunData.cs : 총의 기본 능력과 다른 총을 사용하고 싶으면 에셋을 만들어서 관리할 수 있습니다.
  * ZombieData.cs : 기본 좀비의 능력치를 담당하고, 다른 좀비를 생성하고 싶으면 에셋을 만들어서 관리할 수 있습니다.
* **Zombie : 좀비와 관련된 스크립트를 모아놓은 폴더입니다.**
  * Zombie.cs : LivingEntity를 상속받아 기본 기능을 구현하고, 플레이어를 추적하는 기능을 추가하였습니다.
---
**2. 플레이 영상**

[Zombie Survival Game 영상](https://velog.io/@jongha56/Zombie-Survival-Portfolio)

---
**3. 참고 서적**</br>
레트로의 유니티 게임 프로그래밍 에센스
