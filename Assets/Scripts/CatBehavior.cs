using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ൿ Ÿ���� ��Ÿ���� ���� ���� ����
/// </summary>
public enum BehaviorType : sbyte 
{
	// ��� ����
	Idle = 0,

	// �̵� ����
	Move = 1
}


public class CatBehavior : MonoBehaviour
{
	// ���� ������ ������� �ൿ�� ��Ÿ���ϴ�.
	BehaviorType _BehaviorType;

	// ���� �ൿ�� ������ �ð��� ��Ÿ���ϴ�.
	DateTime _NextBehaviorTime;

	void Update()
	{
		// �ൿ�� ���� �ð��� Ȯ�ν�ŵ�ϴ�.
		CheckBehaviorTime();
	}

	// �ൿ�� ���� �ð��� Ȯ���մϴ�.
	void CheckBehaviorTime()
	{
		// ���� �ð��� ����ϴ�.
		DateTime nowTime = DateTime.Now;

		// ���� �ൿ�� ������ �ð��� �Ǿ��ٸ�
		if (nowTime >= _NextBehaviorTime)
		{

		}

	}

}
