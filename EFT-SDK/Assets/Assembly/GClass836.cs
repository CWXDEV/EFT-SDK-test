using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000A14 RID: 2580
public class GClass836
{
	// Token: 0x060038CD RID: 14541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float time)
	{
		throw null;
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(float time, float keyTime, GClass836.GInterface37 queueItem)
	{
		throw null;
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float time)
	{
		throw null;
	}

	// Token: 0x04003A86 RID: 14982
	private List<GClass836.Class532> list_0;

	// Token: 0x04003A87 RID: 14983
	private GClass831<GClass836.Class532> gclass831_0;

	// Token: 0x04003A88 RID: 14984
	private float float_0;

	// Token: 0x04003A89 RID: 14985
	private GClass836.GInterface37 ginterface37_0;

	// Token: 0x04003A8A RID: 14986
	private bool bool_0;

	// Token: 0x02000A15 RID: 2581
	public interface GInterface37
	{
		// Token: 0x060038D1 RID: 14545
		void Release();
	}

	// Token: 0x02000A16 RID: 2582
	private class Class532
	{
		// Token: 0x04003A8B RID: 14987
		public float time;

		// Token: 0x04003A8C RID: 14988
		public GClass836.GInterface37 queueItem;
	}
}
