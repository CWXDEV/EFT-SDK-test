using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using Newtonsoft.Json;

// Token: 0x02001CE5 RID: 7397
public abstract class GClass1993 : NotificationClass
{
	// Token: 0x170017A4 RID: 6052
	// (get) Token: 0x060099B8 RID: 39352
	protected abstract HashSet<string> RequestsCache { get; }

	// Token: 0x170017A5 RID: 6053
	// (get) Token: 0x060099B9 RID: 39353 RVA: 0x00002050 File Offset: 0x00000250
	public override bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017A6 RID: 6054
	// (get) Token: 0x060099BA RID: 39354 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060099BB RID: 39355 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("profile")]
	public UpdatableChatMember Profile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0400A116 RID: 41238
	private UpdatableChatMember updatableChatMember_0;

	// Token: 0x0400A117 RID: 41239
	private bool bool_0;
}
