using System;
using MessagePack;

[MessagePackObject]
public class Thrusters {
	[Key(0)]
	public float hfs { get; set; } = 0.0f;

	[Key(1)]
	public float hfp { get; set; }  = 0.0f;

	[Key(2)]
	public float has { get; set; }  = 0.0f;

	[Key(3)]
	public float hap { get; set; }  = 0.0f;

	[Key(4)]
	public float vfp { get; set; }  = 0.0f;

	[Key(5)]
	public float vfs { get; set; }  = 0.0f;

	[Key(6)]
	public float vap { get; set; }  = 0.0f;

	[Key(7)]
	public float vas { get; set; }  = 0.0f;
}
