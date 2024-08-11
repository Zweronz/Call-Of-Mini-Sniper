using System.Collections.Generic;
using UnityEngine;

internal class TUIInputManageriOS
{
	private static TUIInput[] m_input;

	public static void UpdateInput()
	{
		List<TUIInput> list = new List<TUIInput>();
		TUIInput item = default(TUIInput);
		TUIInput item2 = default(TUIInput);
		TUIInput item3 = default(TUIInput);
		for (int i = 0; i < PCInput.touches.Length; i++)
		{
			if (PCInput.touches[i].phase == TouchPhase.Began)
			{
				item.fingerId = PCInput.touches[i].fingerId;
				item.inputType = TUIInputType.Began;
				item.position = PCInput.touches[i].position;
				item.deltaPosition = PCInput.touches[i].deltaPosition;
				list.Add(item);
			}
			else if (PCInput.touches[i].phase == TouchPhase.Moved)
			{
				item2.fingerId = PCInput.touches[i].fingerId;
				item2.inputType = TUIInputType.Moved;
				item2.position = PCInput.touches[i].position;
				item2.deltaPosition = PCInput.touches[i].deltaPosition;
				list.Add(item2);
			}
			else if (PCInput.touches[i].phase == TouchPhase.Ended)
			{
				item3.fingerId = PCInput.touches[i].fingerId;
				item3.inputType = TUIInputType.Ended;
				item3.position = PCInput.touches[i].position;
				item3.deltaPosition = PCInput.touches[i].deltaPosition;
				list.Add(item3);
			}
		}
		m_input = list.ToArray();
	}

	public static TUIInput[] GetInput()
	{
		return m_input;
	}
}
