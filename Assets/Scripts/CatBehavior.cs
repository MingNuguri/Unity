using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 행동 타입을 나타내기 위한 열거 형식
/// </summary>
public enum BehaviorType : sbyte 
{
	// 대기 상태
	Idle = 0,

	// 이동 상태
	Move = 1
}


public class CatBehavior : MonoBehaviour
{
	// 현재 설정된 고양이의 행동을 나타냅니다.
	BehaviorType _BehaviorType;

	// 다음 행동이 결정될 시간을 나타냅니다.
	DateTime _NextBehaviorTime;

	void Update()
	{
		// 행동에 대한 시간을 확인시킵니다.
		CheckBehaviorTime();
	}

	// 행동에 대한 시간을 확인합니다.
	void CheckBehaviorTime()
	{
		// 현재 시간을 얻습니다.
		DateTime nowTime = DateTime.Now;

		// 다음 행동을 설정할 시간이 되었다면
		if (nowTime >= _NextBehaviorTime)
		{

		}

	}

}
