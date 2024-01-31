using System;
using UnityEngine;

// Token: 0x02000835 RID: 2101
public static class GClass775
{
	// Token: 0x02000836 RID: 2102
	public interface GInterface29
	{
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600301D RID: 12317
		// (set) Token: 0x0600301E RID: 12318
		Vector3 HandleSized { get; set; }
	}

	// Token: 0x02000837 RID: 2103
	public class GClass776<T, U> where T : Behaviour, GClass775.GInterface29 where U : struct
	{
	}
}
