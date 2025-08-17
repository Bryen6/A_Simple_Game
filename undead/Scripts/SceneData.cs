using Godot;
using System;

public partial class SceneData : Node
{
	public string path;
	public string prettyName;
	public bool pauseAllowed;

    public SceneData(string path, string prettyName, bool pauseAllowed)
	{
		this.path = path;
		this.prettyName = prettyName;
		this.pauseAllowed = pauseAllowed;
    }
}
