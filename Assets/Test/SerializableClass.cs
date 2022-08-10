

using System;

[Serializable]//使用[Serializable]告诉编译器，该类实例可被序列化
public class serializableClass{
	public string name;
	public int age;
	public bool isHero;

	public serializableClass(string name)
	{
		this.name = name;
	}
}