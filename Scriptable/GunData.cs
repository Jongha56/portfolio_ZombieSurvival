using UnityEngine;

//스크립터블 오브젝트 에셋으로 만들어 각기 다른 총의 데이터를 관리할 수 있게 만들어줌
//유니티의 에셋 생성 메뉴에서 GunData 타입의 에셋을 생성하는 메뉴를 만들어줌
[CreateAssetMenu(menuName ="Scriptable/GunData",fileName ="Gun Data")]
public class GunData : ScriptableObject //ScriptableObject 상속받아서 동작할 수 있게 바꿔줌
{
    public AudioClip shotClip; // 발사 소리
    public AudioClip reloadClip; // 재장전 소리

    public float damage = 25; // 공격력

    public int startAmmoRemain = 100; // 처음에 주어질 전체 탄약
    public int magCapacity = 25; // 탄창 용량

    public float timeBetFire = 0.12f; // 총알 발사 간격
    public float reloadTime = 1.8f; // 재장전 소요 시간
}