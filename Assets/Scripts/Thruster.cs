using System;
using MessagePack;

[MessagePackObject]
public class Thrusters {
	[Key(0)]
	public float T_HFS { get; set; } = 0.0f;

	[Key(1)]
	public float T_HFP { get; set; }  = 0.0f;

	[Key(2)]
	public float T_HAS { get; set; }  = 0.0f;

	[Key(3)]
	public float T_HAP { get; set; }  = 0.0f;

	[Key(4)]
	public float T_VFP { get; set; }  = 0.0f;

	[Key(5)]
	public float T_VFS { get; set; }  = 0.0f;

	[Key(6)]
	public float T_VAP { get; set; }  = 0.0f;

	[Key(7)]
	public float T_VAS { get; set; }  = 0.0f;
}
