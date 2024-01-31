using System;
using System.Runtime.CompilerServices;
using EFT.Communications;
using EFT.UI;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x02001CB2 RID: 7346
public abstract class NotificationClass
{
	// Token: 0x1700177D RID: 6013
	// (get) Token: 0x0600994E RID: 39246
	public abstract string Description { get; }

	// Token: 0x1700177E RID: 6014
	// (get) Token: 0x0600994F RID: 39247 RVA: 0x00002050 File Offset: 0x00000250
	public virtual ENotificationIconType Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700177F RID: 6015
	// (get) Token: 0x06009950 RID: 39248 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool ShowNotification
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001780 RID: 6016
	// (get) Token: 0x06009951 RID: 39249 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Color? TextColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001781 RID: 6017
	// (get) Token: 0x06009952 RID: 39250 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Color? BackgroundColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009953 RID: 39251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BaseNotificationView CreateView(GInterface365 viewFactory)
	{
		throw null;
	}

	// Token: 0x06009954 RID: 39252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400A0BC RID: 41148
	[JsonProperty("type")]
	public ENotificationType Type;

	// Token: 0x0400A0BD RID: 41149
	[JsonProperty("time")]
	public float Time;

	// Token: 0x0400A0BE RID: 41150
	[JsonIgnore]
	public ENotificationDurationType Duration;
}
