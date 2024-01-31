using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Communications;

// Token: 0x02001CD7 RID: 7383
public abstract class GClass1960 : NotificationClass
{
	// Token: 0x1700178F RID: 6031
	// (get) Token: 0x060099A0 RID: 39328 RVA: 0x00002050 File Offset: 0x00000250
	public virtual ENotificationRequirements Requirement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001790 RID: 6032
	// (get) Token: 0x060099A1 RID: 39329 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060099A2 RID: 39330
	protected abstract void ApplySingleChange(ISession session, string entity, double? value);

	// Token: 0x17001791 RID: 6033
	// (get) Token: 0x060099A3 RID: 39331 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060099A4 RID: 39332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply(ISession session)
	{
		throw null;
	}

	// Token: 0x060099A5 RID: 39333 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0(KeyValuePair<string, double?> change)
	{
		throw null;
	}

	// Token: 0x0400A0FB RID: 41211
	public Dictionary<string, double?> Changes;
}
