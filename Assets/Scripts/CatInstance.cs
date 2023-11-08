using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 이 컴포넌트는 고양이 객체를 대표하는 클래스이며,
/// 이 컴포넌트를 통해 고양이 객체에 추가된 다른 컴포넌트들을 관리합니다.
/// </summary>
public class CatInstance : MonoBehaviour
{
	// 고양이 행동 결정을 담당하는 객체입니다.
	public CatBehavior m_CatBehavior;

	// 이동을 담당하는 객체입니다.
	public CatMovement m_CatMovement;

}
