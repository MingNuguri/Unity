using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
	void Update()
	{
		Move();
	}

	void Move()
	{
		// 현재 위치를 얻습니다.
		//Vector2 currentPosition = transform.position;
		// Vector2 : 2차원 공간 내에 위치한 점을 나타내기 위한 형식
		// 멤버는 X 와 Y 로 구성되어 있습니다.
		// transform : 오브젝트에 기본적으로 추가되는 Transform 컴포넌트를 나타냅니다.
		// position  : Transform 컴포넌트의 position 속성을 나타냅니다.
		//             절대 위치(월드 위치)를 나타냅니다.

		//currentPosition.x += 0.1f;
		//transform.position = currentPosition;
	}
}
