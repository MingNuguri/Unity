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
		// ���� ��ġ�� ����ϴ�.
		//Vector2 currentPosition = transform.position;
		// Vector2 : 2���� ���� ���� ��ġ�� ���� ��Ÿ���� ���� ����
		// ����� X �� Y �� �����Ǿ� �ֽ��ϴ�.
		// transform : ������Ʈ�� �⺻������ �߰��Ǵ� Transform ������Ʈ�� ��Ÿ���ϴ�.
		// position  : Transform ������Ʈ�� position �Ӽ��� ��Ÿ���ϴ�.
		//             ���� ��ġ(���� ��ġ)�� ��Ÿ���ϴ�.

		//currentPosition.x += 0.1f;
		//transform.position = currentPosition;
	}
}
