

using System;

[Serializable]//ʹ��[Serializable]���߱�����������ʵ���ɱ����л�
public class serializableClass{
	public string name;
	public int age;
	public bool isHero;

	public serializableClass(string name)
	{
		this.name = name;
	}
}