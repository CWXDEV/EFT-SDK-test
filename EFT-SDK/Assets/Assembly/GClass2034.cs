using System;
using System.Runtime.CompilerServices;
using EFT.Communications;
using Newtonsoft.Json;

// Token: 0x02001D0E RID: 7438
public abstract class GClass2034 : GClass2033
{
	// Token: 0x170017E9 RID: 6121
	// (get) Token: 0x06009A06 RID: 39430 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A07 RID: 39431 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public bool Active
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170017EA RID: 6122
	// (get) Token: 0x06009A08 RID: 39432 RVA: 0x00002050 File Offset: 0x00000250
	public override ENotificationIconType Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009A09 RID: 39433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(EHideoutNotificationType eventType, Action onClick)
	{
		throw null;
	}

	// Token: 0x06009A0A RID: 39434 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnClick()
	{
		throw null;
	}

	// Token: 0x06009A0B RID: 39435 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Show()
	{
		throw null;
	}

	// Token: 0x06009A0C RID: 39436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Hide()
	{
		throw null;
	}

	// Token: 0x0400A142 RID: 41282
	[JsonProperty("alert")]
	public bool Alert;

	// Token: 0x0400A143 RID: 41283
	[JsonProperty("eventType")]
	public EHideoutNotificationType EventType;

	// Token: 0x0400A144 RID: 41284
	[CompilerGenerated]
	private bool bool_0;
}
